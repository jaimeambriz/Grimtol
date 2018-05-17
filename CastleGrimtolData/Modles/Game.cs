using System;
using CastleGrimtolData.Interfaces;
using System.Data;
namespace CastleGrimtolData.Modles
{
	internal class Game : IGame
	{
		public Room CurrentRoom { get; set; }

		public Player CurrentPlayer { get; set; }

		public bool Playing = false;


		public Game()
		{
			CurrentPlayer = null;
			Playing = true;
		}

		internal void UpdateRoom(Room room)
		{
			CurrentRoom = room;
		}

		internal void SetPlayer(string playerName)
		{
			CurrentPlayer = new Player(playerName);

		}
	}
}
