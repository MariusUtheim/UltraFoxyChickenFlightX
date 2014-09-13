using GameMaker;
using System;

namespace Project1
{
    public class BadTree : SceneryObject
    {

		public BadTree() : base(Room.Width + 50, 380)
		{
            this.Sprite = Sprites.BadTree;
            this.Transform.Scale *= .325;
            this.Mask.Rectangle(350, 333, 485 - 350, this.Sprite.Height - 333);
        }

		public override void OnCollision(Player player)
		{
			player.Destroy();
            Sounds.BadTree.Play();
		}
    }
}
