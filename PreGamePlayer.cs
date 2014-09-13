using GameMaker;
using System;

namespace Project1
{
    public class PreGamePlayer : GameObject, IKeyPressListener
    {

        public PreGamePlayer(Henhouse henhouse)
            : base(350, 250)
        {
			Image.Alpha = 0;
        }

        public override void OnStep()
        {
			if (Image.Alpha < 1.0)
				Image.Alpha += 0.05;
        }

		public void OnKeyPress(Key key)
		{
			this.Destroy();
			new Player(this.Location);
			new Farmer();
			Spawner.Activate();
		}

		public override void OnDraw()
		{
			Fill.Circle(Image.Blend, Location, 30);
		}
	}
}
