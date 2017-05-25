using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	public class Turbo : Obstacle
	{
		public Turbo (double x, double y) : base (x, y)
		{
			_speedY = 2.5;

		}

		public override void Draw ()
		{
			SwinGame.DrawBitmap ("turbo.png", (float)X, (float)Y);
		}


		public ObstacleType getType {
			get { return ObstacleType.Invisible; }
		}
	}
}
