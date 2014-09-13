using GameMaker;
using System;

namespace Project1
{
    public class HappyCloud : SceneryObject
    {
        public const int ScoreAward = 4;
        public const int EngeryAward = 32;
        public static readonly Sprite HappyCloudSprite = new Sprite(Properties.Resources.HappyCloudFileName, origin: IntVector.Zero);
        public HappyCloud(double x, double y) : base(x, y) { }
        public HappyCloud(Point location) : base(location) { }

        protected override void Init()
        {
            this.Transform.XScale = .2;
            this.Transform.YScale = .2;
            this.Mask.Rectangle(126, 283, 528 - 126, this.Sprite.Height - 283);
        }
    }
}
