using GameMaker;
using System;

namespace Project1
{
    public class AngryCloud : SceneryObject
    {
		private static Sprite AngryCloudSprite = new Sprite(Properties.Resources.AngryCloudSpriteFileName, origin: IntVector.Zero);

		public AngryCloud() : base(Room.Width + 50, GRandom.Int(100, 300))
		{
			Sprite = AngryCloudSprite;
			Transform.Scale *= 0.2;
		}
        public AngryCloud(double x, double y) : base(x, y) { }
        public AngryCloud(Point location) : base(location) { }
    }
}
