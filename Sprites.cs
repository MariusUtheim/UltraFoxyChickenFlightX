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

		public static readonly Sprite HappyCloud = new Sprite(Properties.Resources.HappyCloudFileName1, origin: IntVector.Zero);
		public static readonly Sprite HappyCloudSuperHappy = new Sprite(Properties.Resources.HappyCloudFileName2, origin: IntVector.Zero);
		public static readonly Sprite AngryCloud = new Sprite(Properties.Resources.AngryCloudFileName1, origin: IntVector.Zero);
		public static readonly Sprite AngryCloudSuperAngry = new Sprite(Properties.Resources.AngryCloudFileName2, origin: IntVector.Zero);
		public static readonly Sprite GoodTree = new Sprite(Properties.Resources.GoodTreeSpriteFileName, origin: IntVector.Zero);
		public static readonly Sprite BadTree = new Sprite(Properties.Resources.BadTreeSpriteFileName, origin: IntVector.Zero);
		public static readonly Sprite FoxyHappy = new Sprite(Properties.Resources.FoxyHappyFileName, subimages: 2, origin: IntVector.Zero);
		public static readonly Sprite FoxyScared = new Sprite(Properties.Resources.FoxyScaredFileName, subimages: 2, origin: IntVector.Zero);
        

	}
}
