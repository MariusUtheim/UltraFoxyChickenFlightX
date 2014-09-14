using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMaker;

namespace Project1
{
	class MenuButton : GameObject, IMousePressListener
	{
		private Action<MouseButton> onClick;

		Sprite baseSprite, hoverSprite;

		public MenuButton(double x, double y, Sprite sprite, Sprite hoverSprite, Action<MouseButton> onClick)
			: base(x, y)
		{
			this.Sprite = baseSprite = sprite;
			this.hoverSprite = hoverSprite;
			this.onClick = onClick;
			Image.Speed = 0;
			IsEnabled = true;
			Depth = -2;
		}

		public bool IsEnabled { get; set; }
		
		public override void OnStep()
		{
			if (BoundingBox.ContainsPoint(Mouse.Location))
				Sprite = hoverSprite;
			else
				Sprite = baseSprite;
		}

		public void OnMousePress(MouseButton button)
		{
			if (IsEnabled)
				onClick(button);
		}
	}
}
