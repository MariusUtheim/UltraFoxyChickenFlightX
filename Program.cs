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
            var p = new Player(250, 400);
            
        }
    }
}
