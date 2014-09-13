using GameMaker;
using System;

namespace Project1
{
    public class AngryCloud : SceneryObject
    {
		public const int ScorePenalty = 4;
        public const int EngeryPenalty = 32;


		public AngryCloud() : base(Room.Width + 50, GRandom.Int(100, 300))
		{
			Sprite = Sprites.AngryCloud;
			Transform.Scale *= 0.2;
            this.Mask.Rectangle(245, 250, 754 - 245, 612 - 250);
		}

        public override void OnCollision(Player other)
        {
            if (!(this.HasCollided))
            {
                Statistics.Score -= AngryCloud.ScorePenalty;
                Statistics.Energy -= AngryCloud.EngeryPenalty; 
                this.Sprite = Sprites.AngryCloudSuperAngry;
            }
            this.HasCollided = true;
		}
    }
}
