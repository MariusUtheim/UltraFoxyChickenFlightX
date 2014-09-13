using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace Project1
{
	public static class Sounds
	{
		public static void LoadAll()
		{
			return; // Initializes the files through lazy loading.
		}

		public static Sound HappyCloud = new Sound(Properties.Resources.HappyCloudSoundName, true);

	}
}
