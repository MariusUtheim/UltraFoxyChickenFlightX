using GRaff;
using System;

namespace UltraFoxyChickenFlightX
{
    public class HappyCloud : SceneryObject
    {
        public const int ScoreAward = 4;
        public const int EngeryAward = 32;
		private double wobbleAmount = 0;

        public HappyCloud()
            : base(Window.Width + 150, GRandom.Integer(100, 300))
        {
            this.Sprite = Sprites.HappyCloud;
            this.Transform.Scale *= .2;
            this.Mask.Shape = MaskShape.Rectangle(new Rectangle(126, 283, 528 - 126, this.Sprite.Height - 283) - Sprite.Origin);
        }

		public override void OnCollision(Player player)
		{
			if (!(this.HasCollided))
			{
				Statistics.Score += HappyCloud.ScoreAward;
				Statistics.Energy += HappyCloud.EngeryAward;
                this.Sprite = Sprites.HappyCloudSuperHappy;
                Sounds.HappyCloud.Play();
			}
			this.HasCollided = true;
		}

		public override void OnStep()
		{
			base.OnStep();

			if (HasCollided)
			{
				wobbleAmount += 0.2;
				Transform.Rotation = Angle.Deg(5 * GMath.Sin(wobbleAmount));
			}
		}
    }
}
