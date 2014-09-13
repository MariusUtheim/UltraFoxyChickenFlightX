using GameMaker;
using System;

namespace Project1
{
    public class AngryCloud : SceneryObject
    {
		public const int ScorePenalty = 4;
        public const int EngeryPenalty = 32;
		private static Sprite AngryCloudSprite = new Sprite(Properties.Resources.AngryCloudFileName, origin: IntVector.Zero);
        private bool collision = false;

		public AngryCloud() : base(Room.Width + 50, GRandom.Int(100, 300))
		{
			Sprite = AngryCloudSprite;
			Transform.Scale *= 0.2;
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
            }
            this.HasCollided = true;
		}
    }
}
