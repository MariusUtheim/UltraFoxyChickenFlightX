using GameMaker;
using System;

namespace Project1
{
    static class Program
    {
        static int Main(string[] args)
        {
            var gameroom = new Room(1600, 800);
            Game.Run(gameroom, gameStart: GameStartup);

            return 0;
        }

        static void GameStartup()
        {
			GlobalEvent.ExitOnEscape = true;
			Sprites.LoadAll();
			Sounds.LoadAll();
            Background.Sprite = new Sprite(Properties.Resources.BackgroundFileName);
            Background.IsTiled = true;
			Window.Title = "ULTRA FOXY CHICKEN FLIGHT X";

			new MainMenu();
		}
    }
}
