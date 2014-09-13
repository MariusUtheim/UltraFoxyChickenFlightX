using GameMaker;
using System;

namespace Project1
{
    public class Henhouse : MovingObject
    {
        public static readonly Sprite FileSprite = new Sprite(Properties.Resources.HenhouseFileName, origin: IntVector.Zero);

        public Henhouse() : base(20, 200) 
        {
            this.Sprite = FileSprite;
            this.Transform.Scale *= .4;
			Speed = 0;
			Image.Alpha = 0.0;
        }

		public override void OnStep()
		{
			Image.Alpha += 0.01;
			if (BoundingBox.Right < 0)
				this.Destroy();
		}
    }
}
