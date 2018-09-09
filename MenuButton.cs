using System;
using GRaff;
using GRaff.Graphics;

namespace UltraFoxyChickenFlightX
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
			Model.Speed = 0;
			IsEnabled = true;
			Depth = -2;
		}

		public bool IsEnabled { get; set; }
		
		public override void OnStep()
		{
			if (BoundingBox.Contains(Mouse.Location))
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
