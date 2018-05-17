using System;
using System.Collections.Generic;
using CastleGrimtolData.Interfaces;
using CastleGrimtolData.Modles;

namespace CastleGrimtolData.HelperModels
{
	public class ReturnRoom : IRoom
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public ReturnRoom(string name, string description)
		{
			Name = name;
			Description = description;

		}
	}
}
