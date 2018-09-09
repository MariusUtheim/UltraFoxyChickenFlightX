using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRaff;

namespace UltraFoxyChickenFlightX
{
	public static class Sounds
	{
		public static void LoadAll()
		{
            HappyCloud = SoundBuffer.Load(Properties.Resources.HappyCloudSoundName);
            AngryCloud = SoundBuffer.Load(Properties.Resources.AngryCloudSoundName);
            GoodTree = SoundBuffer.Load(Properties.Resources.GoodTreeSoundName);
            BadTree = SoundBuffer.Load(Properties.Resources.BadTreeSoundName);
            MainMenu = SoundBuffer.Load(Properties.Resources.MainMenuSoundName);
            Background = SoundBuffer.Load(Properties.Resources.BackgroundMusicFileName);
            Henhouse = SoundBuffer.Load(Properties.Resources.HenhouseSoundFileName);
            BirdFlap = SoundBuffer.Load(Properties.Resources.BirdFlapFileName);
            Groundfall = SoundBuffer.Load(Properties.Resources.GroundfallFileName);
            FarmerJoe = SoundBuffer.Load(Properties.Resources.FarmerJoeSoundFileName);
		}

		public static SoundBuffer HappyCloud;
		public static SoundBuffer AngryCloud;
		public static SoundBuffer GoodTree;
		public static SoundBuffer BadTree;
		public static SoundBuffer MainMenu;
		public static SoundBuffer Background;
		public static SoundBuffer Henhouse;
		public static SoundBuffer BirdFlap;
		public static SoundBuffer Groundfall;
		public static SoundBuffer FarmerJoe;
	}
}
