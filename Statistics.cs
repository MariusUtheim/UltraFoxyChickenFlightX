using GameMaker;
using System;

namespace Project1
{
    public static class Statistics
    {
        private static int score;
        private static int energy;

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
                energy = value;
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
