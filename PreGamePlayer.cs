using GRaff;
using GRaff.Audio;

namespace UltraFoxyChickenFlightX
{
    public class PreGamePlayer : GameObject, IKeyPressListener, IGlobalMousePressListener
    {
        SoundElement pregameSound = Sounds.Henhouse.Play(true, pitch: 2.2);

        public PreGamePlayer()
            : base(250, 300)
        {
			Model.Alpha = 0;
			Depth = -2;
			Transform.Scale *= 0.17;
			Sprite = Sprites.FoxyStand;
        }

        public override void OnStep()
        {
			if (Model.Alpha < 1.0)
				Model.Alpha += 0.05;
        }

		public void OnKeyPress(Key key)
		{
			if (key == Key.Space) 
				StartGame();
		}

		public void OnGlobalMousePress(MouseButton button)
		{
			if (button == MouseButton.Left)
				StartGame();
		}

        protected override void OnDestroy()
        {
            pregameSound.Destroy();
            
            base.OnDestroy();
        }

        public void StartGame()
		{
			this.Destroy();
			Instance<Player>.Create(this.Location);
			Instance<Farmer>.Create();
			Instance.One<Henhouse>().Velocity = SceneryObject.MovementSpeed;
			Spawner.Activate();
			GUI.Init();
		}
	}
}
