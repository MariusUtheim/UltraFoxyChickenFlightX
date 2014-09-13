using GameMaker;
using System;

namespace Project1
{
    public class Henhouse : SceneryObject
    {
        public static readonly IntVector Size = new IntVector(180, 220);

        public Henhouse(double x, double y) : base(x, y) { }
        public Henhouse(Point location) : base(location) { }

        public override void OnDraw()
        {
            Fill.Rectangle(Color.Brown, new Rectangle(this.Location, Size));
        }
    }
}
