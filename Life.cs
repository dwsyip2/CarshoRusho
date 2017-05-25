using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	public class Life : Obstacle
	{
		public Life (double x, double y) : base (x, y)
		{
			_speedY = 2.5;
			_lifeCount = 2;
		}

		public override void Draw ()
		{
			//SwinGame.DrawRectangle (Color.Transparent, (float)X, (float)Y, 80, 80);  
			SwinGame.DrawBitmap ("life.png", (float)X, (float)Y);
		}

		public ObstacleType getType {
			get { return ObstacleType.Life; }
		}
	}
}
