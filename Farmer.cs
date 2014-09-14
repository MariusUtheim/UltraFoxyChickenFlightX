using GameMaker;
using System;

namespace UltraFoxyChickenFlightX
{
    public class Farmer : GameObject, ICollisionListener<Player>
    {
        public static readonly Sprite FileSprite = new Sprite(Properties.Resources.FarmerFileName);
        double x0;
        private SoundInstance farmerJoeSound;

        public Farmer()
            : base(Instance<Player>.First().Location.X - 160, 0)
        {
            this.Depth = -1;
            this.Sprite = FileSprite;
            this.Transform.Scale *= .17;
            x0 = -2500;
            this.Y = Window.Height - this.Image.Height + 150;

            this.Mask.Rectangle(new IntRectangle(80, 90, 1190 - 80, this.Sprite.Height - 90) - Sprite.Origin.GetValueOrDefault());
        }

        public override void OnStep()
        {
            base.OnStep();
            if (x0 < 220)
                x0 += (220 - x0) / 44;
            X = x0 + 50 * GMath.Sin(Time.LoopCount / 180.0 * GMath.Tau);

            Transform.Rotation = (Time.LoopCount % 20 < 10) ? Angle.Deg(-6) : Angle.Deg(6);
        }

        public void OnCollision(Player player)
        {
            if (farmerJoeSound != null && farmerJoeSound.State == SoundState.Stopped)
                farmerJoeSound = Sounds.FarmerJoe.Play();

            player.Scare();
        }
    }
}
