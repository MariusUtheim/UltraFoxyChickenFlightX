using GRaff;
using GRaff.Audio;
using GRaff.Graphics;
using System;

namespace UltraFoxyChickenFlightX
{
    public class Farmer : GameObject, ICollisionListener<Player>
    {
        public static readonly Sprite FileSprite = Sprite.Load(Properties.Resources.FarmerFileName);
        double x0;
        private SoundElement farmerJoeSound;

        public bool IsMoveOut { get; set; }

        public Farmer()
            : base(Instance.One<Player>().Location.X - 160, 0)
        {
            this.Depth = -1;
            this.Sprite = FileSprite;
            this.Transform.Scale *= .17;
            x0 = -2500;
			this.Y = Window.Height - this.Model.Height + 150;
            
			this.Mask.Shape = MaskShape.Rectangle(new Rectangle(80, 90, 1190 - 80, this.Sprite.Height - 90) - Sprite.Origin);
        }

        public override void OnStep()
        {
            base.OnStep();

            if (x0 < 220)
                x0 += (220 - x0) / 44;
            X = x0 + 50 * GMath.Sin(Time.LoopCount / 180.0 * GMath.Tau);

            Transform.Rotation = (Time.LoopCount % 20 < 10) ? Angle.Deg(-6) : Angle.Deg(6);

            if (this.X > 0 && farmerJoeSound == null)
            {
                farmerJoeSound = Sounds.FarmerJoe.Play();
            }
        }

        public void OnCollision(Player player)
        {
			if (farmerJoeSound != null && !farmerJoeSound.Exists)
                farmerJoeSound = Sounds.FarmerJoe.Play();

            player.Scare();
        }
    }
}
