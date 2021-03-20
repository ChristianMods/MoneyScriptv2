using System;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;

public class MoneyScript : Script
{
	private string modName = "MoneyScript";
	private string modCreatorName = "ChristianMods";

	private Ped playerPed = Game.Player.Character;
	private Player player = Game.Player;


	ScriptSettings config;
	Keys Key;

	public MoneyScript()
	{
		UI.Notify("Loaded " + modName + " Made By: " + modCreatorName);

		Tick += OnTick;
		KeyDown += OnKeyDown;
		KeyUp += OnKeyUp;
		config = ScriptSettings.Load("scripts\\MoneyScript.ini");
		Key = config.GetValue<Keys>("Keys", "Key", Keys.J);
	}

	private void OnTick(object sender, EventArgs e)
	{

	}

	private void OnKeyDown(object sender, KeyEventArgs e)
	{

	}

	private void OnKeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Key)
		{
			Game.Player.Money += 500000;
		}
	}
}