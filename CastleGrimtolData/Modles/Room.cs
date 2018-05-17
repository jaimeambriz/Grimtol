using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
namespace CastleGrimtolData.Modles
{
	internal class Room
	{
		public string Name { get; private set; }

		public string Description { get; set; }

		public Dictionary<string, Room> Exits { get; set; }

		public List<Item> Items = new List<Item>();

		public Room(string name, string description)
		{
			Name = name;
			Description = description;
			Exits = new Dictionary<string, Room>();
		}

		internal string UseItem(Item item)
		{
			if (item.UseableRoom.Name == Name)
			{
				return $"successfully used {item.Name}";
			}
			return $"Sorry Cant Use {item.Name} here";
		}
		internal void AddItem(Item item)
		{
			Items.Add(item);
		}

		internal Room Go(string direction)
		{
			//VAIDATE DATA
			if (Exits.ContainsKey(direction))
			{
				return Exits[direction];
			}
			return null;
		}

		internal string Look()
		{

			//var info = new Dictionary<string , string>();

			//info.Add(Name, Description);
			//foreach (var exit in Exits)
			//{
			//	info.Add(exit.key)
			//}
			//foreach (var item in Items)
			//{
			//	info.Add("Item", item.Name);
			//}
			return "Exits";
		}
	}
}
