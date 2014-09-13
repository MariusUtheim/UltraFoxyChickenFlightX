using GameMaker;
using System;

namespace Project1
{
    public class GoodTree : SceneryObject
    {
        public static readonly Sprite GoodTreeSprite = new Sprite(Properties.Resources.GoodTreeSpriteFileName, origin: IntVector.Zero);

		public GoodTree() : base(Room.Width + 50, 520) { }

        public GoodTree(double x, double y) : base(x, y) { }

        public GoodTree(Point location) : base(location) { }

        protected override void Init()
        {
            this.Sprite = GoodTreeSprite;
            this.Transform.Scale *= .2;
            this.Mask.Rectangle(320, 260, 450 - 320, this.BoundingBox.Height - 260);

            base.Init();
        }
    }
}
