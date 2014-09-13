using GameMaker;
using System;

namespace Project1
{
    static class Program
    {
        static int Main(string[] args)
        {
            var gameroom = new Room(1024, 768);
            Game.Run(gameroom, gameStart: GameStartup);

            return 0;
        }

        static void GameStartup()
        {
            var henhouse = new Henhouse(5, Window.Height);
            henhouse.Y -= henhouse.Image.Height;
            var p = new Player(henhouse.Location.X + henhouse.Image.Width - Player.Radius, henhouse.Location.Y - Player.Radius);
            var bt = new BadTree(henhouse.Image.Width + 150, Window.Height);
			bt.Y = Window.Height - bt.Image.Height;
        }
    }
}
