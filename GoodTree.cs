using GameMaker;
using System;

namespace Project1
{
    public class GoodTree : SceneryObject
    {
        public static readonly Vector BoostAward = new Vector(0, -10);
		private double wobble = 0;
		private double wobbleAmount = 0;

		public GoodTree() 
			: base(Room.Width + 50, 450)
		{
			this.Sprite = Sprites.GoodTree;
			this.Transform.Scale *= 0.35;
			this.Mask.Rectangle(55, 66, 726 - 55, this.Sprite.Height - 66);
		}

		public override void OnCollision(Player player)
		{
			if (!(this.HasCollided))
            {
                player.Velocity = BoostAward;
                Sounds.GoodTree.Play();
            }
            this.HasCollided = true;
			wobble = 3;
		}

		public override void OnStep()
		{
			base.OnStep();
			wobbleAmount += wobble;
			if (wobble > 0)
				wobble -= 0.1;
			Transform.XScale = 0.35 * (1.0 + 0.1 * GMath.Cos(wobbleAmount));
			Transform.YScale = 0.35 * (1 + 0.1 * GMath.Sin(wobbleAmount));
		}
    }
}
