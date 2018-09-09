using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRaff;
using GRaff.Graphics;

namespace UltraFoxyChickenFlightX
{
	public static class Sprites
	{
		public static void LoadAll()
		{
			HappyCloud = Sprite.Load(Properties.Resources.HappyCloudFileName1);
            HappyCloudSuperHappy = Sprite.Load(Properties.Resources.HappyCloudFileName2);
            AngryCloud = Sprite.Load(Properties.Resources.AngryCloudFileName1);
            AngryCloudSuperAngry = Sprite.Load(Properties.Resources.AngryCloudFileName2);
            GoodTree = Sprite.Load(Properties.Resources.GoodTreeSpriteFileName, origin: new IntVector(400, 920));
            BadTree = Sprite.Load(Properties.Resources.BadTreeSpriteFileName, origin: new IntVector(430, 1100));
            FoxyHappy = new[] { Sprite.Load(Properties.Resources.FoxyHappy1FileName, origin: new IntVector(890, 1120)), Sprite.Load(Properties.Resources.FoxyHappy2FileName, origin: new IntVector(890, 1120)) };
            FoxyScared = new[] { Sprite.Load(Properties.Resources.FoxyScared1FileName, origin: new IntVector(890, 1120)), Sprite.Load(Properties.Resources.FoxyScared2FileName, origin: new IntVector(890, 1120)) };
            FoxyStand = Sprite.Load(Properties.Resources.FoxyStandingFileName);
            NewGame = Sprite.Load(Properties.Resources.MenuNewGameFileName, 1, null);
            NewGameHover = Sprite.Load(Properties.Resources.MainMenuNewGameHoverFileName, 1, null);
            Quit = Sprite.Load(Properties.Resources.MenuQuitFileName, 1, null);
            QuitHover = Sprite.Load(Properties.Resources.MainMenuQuitHoverFileName, 1, null);
            Logo = Sprite.Load(Properties.Resources.LogoFileName);
            Particle = Sprite.Load(Properties.Resources.ParticleSpriteFileName);
		}

		public static Sprite HappyCloud;
		public static Sprite HappyCloudSuperHappy;
		public static Sprite AngryCloud;
		public static Sprite AngryCloudSuperAngry;
		public static Sprite GoodTree;
		public static Sprite BadTree;
		public static Sprite[] FoxyHappy;
		public static Sprite[] FoxyScared;
		public static Sprite FoxyStand;
		public static Sprite NewGame;
		public static Sprite NewGameHover;
		public static Sprite Quit;
		public static Sprite QuitHover;
		public static Sprite Logo;
		public static Sprite Particle;
	}
}
