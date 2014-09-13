using GameMaker;
using System;

namespace Project1
{
    public class Henhouse : SceneryObject
    {
        public static readonly Sprite FileSprite = new Sprite(Properties.Resources.HenhouseFileName, origin: IntVector.Zero);

        public Henhouse(double x, double y) : base(x, y) { }
        public Henhouse(Point location) : base(location) { }

        protected override void Init()
        {
            this.Sprite = FileSprite;
            this.Transform.Scale *= .4;
        }
    }
}
