using GRaff;
using GRaff.Graphics;

namespace UltraFoxyChickenFlightX
{
    public class Henhouse : MovingObject
    {
        public static readonly Sprite FileSprite = Sprite.Load(Properties.Resources.HenhouseFileName, origin: IntVector.Zero);

        public Henhouse() : base(20, 200) 
        {
            this.Sprite = FileSprite;
            this.Transform.Scale *= .4;
			Speed = 0;
			Model.Alpha = 0.0;
        }

		public override void OnStep()
		{
			Model.Alpha += 0.05;
			if (X < -Model.Width)
				this.Destroy();
		}
    }
}
