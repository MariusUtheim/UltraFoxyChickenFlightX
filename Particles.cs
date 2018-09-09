using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRaff;
using GRaff.Graphics;

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
			a = 1.5;
			da = 1.5 / lifeTime;
			Depth = -1;
	
			particles = new Particle[count];
			for (int i = 0; i < count; i++)
			{
				particles[i] = new Particle {
					Sprite = Sprites.Particle,
					Blend = GRandom.Choose(Colors.ForestGreen, Colors.LimeGreen),
					Transform = new Transform { X = x, Y = y, Scale = new Vector(GRandom.Double(0.01, 0.05), Angle.Deg(45)), Rotation = GRandom.Angle() },
					Velocity = new Transform { Location = (Point)(GRandom.Vector() * GRandom.Double(1.0, 4.0)) }
				};
			}
		}

		public int LifeTime { get; set; }

		public override void OnStep()
		{
			foreach (Particle p in particles)
			{
				p.Transform.Location += p.Velocity.Location;
				p.Velocity.Y += 0.1;
				p.Blend = p.Blend.Transparent(a);
			}

			a -= da;
			if (--LifeTime <= 0)
				this.Destroy();
		}

		public override void OnDraw()
		{
			foreach (Particle p in particles)
			{
				Draw.Sprite(p.Sprite, 0, p.Transform, p.Blend);
			}
		}
	}
}
