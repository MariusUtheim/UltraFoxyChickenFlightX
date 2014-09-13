using GameMaker;
using System;

namespace Project1
{
    public class PreGamePlayer : GameObject
    {
        public Henhouse Henhouse { get; set; }

        public PreGamePlayer(Henhouse henhouse)
            : base(150, 250)
        {
            this.Henhouse = henhouse;
        }

        public override void OnStep()
        {
            if ((this.Henhouse.X + this.Henhouse.Image.Width) < this.X)
            {
                this.Destroy();
            }

            base.OnStep();
        }

        public override void OnDestroy()
        {
            new Player(this.Location);
        }
    }
}
