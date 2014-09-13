using GameMaker;
using System;

namespace Project1
{
    public class Player : MovingObject, IGlobalMousePressListener, IKeyPressListener
    {
        public const int Radius = 15;
        private const int FlappingCost = 2;
        private const int StepScore = 1;
        private static readonly Vector GravitySpeed = new Vector(0, 0.25);
        private static readonly Vector InitialFlappingSpeed = new Vector(0, -6);
        private static readonly Vector FlappingSpeed = new Vector(0, -4);

        public static int Diameter
        { get { return Radius * 2; } }

        public Player(double x, double y)
            : base(x, y)
        {
            this.Init();
        }

        public Player(Point location)
            : base(location)
        {
            this.Init();
        }

        private void Init()
        {
            this.Velocity += InitialFlappingSpeed;
            this.Mask.Circle(Radius);
        }

        public void OnGlobalMousePress(MouseButton button)
        {
			if (button == MouseButton.Left)
				Flap();
        }

		public void OnKeyPress(Key key)
		{
			if (key == Key.Space)
				Flap();
		}

		public void Flap()
		{
			if (Statistics.Energy > 0)
			{
				this.Velocity += FlappingSpeed;
				Statistics.Energy -= FlappingCost;
			}
		}

        public override void OnStep()
        {
                this.Velocity += GravitySpeed;

                Statistics.Score += StepScore;

            base.OnStep();
        }

        public override void OnEndStep()
        {
            if (this.Y + Radius >= Window.Height)
            {
                this.Destroy();
            }
        }

        public override void OnDraw()
        {
            Fill.Circle(Color.Red, this.Location, Radius);
        }

        public override void OnDestroy()
        {
            Game.Sleep(1200);
            Game.Quit();
        }
	}
}
