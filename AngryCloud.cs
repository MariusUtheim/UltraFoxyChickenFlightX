using GameMaker;
using System;

namespace Project1
{
    public class AngryCloud : SceneryObject
    {
		public const int ScorePenalty = 4;
        public const int EngeryPenalty = 32;
		private static Sprite AngryCloudSprite1 = new Sprite(Properties.Resources.AngryCloudFileName1, origin: IntVector.Zero);
        private static Sprite AngryCloudSprite2 = new Sprite(Properties.Resources.AngryCloudFileName2, origin: IntVector.Zero);
        private bool collision = false;

		public AngryCloud() : base(Room.Width + 50, GRandom.Int(100, 300))
		{
			Sprite = AngryCloudSprite1;
			Transform.Scale *= 0.2;
            this.Mask.Rectangle(245, 250, 754 - 245, 612 - 250);
		}

		public bool HasCollided
        {
            get { return this.collision; }
            set { this.collision = value; }
        }

	
        public override void OnCollision(Player other)
        {
            if (!(this.HasCollided))
            {
                Statistics.Score -= AngryCloud.ScorePenalty;
                Statistics.Energy -= AngryCloud.EngeryPenalty;
                this.Sprite = AngryCloudSprite2;
            }
            this.HasCollided = true;
		}
    }
}
