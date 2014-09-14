using GameMaker;
using System;

namespace UltraFoxyChickenFlightX
{
    public abstract class SceneryObject : MovingObject, ICollisionListener<Player>
    {
        public static readonly Vector MovementSpeed = new Vector(-5, 0);
        private bool collision = false;

        public bool HasCollided
        {
            get { return this.collision; }
            set { this.collision = value; }
        }

        public SceneryObject(double x, double y) : base(x, y) 
        {
			this.Velocity = MovementSpeed;
        }

        public override void OnEndStep()
        {
            if ((this.X + this.Image.Width) < 0)
            {
                this.Destroy();
            }
        }

		public abstract void OnCollision(Player player);
    }
}
