using GameMaker;
using System;

namespace Project1
{
    public class BadTree : SceneryObject
    {
        public static readonly Sprite BadTreeSprite = new Sprite(Properties.Resources.BadTreeSpriteFileName, origin: IntVector.Zero);

		public BadTree() : base(Room.Width + 50, 520)
		{
            this.Sprite = BadTreeSprite;
            this.Transform.Scale *= .2;
            this.Mask.Rectangle(350, 333, 485 - 350, this.Sprite.Height - 333);
        }
    }
}
