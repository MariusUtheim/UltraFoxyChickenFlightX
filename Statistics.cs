using GameMaker;
using System;

namespace UltraFoxyChickenFlightX
{
    public static class Statistics
    {
        private static int score = 0;
        private static int energy = 128;

        public static int Score
        {
            get { return score; }
            set
            {
                int oldScore = score;
                score = value;
                if (value != oldScore && ScoreChanged != null)
                {
                    ScoreChanged(value);
                }
            }
        }

        public static int Energy
        {
            get { return energy; }
            set
            {
                int oldEngery = energy;
                energy = GMath.Median(0, value, 128);
                if (value != oldEngery && EnergyChanged != null)
                {
                    EnergyChanged(value);
                }
            }
        }

        public static event Action<int> ScoreChanged;
        public static event Action<int> EnergyChanged;
    }
}
