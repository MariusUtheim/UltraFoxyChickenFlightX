using GRaff;
using System;

namespace UltraFoxyChickenFlightX
{
    public class BadTree : SceneryObject
    {

		public BadTree() : base(Window.Width + 150, Window.Height - 80)
		{
            this.Sprite = Sprites.BadTree;
            this.Transform.Scale *= .325;
			this.Transform.YScale *= 1.5;
            
			this.Mask.Shape = MaskShape.Rectangle(new IntRectangle(350, 333, 485 - 350, (int)this.Sprite.Height - 333) - (IntVector)Sprite.Origin);
        }

		public override void OnCollision(Player player)
		{
			player.Destroy();
            Sounds.BadTree.Play();
		}
    }
}
