using GameMaker;
using System;

namespace Project1
{
    public class AngryCloud : SceneryObject
    {
        public static readonly Sprite AngryCloudSprite = new Sprite(Properties.Resources.AngryCloudFileName, origin: IntVector.Zero);
        public AngryCloud(double x, double y) : base(x, y) { }
        public AngryCloud(Point location) : base(location) { }

        protected override void Init()
        {
            this.Sprite = AngryCloudSprite;
            this.Transform.XScale = .2;
            this.Transform.YScale = .2;
            this.Mask.Rectangle(237, 250 , 780 - 237, this.Sprite.Height - 250 );
        }
    }
}
