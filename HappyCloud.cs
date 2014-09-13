using GameMaker;
using System;

namespace Project1
{
    public class HappyCloud : SceneryObject
    {
        public const int ScoreAward = 4;
        public const int EngeryAward = 32;

        public HappyCloud()
            : base(Room.Width + 50, GRandom.Int(100, 300))
        {
            this.Sprite = Sprites.HappyCloud;
            this.Transform.Scale *= .2;
            this.Mask.Rectangle(126, 283, 528 - 126, this.Sprite.Height - 283);
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
    }
}
