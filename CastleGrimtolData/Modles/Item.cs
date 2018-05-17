using System;
using CastleGrimtolData.Interfaces;

namespace CastleGrimtolData.Modles
{
	internal class Item : IItem
	{
		public bool Available { get; set; }

		public Room UseableRoom { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public Item(string name, string description, Room room, bool available)
		{
			Name = name;
			Description = description;
			UseableRoom = room;
			Available = available;
		}
	}
}
