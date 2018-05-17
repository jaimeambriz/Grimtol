using CastleGrimtolData.HelperModels;
using System;
using System.Collections.Generic;
using CastleGrimtolData.Modles;

namespace CastleGrimtolData.Providors
{
	public class CastleProvider
	{

		private CastleDb _db;


		public CastleProvider()
		{
			_db = new CastleDb();
		}

		public string StartNewGame(string playerName)
		{
			_db.Game.SetPlayer(playerName);
			Console.WriteLine("this looks like its working;");
			return "Your adventure awaits!";
		}


		public string Look()
		{
			return _db.Game.CurrentRoom.Look();
		}

		public ReturnRoom GetRoom()
		{
			var r = _db.Game.CurrentRoom;
			ReturnRoom room = new ReturnRoom(r.Name, r.Description);
			return room;
		}
		// THIS IS WERE WE TELL THE GAME WHAT WE WANT TO DO OR PLAYER INPUT
		public ReturnRoom Go(string direction)
		{
			var currRoom = _db.Game.CurrentRoom.Go(direction.ToUpper());
			if (currRoom != null)
			{

				_db.Game.UpdateRoom(currRoom);
				var room = _db.Rooms[currRoom.Name];
				return new ReturnRoom(room.Name, room.Description);
			}
			else
			{
				return null;
			}


		}

		public string GetPlayerName()
		{
			return _db.Game.CurrentPlayer.Name;
		}
	}
}




//NEED TO LOOK OVER THIS PAGE NOT SURE WHATS GOING ON
