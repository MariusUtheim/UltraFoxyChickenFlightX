using GameMaker;
using System;

namespace Project1
{
    public class HappyCloud : SceneryObject
    {
        public static readonly Sound HappyCloudSound = new Sound(Properties.Resources.HappyCloudSoundName);
        public const int ScoreAward = 4;
        public const int EngeryAward = 32;
        public static readonly Sprite HappyCloudSprite1 = new Sprite(Properties.Resources.HappyCloudFileName1, origin: IntVector.Zero);
        public static readonly Sprite HappyCloudSprite2 = new Sprite(Properties.Resources.HappyCloudFileName2, origin: IntVector.Zero);

        public HappyCloud()
            : base(Room.Width + 50, GRandom.Int(100, 300))
        {
            this.Sprite = HappyCloudSprite1;
            this.Transform.Scale *= .2;
            this.Mask.Rectangle(126, 283, 528 - 126, this.Sprite.Height - 283);
        }

		public override void OnCollision(Player player)
		{
			if (!(this.HasCollided))
			{
				Statistics.Score += HappyCloud.ScoreAward;
				Statistics.Energy += HappyCloud.EngeryAward;
                this.Sprite = HappyCloudSprite2;
                HappyCloudSound.Play();
			}
			this.HasCollided = true;
		}
    }
}
