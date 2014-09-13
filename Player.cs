using GameMaker;
using System;

namespace Project1
{
    public class Player : MovingObject, IGlobalMousePressListener, ICollisionListener<BadTree>
    {
        public const int Radius = 15;
        private static readonly Vector GravitySpeed = new Vector(0, 1.5);
        private static readonly Vector InitialFlappingSpeed = new Vector(10, -15);
        private static readonly Vector FlappingSpeed = new Vector(3, -12);

        public static int Diameter
        { get { return Radius * 2; } }

        private bool IsStarted = false;

        public Player(double x, double y)
            : base(x, y)
        {
            this.Init();
        }

        public Player(Point location) : base(location)
        {
            this.Init();
        }

        private void Init()
        {
            this.Mask.Circle(Radius);
        }

        public void OnGlobalMousePress(MouseButton button)
        {
            if (button == MouseButton.Left)
            {
                // TODO: Implememt "flaksing" when left mouse button is hit
                if (!(this.IsStarted))
                {
                    this.Velocity += InitialFlappingSpeed;
                    this.IsStarted = true;
                }
                else
                {
                    this.Velocity += FlappingSpeed;
                }
            }
        }

        public override void OnStep()
        {
            if (this.IsStarted)
                this.Velocity += GravitySpeed;

            base.OnStep();
        }

        public override void OnDraw()
        {
            Fill.Circle(Color.Red, this.Location, Radius);
			Mask.DrawOutline(Color.Black);
        }

        public override void OnDestroy()
        {
			Game.Sleep(500);
        }

        public void OnCollision(BadTree badTree)
        {
            this.Destroy();
        }
    }
}
