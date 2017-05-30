using System.Collections.Generic;
using SwinGameSDK;

public static class GameResources
{
	static Dictionary<string, Font> _Fonts = new Dictionary<string, Font> ();

	static void NewFont (string fontName, string filename, int size)
	{
		_Fonts.Add (fontName, SwinGame.LoadFont (SwinGame.PathToResource (filename, ResourceKind.FontResource), size));
	}

	private static Dictionary<string, Music> _Music = new Dictionary<string, Music> ();

	static void LoadFonts ()
	{
		NewFont ("ArialLarge", "arial.ttf", 80);
		NewFont ("Courier", "cour.ttf", 14);
		NewFont ("CourierSmall", "cour.ttf", 8);
		NewFont ("Menu", "ffaccess.ttf", 8);
		NewFont ("New", "maven_pro_regular.ttf", 16);
	}

	public static void LoadResources ()
	{
		LoadFonts ();
	}

	public static Font GameFont (string font)
	{
		return _Fonts [font];
	}

	private static void NewMusic (string NameMusic, string filename)
	{
		_Music.Add (NameMusic, Audio.LoadMusic (SwinGame.PathToResource (filename, ResourceKind.SoundResource)));
	}

	public static Music GameMusic (string music)
	{
		return _Music [music];
	}

	private static void FreeMusic ()
	{
		foreach (Music obj in _Music.Values) {
			Audio.FreeMusic (obj);
		}
	}

	public static void FreeResources ()
	{
		FreeMusic ();
		SwinGame.ProcessEvents ();
	}

}