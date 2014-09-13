using GameMaker;
using System;

namespace Project1
{
    public class PreGamePlayer : GameObject, IKeyPressListener, IGlobalMousePressListener
    {

        public PreGamePlayer()
            : base(350, 268)
        {
			Image.Alpha = 0;
			Depth = -2;
			Transform.Scale *= 0.1;
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

		public void StartGame()
		{
			this.Destroy();
			new Player(this.Location);
//			new Farmer();
			Instance<Henhouse>.First().Velocity = SceneryObject.MovementSpeed;
			Spawner.Activate();
			GUI.Init();
		}
	}
}
