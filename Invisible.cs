using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	public class Invisible : Obstacle
	{
		public Invisible (double x, double y) : base (x, y, ObstacleType.Invisible)
		{
			_speedY = 2.5;
		}

		public override void Draw ()
		{
			SwinGame.DrawBitmap ("invisible.png", (float)X, (float)Y);
		}

		/*public void Change ()
		{
		    SwinGame.LoadTransparentBitmap ("player.png", Color.Transparent);
		}*/

		public ObstacleType getType {
			get { return ObstacleType.Invisible; }
		}
	}
}
