using GRaff;
using System;

namespace UltraFoxyChickenFlightX
{
    static class Program
    {
        static int Main(string[] args)
        {
            Game.Run(1600, 800, gameStart);

            return 0;
        }

        static void gameStart()
        {
			GlobalEvent.ExitOnEscape = true;
			Sprites.LoadAll();
			Sounds.LoadAll();

			var background = Instance.Create(new Background { Texture = Texture.Load(Properties.Resources.BackgroundFileName) });
            background.IsTiled = true;

			Window.Title = "ULTRA FOXY CHICKEN FLIGHT X";

			Instance<MainMenu>.Create();
		}
    }
}
