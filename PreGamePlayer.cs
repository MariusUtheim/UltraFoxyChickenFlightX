using GameMaker;
using System;

namespace Project1
{
    public class PreGamePlayer : GameObject, IKeyPressListener, IGlobalMousePressListener
    {

        public PreGamePlayer(Henhouse henhouse)
            : base(350, 250)
        {
			Image.Blend = Color.Red;
			Image.Alpha = 0;
        }

        public override void OnStep()
        {
			if (Image.Alpha < 1.0)
				Image.Alpha += 0.01;
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
			new Farmer();
			Spawner.Activate();
			GlobalEvent.Step += () => { Background.Offset += SceneryObject.MovementSpeed / 4; };
		}

		public override void OnDraw()
		{
			Fill.Circle(Image.Blend, Location, 30);
		}
	}
}
