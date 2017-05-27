using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	public class Turbo : Obstacle
	{
		public Turbo (double x, double y) : base (x, y, ObstacleType.Lorry)
		{
			_speedX = 2.5;
		}

		public override void Draw ()
		{
			//SwinGame.DrawRectangle (Color.Transparent, (float)X, (float)Y, 80, 80);  
			SwinGame.DrawBitmap ("turbo.png", (float)X, (float)Y);
		}

		public ObstacleType getType {
			get { return ObstacleType.Turbo; }
		}
	}
}
