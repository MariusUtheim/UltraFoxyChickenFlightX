using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace UltraFoxyChickenFlightX
{
	public class MainMenu : GameObject, IGlobalMousePressListener
	{
		bool isFadingOut = false;
		double tweenAmount;

        SoundInstance menuSoundInstance = Sounds.MainMenu.Play(true, .8);

		public MainMenu()
			: base(0, 0)
		{
#if true
			Spawner.Activate();
			Depth = -1;
			tweenAmount = 0.0;
#else
			new Player(new Point(350, 250));
			Spawner.Activate();
			this.Destroy();
			GUI.Init();
#endif
		}

		public override void OnStep()
		{
			if (isFadingOut)
			{
				tweenAmount += 0.01;
				Image.Alpha = (1 + Math.Cos(tweenAmount * GMath.Tau / 2)) / 2;
				Instance<SceneryObject>.Do(inst => inst.Image.Alpha = this.Image.Alpha);
				if (Image.Alpha <= 0)
				{
					new PreGamePlayer();
					new Henhouse();
					this.Destroy();
				}
			}
		}

		public void OnGlobalMousePress(MouseButton button)
		{
			Spawner.Deactivate();
			isFadingOut = true;
		}

		public override void OnDraw()
		{
			Fill.Rectangle(new Color((int)(64 * Image.Alpha), 40, 40, 80), 0, 0, Room.Width, Room.Height);
			Fill.Rectangle(Color.Black, 0, 0, Room.Width, Room.Height / 10 * Image.Alpha);
			Fill.Rectangle(Color.Black, 0, Room.Height * (10 - Image.Alpha) / 10, Room.Width, Room.Height / 10 * Image.Alpha);
		}

        public override void OnDestroy()
        {
            menuSoundInstance.Stop();
            
            base.OnDestroy();
        }
	}
}
