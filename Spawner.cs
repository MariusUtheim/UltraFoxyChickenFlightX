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
			isActive = true;
			spawnAlarm = Alarm.Start(60, spawnObject);
			spawnAlarm.IsLooping = true;
		}

		static void spawnObject(Alarm alarm)
		{
			new BadTree(Room.Width + 50, 550);
		}
	}
}
