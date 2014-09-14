﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace UltraFoxyChickenFlightX
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
		public static readonly Sprite FoxyHappy = new Sprite(Properties.Resources.FoxyHappyFileName, subimages: 2);
		public static readonly Sprite FoxyScared = new Sprite(Properties.Resources.FoxyScaredFileName, subimages: 2);
		public static readonly Sprite FoxyStand = new Sprite(Properties.Resources.FoxyStandingFileName, subimages: 1);
        

	}
}
