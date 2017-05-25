using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	public class Score : Obstacle
	{
		public Score (double x, double y) : base (x, y)
		{
			_speedY = 2.5;
		}

		public override void Draw ()
		{
			SwinGame.DrawBitmap ("score.png", (float)X, (float)Y);
		}

		public ObstacleType getType {
			get { return ObstacleType.Invisible; }
		}
	}
}
