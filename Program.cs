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
            var henhouse = new Henhouse(5, Window.Height - Henhouse.Size.Y);
            var p = new Player(henhouse.Location.X + Henhouse.Size.X - Player.Radius, henhouse.Location.Y - Player.Radius);
            var bt = new BadTree(Henhouse.Size.X + 150, Window.Height);
            bt.Y = Window.Height - bt.Image.Height;
        }
    }
}
