using GRaff;
using GRaff.Audio;
using GRaff.Graphics;
using GRaff.Synchronization;

namespace UltraFoxyChickenFlightX
{
    public class Player : MovingObject, IGlobalMousePressListener, IKeyPressListener
    {
        private const int FlappingCost = 2;
        private const int StepScore = 1;

        private const double TargetBackgroundVolume = .7;

        private static readonly Vector GravitySpeed = new Vector(0, 0.25);
        private static readonly Vector InitialFlappingSpeed = new Vector(0, -9);
        private static readonly Vector FlappingSpeed = new Vector(0, -4);

        private SoundElement backgroundMusicInstance = Sounds.Background.Play(true, TargetBackgroundVolume);

        int imageIndex = 0;
        int x0 = 350;
        Sprite[] currentSprite;

        public Player(Point location)
            : base(location)
		{
            this.Velocity = InitialFlappingSpeed;
            currentSprite = Sprites.FoxyHappy;
            Sprite = Sprites.FoxyHappy[imageIndex];
			Alarm.Start(3, () =>
            {
                this.imageIndex = 1 - this.imageIndex;
                this.Sprite = currentSprite[imageIndex];
				this.Mask.Shape = MaskShape.Rectangle(new Rectangle(740, 830, 200, 700) - Sprite.Origin);
            }).IsLooping = true;

            Statistics.EnergyChanged += OnEnergyChanged;

            Transform.Scale *= 0.17;
            Model.Speed = 0.5;
			this.Mask.Shape = MaskShape.Rectangle(new Rectangle(740, 830, 200, 700) - Sprite.Origin);
        }

        private void OnEnergyChanged(int value)
        {
            if (value < FlappingCost)
            {
                this.Scare();
            }
        }

        public void Scare()
        {
            currentSprite = Sprites.FoxyScared;
			Alarm.Start(90, () => { this.currentSprite = Sprites.FoxyHappy; });
        }

        public void OnGlobalMousePress(MouseButton button)
        {
            if (button == MouseButton.Left)
                Flap();
        }

        public void OnKeyPress(Key key)
        {
            if (key == Key.Space)
                Flap();
        }

        public void Flap()
        {
            if (Statistics.Energy > 0)
            {
                this.Velocity += FlappingSpeed;
                Statistics.Energy -= FlappingCost;
                Sounds.BirdFlap.Play(volume: 5);
            }
        }

        public override void OnEndStep()
        {
            if (BoundingBox.Bottom >= Window.Height - 60)
            {
                Sounds.Groundfall.Play();

                this.Destroy();
            }
        }

        public override void OnStep()
        {
            this.Velocity += GravitySpeed;

            Statistics.Score += StepScore;

            Transform.Rotation = Angle.Deg(15 + 4 * GMath.Sin(Time.LoopCount * 0.1));

            X += (x0 - X) / 50.0;

            if (this.Y < -20 && this.Velocity.Y < 0)
            {
                this.Velocity = new Vector(this.Velocity.X, 0);
            }

            base.OnStep();
        }
        
        protected override void OnDestroy()
		{
            backgroundMusicInstance.Destroy();
            Instance<Farmer>.Do(f => { f.Destroy(); });
            Instance<MainMenu>.Create();
		}
    }
}
