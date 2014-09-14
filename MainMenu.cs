using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace UltraFoxyChickenFlightX
{
	public class MainMenu : GameObject
	{
		bool isFadingOut = false;
		double tweenAmount;

        SoundInstance menuSoundInstance = Sounds.MainMenu.Play(true, .8);

		public MainMenu()
			: base(800, 350)
		{
#if true
			Sprite = Sprites.Logo;
			Spawner.Activate();
			Depth = -1;
			tweenAmount = 0.0;
			new MenuButton(800, 450, Sprites.NewGame, Sprites.NewGameHover, button => this.NewGame());
			new MenuButton(800, 600, Sprites.Quit, Sprites.QuitHover, button => Game.Quit());
#else
			new Player(new Point(350, 250));
			Spawner.Activate();
			this.Destroy();
			GUI.Init();
#endif
		}

		public override void OnStep()
		{
			if (isFadingOut)
			{
				tweenAmount += 0.01;
				Image.Alpha = (1 + Math.Cos(tweenAmount * GMath.Tau / 2)) / 2;
				Instance<MenuButton>.Do(inst => inst.Image.Alpha = this.Image.Alpha);
				Instance<SceneryObject>.Do(inst => inst.Image.Alpha = this.Image.Alpha);
				if (Image.Alpha <= 0)
				{
					Instance<MenuButton>.Do(inst => inst.Destroy());
					Instance<SceneryObject>.Do(inst => inst.Destroy());
					new PreGamePlayer();
					new Henhouse();
					this.Destroy();
				}
			}
		}

		public void NewGame()
		{
            Statistics.Energy = Statistics.StartEnergy;
            Statistics.Score = Statistics.StartingScore;
			Instance<MenuButton>.Do(inst => { inst.IsEnabled = false; });
			Spawner.Deactivate();
			isFadingOut = true;
		}

		public override void OnDraw()
		{
			Fill.Rectangle(new Color((int)(64 * Image.Alpha), 40, 40, 80), 0, 0, Room.Width, Room.Height);
			Fill.Rectangle(Color.Black, 0, 0, Room.Width, Room.Height / 10 * Image.Alpha);
			Fill.Rectangle(Color.Black, 0, Room.Height * (10 - Image.Alpha) / 10, Room.Width, Room.Height / 10 * Image.Alpha);
			base.OnDraw();
		}

        public override void OnDestroy()
        {
            menuSoundInstance.Stop();
            
            base.OnDestroy();
        }
	}
}
