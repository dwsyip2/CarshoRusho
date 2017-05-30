using System;
using SwinGameSDK;
namespace MyGame
{
	public class InstructionController:Page
	{
		//public InstructionController ()
		//{
		//}

		public override void DrawPage ()
		{
			//SwinGame.DrawBitmap ("bg.jpg", 0, 0);
			//GameResources.GameFont ("New").FontStyle = FontStyle.BoldFont | FontStyle.UnderlineFont;
			SwinGame.DrawBitmap ("bg2.jpg", 0, 0);
			SwinGame.DrawText ("How To Play: CarSho Rusho", Color.White, 10, 70);
			SwinGame.DrawText ("Direction", Color.White, 10, 100);
			SwinGame.DrawText ("1.Right arrow to drive right side", Color.White, 10, 110);
			SwinGame.DrawText ("2.Up arrow to drive forward", Color.White, 10, 120);
			SwinGame.DrawText ("3.Left arrow to drive left side", Color.White, 10, 130);
			SwinGame.DrawText ("4.Down arrow to drive downwards", Color.White, 10, 140);
			SwinGame.DrawText ("Setting:", Color.White, 10, 160);
			SwinGame.DrawText ("Choose Difficulty, Maximum Obstacles, BGM", Color.White, 10, 170);
			SwinGame.DrawText ("Objective:", Color.White, 10, 190);
			SwinGame.DrawText ("1. Avoid knocking from the obstacles", Color.White, 10, 200);
			SwinGame.DrawText ("2. Collect more coints", Color.White, 10, 210);
			SwinGame.DrawText ("Score:", Color.White, 10, 230);
			SwinGame.DrawText ("1 Point will be given whenever the 1 obstacle passes throught the car", Color.White, 10, 240);
			SwinGame.DrawText ("Power-up", Color.White, 10, 260);
			SwinGame.DrawText ("1.", Color.White, 10, 285);
			SwinGame.DrawBitmap ("fuel.png", 5, 230);
			SwinGame.DrawText ("Increase life by 1", Color.White, 70, 285);
			SwinGame.DrawText ("2.", Color.White, 10, 330);
			SwinGame.DrawBitmap ("turbo.png", 5, 300);
			SwinGame.DrawText ("Increase speed", Color.White, 70, 330);
			SwinGame.DrawText ("3.", Color.White, 10, 380);
			SwinGame.DrawBitmap ("Bomb.png", 5, 350);
			SwinGame.DrawText ("Explosion", Color.White, 70, 380);
			SwinGame.DrawText ("4.", Color.White, 10, 420);
			SwinGame.DrawBitmap ("score.png", 8, 390);
			SwinGame.DrawText ("Increase score", Color.White, 80, 420);
			SwinGame.DrawText ("5.", Color.White, 10, 470);
			SwinGame.DrawBitmap ("life.png", 7, 435);
			SwinGame.DrawText ("Increase life by 2", Color.White, 80, 470);

		}

		public override void Execute ()
		{
			DrawPage ();
			HandleInput ();
		}

		public override void HandleInput ()
		{
			if (SwinGame.KeyTyped (KeyCode.vk_ESCAPE))
				UtilityFunction.gameStateStack.Pop ();
		}
	}
}
