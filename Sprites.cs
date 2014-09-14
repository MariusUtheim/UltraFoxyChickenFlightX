using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace Project1
{
	public static class Sprites
	{
		public static void LoadAll()
		{
			return; // Initializes the files through lazy loading.
		}

		public static readonly Sprite HappyCloud = new Sprite(Properties.Resources.HappyCloudFileName1);
		public static readonly Sprite HappyCloudSuperHappy = new Sprite(Properties.Resources.HappyCloudFileName2);
		public static readonly Sprite AngryCloud = new Sprite(Properties.Resources.AngryCloudFileName1);
		public static readonly Sprite AngryCloudSuperAngry = new Sprite(Properties.Resources.AngryCloudFileName2);
		public static readonly Sprite GoodTree = new Sprite(Properties.Resources.GoodTreeSpriteFileName, origin: new IntVector(400, 920));
		public static readonly Sprite BadTree = new Sprite(Properties.Resources.BadTreeSpriteFileName, origin: new IntVector(430, 1100));
		public static readonly Sprite[] FoxyHappy = new[] { new Sprite(Properties.Resources.FoxyHappy1FileName, origin: new IntVector(890, 1120)), new Sprite(Properties.Resources.FoxyHappy2FileName, origin: new IntVector(890, 1120)) };
		public static readonly Sprite[] FoxyScared = new[] { new Sprite(Properties.Resources.FoxyScared1FileName, origin: new IntVector(890, 1120)), new Sprite(Properties.Resources.FoxyScared2FileName, origin: new IntVector(890, 1120)) };
		public static readonly Sprite FoxyStand = new Sprite(Properties.Resources.FoxyStandingFileName, subimages: 1);
		public static readonly Sprite NewGame = new Sprite(Properties.Resources.MenuNewGameFileName, 1, null, true);
		public static readonly Sprite NewGameHover = new Sprite(Properties.Resources.MainMenuNewGameHoverFileName, 1, null, true);
		public static readonly Sprite Quit = new Sprite(Properties.Resources.MenuQuitFileName, 1, null, true);
		public static readonly Sprite QuitHover = new Sprite(Properties.Resources.MainMenuQuitHoverFileName, 1, null, true);
		public static readonly Sprite Logo = new Sprite(Properties.Resources.LogoFileName);
	}
}
