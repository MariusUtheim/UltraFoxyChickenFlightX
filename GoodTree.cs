using GRaff;
using System;

namespace UltraFoxyChickenFlightX
{
    public class GoodTree : SceneryObject
    {
        public static readonly Vector BoostAward = new Vector(0, -10);
		private double wobble = 0;
		private double wobbleAmount = 0;

		public GoodTree() 
			: base(Window.Width + 150, Window.Height - 80)
		{
			this.Sprite = Sprites.GoodTree;
			this.Transform.Scale *= 0.35;
			this.Mask.Shape = MaskShape.Rectangle(new Rectangle(55, 66, 726 - 55, this.Sprite.Height - 66) - Sprite.Origin);
		}

		public override void OnCollision(Player player)
		{
			if (!(this.HasCollided))
            {
                player.Velocity = BoostAward;
                Sounds.GoodTree.Play();

				Rectangle intersection = this.BoundingBox.Intersection(player.BoundingBox).Value;
				Instance.Create(new Particles(intersection.Left - 80, intersection.Center.Y, 15, 60));
            }
            this.HasCollided = true;
			wobble = 1.0;
		}

		public override void OnStep()
		{
			base.OnStep();
			wobbleAmount += wobble;
			if (wobble > 0)
				wobble -= 1 / 60.0;
			Transform.XScale = 0.35 * (1.0 + 0.1 * GMath.Cos(wobbleAmount));
			Transform.YScale = 0.35 * (1 + 0.1 * GMath.Sin(wobbleAmount));
		}

    }
}
