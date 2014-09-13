using GameMaker;
using System;

namespace Project1
{
    public class Player : MovingObject, IGlobalMousePressListener, IKeyPressListener
    {
        private const int FlappingCost = 2;
        private const int StepScore = 1;
        private static readonly Vector GravitySpeed = new Vector(0, 0.25);
        private static readonly Vector InitialFlappingSpeed = new Vector(0, -6);
        private static readonly Vector FlappingSpeed = new Vector(0, -4);

        public Player(Point location)
            : base(location)
        {
			this.Velocity = InitialFlappingSpeed;
			Sprite = Sprites.FoxyHappy;
			Transform.Scale *= 0.1;
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

        public override void OnEndStep()
        {
            if ((this.Y + this.Image.Height) >= Window.Height)
            {
                this.Destroy();
            }
        }

        public override void OnStep()
        {
            this.Velocity += GravitySpeed;

            Statistics.Score += StepScore;

            base.OnStep();
        }

        public override void OnDestroy()
        {
            Game.Sleep(1200);
            Game.Quit();
        }
	}
}
