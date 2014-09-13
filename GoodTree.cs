using GameMaker;
using System;

namespace Project1
{
    public class GoodTree : SceneryObject
    {
        public static readonly Sprite GoodTreeSprite = new Sprite(Properties.Resources.GoodTreeSpriteFileName, origin: IntVector.Zero);

        public GoodTree(double x, double y) : base(x, y) { }

        public GoodTree(Point location) : base(location) { }

        protected override void Init()
        {
            this.Sprite = GoodTreeSprite;
            this.Transform.XScale = .2;
            this.Transform.YScale = .2;
        }
    }
}
