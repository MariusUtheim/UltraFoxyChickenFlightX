using GRaff;
using GRaff.Graphics;

namespace UltraFoxyChickenFlightX
{
	public static class GUI
	{
		private static readonly Sprite NumbersSprite = Sprite.Load(Properties.Resources.NumbersSpriteFileName, 10, new IntVector(0, 0));

		public static void Init()
		{
			GlobalEvent.DrawForeground += DrawGUI;
		}

		public static void DrawGUI()
		{
			Rectangle fullHealthRegion = new Rectangle(20, 20, 128, 20);
			Rectangle currentHealthRegion = new Rectangle(20, 20, Statistics.Energy, 20);
			Draw.FillRectangle(currentHealthRegion, Colors.Red, Colors.Yellow, Colors.Yellow, Colors.Red);
			Draw.Rectangle(fullHealthRegion, Colors.Black);

			DrawString(20, 50, Statistics.Score.ToString());
		}

		public static void DrawString(double x, double y, string str)
		{
			/*
			GL.Enable(EnableCap.Texture2D);
            
			GL.BindTexture(TextureTarget.Texture2D, NumbersSprite.SubImage(0).Id);

			double dx = NumbersSprite.Width;
			double du = 0.1;
			double[] uCoords = str.Select(c => (double)(c - '0') * du).ToArray();

			GL.Begin(PrimitiveType.Quads);
			GL.Color4(1.0, 1.0, 1.0, 1.0);
			for (int i = 0; i < str.Length; i++)
			{
				GL.TexCoord2(uCoords[i], 0);
				GL.Vertex2(x + i * dx, y);
				GL.TexCoord2(uCoords[i] + du, 0);
				GL.Vertex2(x + (i + 1) * dx, y);
				GL.TexCoord2(uCoords[i] + du, 1);
				GL.Vertex2(x + (i + 1) * dx, y + NumbersSprite.Height);
				GL.TexCoord2(uCoords[i], 1);
				GL.Vertex2(x + i * dx, y + NumbersSprite.Height);
			}

			GL.End();
			GL.Disable(EnableCap.Texture2D);
			*/
		}
	}
}
