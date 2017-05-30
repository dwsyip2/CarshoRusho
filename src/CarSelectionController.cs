using System;
using SwinGameSDK;
namespace MyGame
{
	public class CarSelectionController : Page
	{
		const int ButtonX = 50;
		const int ButtonY = 150;
		const int Spacing = 5;
		const int ButtonWidth = 200;
		const int ButtonHeight = 50;
		public static CarType CarVariety = CarType.SportCar;
		string [] menu = {
		"Sport Car",
		"Car"
		};


		public override void DrawPage ()
		{
			//SwinGame.DrawBitmap ("bg.jpg", 0, 0);
			SwinGame.DrawBitmap ("bg2.jpg", 0, 0);

			//UtilityFunction.gameStateStack.Push (GameState.ChangingCar);
			for (int i = 0; i < menu.Length; i++) {
				//SwinGame.DrawBitmap ("SportCar.png", ButtonX, ButtonY);
				//SwinGame.DrawBitmap ("player.png", ButtonX, ButtonY + 51);
				SwinGame.FillRectangle (Color.Transparent, ButtonX, ButtonY + (Spacing + ButtonHeight) * i, ButtonWidth, ButtonHeight);
				if (UtilityFunction.IsMouseInRectangle (ButtonX, ButtonY + (Spacing + ButtonHeight) * i, ButtonWidth, ButtonHeight, SwinGame.MousePosition ())) {
					if (SwinGame.MouseDown (MouseButton.LeftButton))
						SwinGame.FillRectangle (Color.LimeGreen, ButtonX, ButtonY + (Spacing + ButtonHeight) * i, ButtonWidth, ButtonHeight);
					else
						SwinGame.DrawRectangle (Color.Azure, ButtonX, ButtonY + (Spacing + ButtonHeight) * i, ButtonWidth, ButtonHeight);
				}
				SwinGame.DrawText (menu [i], Color.GhostWhite, ButtonX + 10 * Spacing, ButtonY + ButtonHeight / 2 + (Spacing + ButtonHeight) * i);
			}
		}

		public override void Execute ()
		{
			DrawPage ();
			HandleInput ();
		}

		void HandleSelectionButtonInput ()
		{
			for (int i = 0; i < menu.Length; i++) {
				if (SwinGame.MouseClicked (MouseButton.LeftButton)
				   && UtilityFunction.IsMouseInRectangle (ButtonX, ButtonY + (Spacing + ButtonHeight) * i,
														   ButtonWidth, ButtonHeight, SwinGame.MousePosition ())) {
					PerformSelectionAction (i);
					//PerformCarSelectionChanges (i);
				}
			}
		}

		void PerformSelectionAction (int button)
		{
			switch (button) {
			case 1:
				UtilityFunction.gameStateStack.Push (GameState.ViewingCarSelection);
				break;
			default:
				break;
			}
		}

		public override void HandleInput ()
		{
			if (SwinGame.MouseClicked (MouseButton.LeftButton)) {
				if (UtilityFunction.gameStateStack.Peek () == GameState.ViewingCarSelection)
					HandleSelectionButtonInput ();
				else if (UtilityFunction.gameStateStack.Peek () == GameState.ChangingCar)
					HandleCarButtonInput ();
			}
			if (SwinGame.KeyTyped (KeyCode.vk_ESCAPE))
				UtilityFunction.gameStateStack.Pop ();
		}

		void HandleCarButtonInput ()
		{
			int Level = 1;
			for (int i = 0; i < menu [0].Length; i++) {
				if (SwinGame.MouseClicked (MouseButton.LeftButton)
					&& UtilityFunction.IsMouseInRectangle (ButtonX + (Spacing + ButtonWidth) * (Level), ButtonY + (Spacing + ButtonHeight) * i,
														   ButtonWidth, ButtonHeight, SwinGame.MousePosition ())) {
					PerformCarSelectionChanges (i);
					break;
				}
			}
			while (UtilityFunction.gameStateStack.Peek () == GameState.ChangingCar)
				UtilityFunction.gameStateStack.Pop ();
		}

		void PerformCarSelectionChanges (int button)
		{
			switch (button) {
			case 0:
				SwinGame.DrawBitmap ("SportCar.png", 415, 570);
				break;
			case 1:
				SwinGame.DrawBitmap ("player.png", 415, 570);
				break;
			default:
				break;
			}
		}
	}
}

