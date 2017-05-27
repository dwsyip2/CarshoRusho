using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class Bomb:Obstacle
	{
		public Bomb (double x, double y) : base (x,y,ObstacleType.Bomb)
		{
			_speedY = 2.5;

		}

		public override void Draw ()
		{
			SwinGame.DrawBitmap ("bomb.png", (float)X, (float)Y);
		}

		public ObstacleType getType {
			get { return ObstacleType.Bomb; }
		}
	}
}
