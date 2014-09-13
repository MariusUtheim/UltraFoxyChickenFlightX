using GameMaker;
using System;

namespace Project1
{
    public class Player : MovingObject, IGlobalMousePressListener, ICollisionListener<BadTree>, ICollisionListener<AngryCloud>, ICollisionListener<HappyCloud>, ICollisionListener<GoodTree>
    {
        public const int Radius = 15;
        private const int FlappingCost = 1;
        private const int StepScore = 1;
        private static readonly Vector GravitySpeed = new Vector(0, 0.25);
        private static readonly Vector InitialFlappingSpeed = new Vector(0, -6);
        private static readonly Vector FlappingSpeed = new Vector(0, -3);

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

            Statistics.EnergyChanged += OnEnergyChanged;
        }

        private void OnEnergyChanged(int value)
        {
            if (value <= 0)
            {
                this.Destroy();
            }
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

                Statistics.Energy -= FlappingCost;
            }
        }

        public override void OnStep()
        {
            if (this.IsStarted)
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

        public void OnCollision(BadTree badTree)
        {
            this.Destroy();
        }

        public void OnCollision(AngryCloud angryCloud)
        {
            Statistics.Score -= AngryCloud.ScorePenalty;
        }

        public void OnCollision(HappyCloud happyCloud)
        {
            Statistics.Score += HappyCloud.ScoreAward;
        }

        public void OnCollision(GoodTree other)
        {
            throw new NotImplementedException();
        }
    }
}
