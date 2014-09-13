using GameMaker;
using System;

namespace Project1
{
    public class GoodTree : GameObject
    {
        public static readonly Sprite GoodTreeSprite = new Sprite(Properties.Resources.GoodTreeSpriteFileName, origin: IntVector.Zero);

        public GoodTree(double x, double y) : base(x, y)
        {
            this.Init();
        }

        public GoodTree(Point location) : base(location)
        {
            this.Init();
        }

        private void Init()
        {
            this.Sprite = GoodTreeSprite;
            this.Transform.XScale = .2;
            this.Transform.YScale = .2;
            this.Mask.Rectangle(320, 260, 450 - 320, this.BoundingBox.Height - 260);
        }
    }
}
