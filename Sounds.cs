using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace UltraFoxyChickenFlightX
{
	public static class Sounds
	{
		public static void LoadAll()
		{
			return; // Initializes the files through lazy loading.
		}

		public static Sound HappyCloud = new Sound(Properties.Resources.HappyCloudSoundName, true);
        public static Sound AngryCloud = new Sound(Properties.Resources.AngryCloudSoundName, true);
        public static Sound GoodTree = new Sound(Properties.Resources.GoodTreeSoundName, true);
        public static Sound BadTree = new Sound(Properties.Resources.BadTreeSoundName, true);
        public static Sound MainMenu = new Sound(Properties.Resources.MainMenuSoundName, true);
        public static Sound Background = new Sound(Properties.Resources.BackgroundMusicFileName, true);
        public static Sound Henhouse = new Sound(Properties.Resources.HenhouseSoundFileName, true);
        public static Sound BirdFlap = new Sound(Properties.Resources.BirdFlapFileName, true);
        public static Sound Groundfall = new Sound(Properties.Resources.GroundfallFileName, true);
        public static Sound FarmerJoe = new Sound(Properties.Resources.FarmerJoeSoundFileName, true);
	}
}
