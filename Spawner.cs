﻿using GameMaker;
using System;
using System.Linq;

namespace UltraFoxyChickenFlightX
{
	static class Spawner
	{
		private static bool isActive = false;
		private static Alarm spawnAlarm;
        private static Type lastSpawnType = typeof(BadTree);

        private static readonly Type[] spawnTypes = new Type[]
        {
            typeof(GoodTree), typeof(BadTree), typeof(AngryCloud), typeof(HappyCloud)
        };

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
			isActive = false;
			GlobalEvent.Step -= moveBackground;
			spawnAlarm.Stop();
		}

		private static void spawnObject(Alarm alarm)
		{
            var currentSpawnType = GRandom.Choose(spawnTypes.Except(new Type[] { lastSpawnType }).ToArray());
            Activator.CreateInstance(currentSpawnType);
            lastSpawnType = currentSpawnType;
		}

		private static void moveBackground()
		{
			Background.Offset += SceneryObject.MovementSpeed / 4;
		}

	}
}
