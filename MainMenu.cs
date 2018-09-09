using System;
using GRaff;
using GRaff.Audio;

namespace UltraFoxyChickenFlightX
{
	public class MainMenu : GameObject
	{
		bool isFadingOut = false;
		double tweenAmount;

        SoundElement menuSoundInstance = Sounds.MainMenu.Play(true, .8);

		public MainMenu()
			: base(800, 350)
		{
			Sprite = Sprites.Logo;
			Spawner.Activate();
			Depth = -1;
			tweenAmount = 0.0;
			Instance.Create(new MenuButton(800, 450, Sprites.NewGame, Sprites.NewGameHover, button => this.NewGame()));
			Instance.Create(new MenuButton(800, 600, Sprites.Quit, Sprites.QuitHover, button => Game.Quit()));
		}

		public override void OnStep()
		{
			if (isFadingOut)
			{
				tweenAmount += 0.01;
				Model.Alpha = (1 + Math.Cos(tweenAmount * GMath.Tau / 2)) / 2;
				Instance<MenuButton>.Do(inst => inst.Model.Alpha = this.Model.Alpha);
				Instance<SceneryObject>.Do(inst => inst.Model.Alpha = this.Model.Alpha);
				if (Model.Alpha <= 0)
				{
					Instance<MenuButton>.Do(inst => inst.Destroy());
					Instance<SceneryObject>.Do(inst => inst.Destroy());
					Instance<PreGamePlayer>.Create();
					Instance<Henhouse>.Create();
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
			Draw.FillRectangle(new Rectangle(0, 0, Window.Width, Window.Height), Color.FromRgba(80, 40, 40, (int)(64 * Model.Alpha)));
			Draw.FillRectangle(new Rectangle(0, 0, Window.Width, Window.Height / 10 * Model.Alpha), Colors.Black);
			Draw.FillRectangle(new Rectangle(0, Window.Height * (10 - Model.Alpha) / 10, Window.Width, Window.Height / 10 * Model.Alpha), Colors.Black);
			base.OnDraw();
		}

        protected override void OnDestroy()
        {
            menuSoundInstance.Destroy();
            
            base.OnDestroy();
        }
	}
}
