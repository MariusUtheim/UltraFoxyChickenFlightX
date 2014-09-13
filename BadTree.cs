using GameMaker;
using System;

namespace Project1
{
    public class BadTree : GameObject
    {
        public static readonly Sprite BadTreeSprite = new Sprite(Properties.Resources.BadTreeSpriteFileName, origin: IntVector.Zero);

        public BadTree(double x, double y) : base(x, y) 
        {
            this.Init();
        }

        public BadTree(Point location) : base(location)
        {
            this.Init();
        }

        private void Init()
        {
            this.Sprite = BadTreeSprite;
            this.Transform.XScale = .2;
            this.Transform.YScale = .2;
            this.Mask.Rectangle(350, 333, 485 - 350, this.Sprite.Height - 333);
        }

		public override void OnDraw()
		{
			base.OnDraw();
			Mask.DrawOutline();
		}
    }
}
