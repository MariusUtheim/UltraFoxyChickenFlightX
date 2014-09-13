using GameMaker;
using System;

namespace Project1
{
#warning Inherit from GameObject?
    public class Henhouse : SceneryObject
    {
        public static readonly Sprite FileSprite = new Sprite(Properties.Resources.HenhouseFileName, origin: IntVector.Zero);

        public Henhouse(double x, double y) : base(x, y) 
        {
            this.Sprite = FileSprite;
            this.Transform.Scale *= .4;
        }

		public override void OnCollision(Player player)
		{
			return;
		}
    }
}
