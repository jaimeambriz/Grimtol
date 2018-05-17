using System;
using System.Collections.Generic;
using CastleGrimtolData.Modles;

namespace CastleGrimtolData.Interfaces
{
	internal interface IPlayer
	{
		string Name { get; set; }

		List<Item> Inventory { get; set; }
	}
}