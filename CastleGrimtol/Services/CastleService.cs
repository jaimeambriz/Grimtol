using System;
using System.Runtime.CompilerServices;
using CastleGrimtolData.Providors;
using CastleGrimtol.Utils;

namespace CastleGrimtol.Services
{
	public class CastleService
	{
		private CastleProvider _cp = new CastleProvider();

		public bool InStartMenu { get; internal set; }

		public bool Playing { get; internal set; }

		public CastleService()
		{
			InStartMenu = true;
			Playing = false;
		}

		internal void Help()
		{
			Console.Clear();
			Console.WriteLine(" Here is how to play:");
			Console.WriteLine("Type: GO/MOVE North, East, South, or West to navigate.");
			Console.WriteLine("Type: TAKE/PICKUP 'Item Name' to take Item.");
			Console.WriteLine("Type: USE 'Item Name' to use Item.");
			Console.WriteLine("Type: LOOK to look for Items in room and Exits.");
			Console.WriteLine("Type: INVENTORY to display your Inventory");
			Console.WriteLine("Type: RESTART to Restart the game.");
			Console.WriteLine("Type: QUIT to quit the game.");
			Console.WriteLine("Type: HELP to bring up this menu.");
		}

		internal string GetPlayerName()
		{
			return _cp.GetPlayerName();
		}

		internal void StartNewGame(string playerName)
		{
			if (playerName is string && playerName != null)
			{
				_cp.StartNewGame(playerName);
			}
		}
		internal object GetRoom()
		{
			return _cp.GetRoom();
		}
		internal void StartGame()
		{
			Commands commands = new Commands();

			while (Playing)
			{
				Console.Clear();
				//_cp.Look();
				var actions = commands.UserInput();
				switch (actions[0])
				{
					case "move":
						Go(actions[1]);
						break;
					case "go":

						Go(actions[1]);
						break;
					case "take":
						//Take(actions[1]);
						actions = null;
						Console.ReadKey();
						break;
					case "pickup":
						//Take(actions[1]);
						actions = null;
						Console.ReadKey();
						break;
					case "use":
						//UseItem(actions[1]);
						actions = null;
						Console.ReadKey();
						break;
					case "l":
					case "look":
						_cp.Look();
						Console.ReadKey();
						break;
					case "i":
					case "inventory":
						//Inventory();
						actions = null;
						Console.ReadKey();
						break;
					case "h":
					case "help":
						Help();
						Console.ReadKey();
						break;
					case "quit":
						System.Console.WriteLine("\nThe evil Lord has won this time!");
						Console.ReadKey();
						System.Environment.Exit(0);
						break;
					case "restart":
						System.Console.WriteLine("\nAre you sure you want to restart? (Y/N)");
						string input = Console.ReadLine().ToLower();
						if (input == "y")
						{
							//Reset();
						}
						else
						{
							continue;
						}
						break;
					default:
						System.Console.WriteLine("What?");
						break;
				}
			}

		}
		public void Go(string direction)
		{
			var room = _cp.Go(direction);

			if (room != null)
			{
				Console.WriteLine(room.Description);
				Console.ReadKey();
				if (room.Name == "Throne Room")
				{
					//for (int i = 0; i < CurrentPlayer.Inventory.Count; i++)
					//{
					//	Item inventoryItem = CurrentPlayer.Inventory[i];
					//	if (inventoryItem.Name == "key")
					//	{
					//		CurrentRoom = CurrentRoom.Exits[direction];
					//		Console.Clear();
					//		CurrentLocation();
					//		Events();
					//		return;
					//	}
					//}

					System.Console.WriteLine("\nCrap! This room is locked.");
					Console.ReadLine();
					return;

				}

				Console.WriteLine($"You have enterd the {room.Name}, {room.Description}");
				//Events();
			}
			else
			{
				Console.WriteLine("Can't go that way...");
				Console.ReadKey();
			}
		}
	}
}

