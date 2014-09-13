using GameMaker;
using System;

namespace Project1
{
    public class GoodTree : SceneryObject
    {
        public static readonly Vector BoostAward = new Vector(0, -8);
        public static readonly Sprite GoodTreeSprite = new Sprite(Properties.Resources.GoodTreeSpriteFileName, origin: IntVector.Zero);

		public GoodTree() 
			: base(Room.Width + 50, 520)
		{
			this.Sprite = GoodTreeSprite;
			this.Transform.Scale *= 0.2;
			this.Mask.Rectangle(320, 260, 450 - 320, this.Sprite.Height - 260);
		}

		public override void OnCollision(Player player)
		{
			if (!(this.HasCollided))
            {
                player.Velocity += BoostAward;
            }
            this.HasCollided = true;
		}
    }
}
