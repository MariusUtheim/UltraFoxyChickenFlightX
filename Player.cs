using GameMaker;
using System;

namespace Project1
{
    public class Player : MovingObject, IGlobalMousePressListener, IKeyPressListener
    {
        public static readonly Sprite FoxyHappySprite = new Sprite(Properties.Resources.FoxyHappyFileName, origin: IntVector.Zero);
        public static readonly Sprite FoxyScaredSprite = new Sprite(Properties.Resources.FoxyScaredFileName, origin: IntVector.Zero);
        
        private const int FlappingCost = 2;
        private const int StepScore = 1;
        private static readonly Vector GravitySpeed = new Vector(0, 0.25);
        private static readonly Vector InitialFlappingSpeed = new Vector(0, -6);
        private static readonly Vector FlappingSpeed = new Vector(0, -4);

        public Player(double x, double y)
            : base(x, y)
        {
            this.Init();
        }

        public Player(Point location)
            : base(location)
        {
            this.Init();
        }

        private void Init()
        {
            this.Velocity += InitialFlappingSpeed;

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
			}
		}

        public override void OnStep()
        {
                this.Velocity += GravitySpeed;

                Statistics.Score += StepScore;

            base.OnStep();
        }

        public override void OnDestroy()
        {
            Game.Sleep(1200);
            Game.Quit();
        }
	}
}
