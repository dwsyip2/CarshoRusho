using SwinGameSDK;
using NUnit.Framework;
namespace MyGame
{
	[TestFixture ()]
	public class TestAll
	{
		[Test ()]
		public void TestDefaultInitialization ()
		{
			GameBoard myDrawing = new GameBoard ();
			Assert.AreEqual (Color.DimGray, myDrawing.BackgroundColor);
		}

		[Test ()]
		public void TestInitializeWithColor ()
		{
			GameBoard myDrawing = new GameBoard (Color.Blue);
			Assert.AreEqual (Color.Blue, myDrawing.BackgroundColor);
		}

		[Test ()]
		public void TestSpawnVehicle ()
		{
			GameBoard gb = new GameBoard ();
			PlayerVehicle p = new PlayerVehicle (415, 570);
			ScoreBoard.Initialize (0, 3, 1, "Peak Hours");
			Car c = new Car (415, 20);
			Lorry l = new Lorry (415, 20);
			Motorcycle m = new Motorcycle (415, 20);
			Fuel f = new Fuel (415, 20);
			Life lf = new Life (415, 20);
			Invisible i = new Invisible (415, 20);
			Score s = new Score (415, 20);
			Bomb b = new Bomb (415, 20);
			Turbo t = new Turbo (415, 20);

			gb.RandomSpawnVehicle (c);
			Assert.AreEqual (UtilityFunction.InitialY, c.Y);
		}

		[Test ()]
		public void TestDrop ()
		{
			Car car = new Car (GameController.startLane1X, GameController.startLaneY);
			PlayerVehicle p = new PlayerVehicle (GameController.startLane2X, 20);
			car.Drop (p);
			car.SpeedY = 100;
			SwinGame.Delay (10);
			car.Drop (p);
			Assert.AreNotEqual (GameController.startLaneY - 1, car.Y);
		}

		[Test ()]
		public void TestNagivate ()
		{
			GameBoard gb = new GameBoard ();
			PlayerVehicle p = new PlayerVehicle (415, 570);
			ScoreBoard.Initialize (0, 0, 1, "Peak Hours");
			Car c = new Car (415, 20);
			Lorry l = new Lorry (415, 20);
			Motorcycle m = new Motorcycle (415, 20);
			Fuel f = new Fuel (415, 20);
			Life lf = new Life (415, 20);
			Invisible i = new Invisible (415, 20);
			Score s = new Score (415, 20);
			Bomb b = new Bomb (415, 20);
			Turbo t = new Turbo (415, 20);

			//right
			p.SpeedX = 10000;
			p.SpeedY = 10000;
			SwinGame.Delay (20);
			p.UpdateTime ();
			p.NavigateRight ();
			Assert.AreEqual (GameController.startLane3X + 20, p.X);
			////middle
			//p.NavigateLeft ();
			//Assert.AreEqual (GameController.startLane2X, p.X);
			////left
			//p.NavigateLeft ();
			//Assert.AreEqual (GameController.startLane1X, p.X);

		}

		[Test ()]
		public void Testspeed ()
		{
			//Ensure that speed must be manually changed
			Car c = new Car (415, 20);
			UtilityFunction.currentDifficulty = GameDifficulty.Easy;
			c.SpeedY = 0;
			c.Acceleration = 1000;
			Assert.AreEqual (0, c.SpeedY);
			SwinGame.Delay (1);
			PlayerVehicle p = new PlayerVehicle (415, 570);
			c.Drop (p);
			Assert.IsTrue (c.SpeedY > 1);
		}

		[Test ()]
		public void TestgameOver ()
		{
			GameBoard gb = new GameBoard ();
			PlayerVehicle p = new PlayerVehicle (415, 570);
			ScoreBoard.Initialize (0, 0, 1, "Peak Hours");
			Car c = new Car (415, 20);
			Lorry l = new Lorry (415, 20);
			Motorcycle m = new Motorcycle (415, 20);
			Fuel f = new Fuel (415, 20);
			Life lf = new Life (415, 20);
			Invisible i = new Invisible (415, 20);
			Score s = new Score (415, 20);
			Bomb b = new Bomb (415, 20);
			Turbo t = new Turbo (415, 20);

			if (gb.GameOver () == true) {
				ScoreBoard.Life = 3;
				ScoreBoard.Score = 1;
			}
			Assert.AreEqual (3, ScoreBoard.Life);
		}

		[Test ()]
		public void TestBonusStageObstacle ()
		{
			GameController myGame = new GameController ();
			ScoreBoard.Initialize (0, 0, 5, "Peak Hours");
			myGame.AddObstacle ();
			Assert.AreEqual (ObstacleType.Score, myGame.CurrentBoard.Obstacles [0].GetObstacleType);
		}

	}
}

