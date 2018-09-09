using GRaff;
using System;

namespace UltraFoxyChickenFlightX
{
    public class AngryCloud : SceneryObject
    {
		public const int ScorePenalty = 4;
        public const int EngeryPenalty = 32;

        
		public AngryCloud() : base(Window.Width + 150, GRandom.Integer(100, 300))
		{
			this.Sprite = Sprites.AngryCloud;
			Transform.Scale *= 0.2;
			this.Mask.Shape = MaskShape.Rectangle(new Rectangle(245, 250, 754 - 245, 612 - 250) - Sprite.Origin);
		}
        
        public override void OnCollision(Player other)
        {
            if (!(this.HasCollided))
            {
				other.Scare();
                Statistics.Score -= AngryCloud.ScorePenalty;
                Statistics.Energy -= AngryCloud.EngeryPenalty; 
                this.Sprite = Sprites.AngryCloudSuperAngry;
				Sounds.AngryCloud.Play();
            }
            this.HasCollided = true;
		}
    }
}
