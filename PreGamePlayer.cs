using GameMaker;
using System;

namespace UltraFoxyChickenFlightX
{
    public class PreGamePlayer : GameObject, IKeyPressListener, IGlobalMousePressListener
    {
       // SoundInstance chickenRustle = Sounds.ChickenRustle.Play();

        public PreGamePlayer()
            : base(250, 300)
        {
			Image.Alpha = 0;
			Depth = -2;
			Transform.Scale *= 0.17;
			Sprite = Sprites.FoxyStand;
        }

        public override void OnStep()
        {
			if (Image.Alpha < 1.0)
				Image.Alpha += 0.05;
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

        public override void OnDestroy()
        {
  //          chickenRustle.Stop();
            
            base.OnDestroy();
        }

        public void StartGame()
		{
			this.Destroy();
			new Player(this.Location);
            new Farmer();
			Instance<Henhouse>.First().Velocity = SceneryObject.MovementSpeed;
			Spawner.Activate();
			GUI.Init();
		}
	}
}
