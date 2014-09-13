using GameMaker;
using System;

namespace Project1
{
    public class Farmer : GameObject, ICollisionListener<Player>
    {
        public static readonly Sprite FileSprite = new Sprite(Properties.Resources.FarmerFileName, origin: IntVector.Zero);

        public Farmer()
            : base(Instance<Player>.First().Location.X - 60, 0)
        {
            this.Depth = -1;
            this.Sprite = FileSprite;
            this.Transform.Scale *= .1;
            this.Y = Window.Height - this.Image.Height + 18;

            this.Mask.Rectangle(80, 90, 1190-80, this.Sprite.Height - 90);
        }

        public void OnCollision(Player player)
        {
            player.Destroy();
        }
    }
}
