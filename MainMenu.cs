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

		public MainMenu()
			: base(0, 0)
		{
			Spawner.Activate();
		}

		public void OnGlobalMousePress(MouseButton button)
		{
			Spawner.Deactivate();
		}
	}
}
