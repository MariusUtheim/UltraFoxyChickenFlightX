using GameMaker;
using System;

namespace Project1
{
    public class GoodTree : SceneryObject
    {
        public static readonly Vector BoostAward = new Vector(0, -10);

		public GoodTree() 
			: base(Room.Width + 50, 450)
		{
			this.Sprite = Sprites.GoodTree;
			this.Transform.Scale *= 0.25;
			this.Mask.Rectangle(55, 66, 726 - 55, this.Sprite.Height - 66);
		}

		public override void OnCollision(Player player)
		{
			if (!(this.HasCollided))
            {
                player.Velocity = BoostAward;
            }
            this.HasCollided = true;
		}
    }
}
