using System;
using System.Collections.Generic;
using CastleGrimtolData.Interfaces;
namespace CastleGrimtolData.Modles
{
	internal class Player : IPlayer
	{
		public string Name { get; set; }

		public List<Item> Inventory { get; set; }

		public bool Camoufalge { get; set; }

		public Player(string name)
		{
			Name = name;
			Camoufalge = false;
			Inventory = new List<Item>();
		}

		internal void UpdatePlayerStatus(bool camo)
		{
			Camoufalge = camo;
		}

		internal void addToInventory(Item item)
		{
			Inventory.Add(item);
		}
	}
}
