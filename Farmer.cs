using GameMaker;
using System;

namespace Project1
{
    public class Farmer : GameObject, ICollisionListener<Player>
    {
        public static readonly Sprite FileSprite = new Sprite(Properties.Resources.FarmerFileName, origin: IntVector.Zero);

        public Farmer()
            : base(Instance<Player>.First().Location.X - 10, 0)
        {
            this.Depth = -1;
            this.Sprite = FileSprite;
            this.Transform.Scale *= .075;
            this.Y = Window.Height - this.Image.Height - 20;

            this.Mask.Rectangle(0, 35, this.Image.Width, this.Image.Height - 35);
        }

        public void OnCollision(Player player)
        {
            player.Destroy();
        }
    }
}
