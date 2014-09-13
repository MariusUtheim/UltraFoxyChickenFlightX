using GameMaker;
using System;

namespace Project1
{
    static class Program
    {
        static int Main(string[] args)
        {
            Statistics.EnergyChanged += OnStatisticsChanged;
            Statistics.ScoreChanged += OnStatisticsChanged;

            var gameroom = new Room(1600, 800);
            Game.Run(gameroom, gameStart: GameStartup);

            return 0;
        }

        private static void OnStatisticsChanged(int ignoreValue)
        {
            Window.Title = string.Format("{0} - Energy: {1:N0} - Score: {2:N0}",
                "ULTRA FOXY CHICKEN FLIGHT X",
                Statistics.Energy, Statistics.Score);
        }

        static void GameStartup()
        {
			GlobalEvent.ExitOnEscape = true;
			Sprites.LoadAll();
			Sounds.LoadAll();
            Background.Sprite = new Sprite(Properties.Resources.BackgroundFileName);
            Background.IsTiled = true;

			new MainMenu();
		}
    }
}
