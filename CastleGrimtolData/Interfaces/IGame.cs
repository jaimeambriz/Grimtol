using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using CastleGrimtolData.Modles;

namespace CastleGrimtolData.Interfaces
{
	internal interface IGame
	{
		Room CurrentRoom { get; set; }
		Player CurrentPlayer { get; set; }
	}
}
