using GameMaker;
using System;

namespace Project1
{
    public abstract class SceneryObject : MovingObject
    {
        public static readonly Vector MovementSpeed = new Vector(-5, 0);

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
    }
}
