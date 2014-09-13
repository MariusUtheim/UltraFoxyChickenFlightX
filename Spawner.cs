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
			GlobalEvent.Step += moveBackground;
		}

		public static void Deactivate()
		{
			if (!isActive)
				return;
			GlobalEvent.Step -= moveBackground;
			spawnAlarm.Stop();
		}

		private static void spawnObject(Alarm alarm)
		{
			Activator.CreateInstance(GRandom.Choose(typeof(BadTree), typeof(GoodTree), typeof(AngryCloud), typeof(HappyCloud)));
		}

		private static void moveBackground()
		{
			Background.Offset += SceneryObject.MovementSpeed / 4;
		}

	}
}
