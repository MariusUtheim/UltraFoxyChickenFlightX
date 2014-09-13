using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace Project1
{
	static class Spawner
	{
		private static bool isActive = false;
		private static Alarm spawnAlarm;

		public static void Activate()
		{
			if (isActive)
				return;

			isActive = true;

			spawnAlarm = Alarm.Start(60, spawnObject);
			spawnAlarm.IsLooping = true;
		}

		private static void Deactivate()
		{
			if (!isActive)
				return;

			spawnAlarm.Stop();
		}

		static void spawnObject(Alarm alarm)
		{
			Activator.CreateInstance(GRandom.Choose(typeof(BadTree), typeof(GoodTree), typeof(AngryCloud), typeof(HappyCloud)));
		}
	}
}
