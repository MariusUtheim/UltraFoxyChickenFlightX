using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace Project1
{
	public class MainMenu : GameObject, IGlobalMousePressListener
	{
		bool isFadingOut = false;

		public MainMenu()
			: base(0, 0)
		{
#if false
			Spawner.Activate();
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
				Image.Alpha -= 0.01;
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
	}
}
