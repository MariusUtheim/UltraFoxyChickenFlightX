using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace UltraFoxyChickenFlightX
{
	public class Particle
	{
		public Sprite Sprite;
		public Color Blend;
	//	public int LifeTime;
		public Transform Transform, Velocity;
	}

	public class Particles : GameObject
	{
		private Particle[] particles;
		private double a, da;

		public Particles(double x, double y, int count, int lifeTime)
			: base(x, y)
		{
			this.LifeTime = lifeTime;
			a = 1.0;
			da = 1.0 / lifeTime;
		}

		public int LifeTime { get; set; }

		public override void OnStep()
		{
			foreach (Particle p in particles)
			{
				p.Transform.Location += p.Velocity.Location;
				p.Blend.Transparent(a);
			}

			a -= da;
			if (--LifeTime <= 0)
				this.Destroy();
		}

		public override void OnDraw()
		{
			foreach (Particle p in particles)
			{
				Draw.Sprite(p.Transform, p.Blend, p.Sprite, 0);
			}
		}
	}
}
