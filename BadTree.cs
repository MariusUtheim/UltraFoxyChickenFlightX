using GameMaker;
using System;

namespace UltraFoxyChickenFlightX
{
    public class BadTree : SceneryObject
    {

		public BadTree() : base(Room.Width + 150, Room.Height - 80)
		{
            this.Sprite = Sprites.BadTree;
            this.Transform.Scale *= .325;
			this.Transform.YScale *= 1.5;

            this.Mask.Rectangle(new IntRectangle(350, 333, 485 - 350, this.Sprite.Height - 333) - Sprite.Origin.GetValueOrDefault());
        }

		public override void OnCollision(Player player)
		{
			player.Destroy();
            Sounds.BadTree.Play();
		}
    }
}
