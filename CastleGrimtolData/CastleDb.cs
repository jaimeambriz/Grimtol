using System;
using System.Collections.Generic;
using CastleGrimtolData.Modles;

namespace CastleGrimtolData
{
	internal class CastleDb
	{
		private new Game game = new Game();

		public Dictionary<string, Room> Rooms = new Dictionary<string, Room>();

		internal Game Game { get => game; set => game = value; }

		public CastleDb()
		{
			//THIS IS WHERE ALL MY DATA IS GONNA GO.

			// ROOMS 
			Room barracks = new Room("Barrack's", "You see a room with several sleeping guards, The room smells of sweaty men. The bed closest to you is empty and there are several uniforms tossed about.");
			Room captainsQuarters = new Room("Captain's Quarters", "As you approach the captains Quarters you swallow hard and notice your lips are dry, Stepping into the room you see a few small tables and maps of the countryside sprawled out.");
			Room castleCourtyard = new Room("Castle Courtyard", "You step into the large castle courtyard there is a flowing fountain in the middle of the grounds and a few guards patrolling the area.");
			Room dungeon = new Room("Dungeon", "As you descend the stairs to the dungeon you notice a harsh chill to the air. Landing a the base of the stairs you see what the remains of a previous prisoner.");
			Room guardRoom = new Room("Guard Room", "Pushing open the door of the guard room you look around and notice the room is empty, There are a few small tools in the corner and a chair propped against the wall near the that likely leads to the dungeon.");
			Room northHall = new Room("North Hallway", "This is the North Hallway.");
			Room southHall = new Room("South Hallway", "This is the South Hallway.");
			Room squireTower = new Room("Squire Tower", "As you finish climbing the stairs to the squire tower you see a messenger nestled in his bed. His messenger overcoat is hanging from his bed post. ");
			Room throneRoom = new Room("Throne Room", "As you unlock the door and swing it wide you see an enormous hall stretching out before you. At the opposite end of the hall sitting on his throne you see the dark lord.");
			Room warRoom = new Room("War Room", "Steping into the war room you see several maps spread across tables. On the maps many of the villages have been marked for purification. You also notice several dishes of prepared food to the side perhaps the war council will be meeting soon.");
			Room westHall = new Room("West Hallway", "You find yourself in a small corridor, there doesnt appear to be anything of interest here.");

			// ROOMS BEING ADDED TO GAME
			Rooms.Add("Barrack's", barracks);
			Rooms.Add("Captains Quarters", captainsQuarters);
			Rooms.Add("Castle Courtyard", castleCourtyard);
			Rooms.Add("Dungeon", dungeon);
			Rooms.Add("Guard Room", guardRoom);
			Rooms.Add("North Hallway", northHall);
			Rooms.Add("South Hallway", southHall);
			Rooms.Add("Squire Tower", squireTower);
			Rooms.Add("Throne Room", throneRoom);
			Rooms.Add("War Room", warRoom);
			Rooms.Add("West Hallway", westHall);

			// EXITS BING ADDED TO THE GAME
			barracks.Exits.Add("SOUTH", westHall);
			captainsQuarters.Exits.Add("NORTH", westHall);
			captainsQuarters.Exits.Add("EAST", southHall);
			castleCourtyard.Exits.Add("SOUTH", southHall);
			castleCourtyard.Exits.Add("WEST", westHall);
			castleCourtyard.Exits.Add("NORTH", northHall);
			dungeon.Exits.Add("SOUTH", guardRoom);
			guardRoom.Exits.Add("NORTH", dungeon);
			guardRoom.Exits.Add("WEST", southHall);
			northHall.Exits.Add("NORTH", throneRoom);
			northHall.Exits.Add("EAST", squireTower);
			northHall.Exits.Add("SOUTH", castleCourtyard);
			southHall.Exits.Add("NORTH", castleCourtyard);
			southHall.Exits.Add("EAST", guardRoom);
			southHall.Exits.Add("WEST", captainsQuarters);
			squireTower.Exits.Add("NORTH", warRoom);
			squireTower.Exits.Add("WEST", northHall);
			throneRoom.Exits.Add("SOUTH", northHall);
			warRoom.Exits.Add("SOUTH", squireTower);
			westHall.Exits.Add("NORTH", barracks);
			westHall.Exits.Add("EAST", castleCourtyard);
			westHall.Exits.Add("SOUTH", captainsQuarters);

			//Items
			Item guardUniform = new Item("GUARD_UNIFORM", "Uniform to desguise yourself.", barracks, true);
			Item hammer = new Item("HAMMER", "Old Rusty hammer.", dungeon, true);
			Item key = new Item("KEY", "An old skull key", castleCourtyard, false);
			Item note = new Item("NOTE", "A note", squireTower, true);
			Item vial = new Item("VIAL", "A vial with green liquid", warRoom, true);
			Item brokenLock = new Item("BROKEN_LOCK", "Old broken lock", captainsQuarters, true);
			Item messengerOvercoat = new Item("MESSENGER_OVERCOAT", "A messengers overcoat", dungeon, true);
			Item Window = new Item("WINDOW", "Window in War Room", warRoom, true);

			barracks.AddItem(guardUniform);
			captainsQuarters.AddItem(key);
			captainsQuarters.AddItem(note);
			captainsQuarters.AddItem(vial);
			guardRoom.AddItem(hammer);
			dungeon.AddItem(brokenLock);
			squireTower.AddItem(messengerOvercoat);
			warRoom.AddItem(Window);

			Game.CurrentRoom = westHall;
		}

	}
}
