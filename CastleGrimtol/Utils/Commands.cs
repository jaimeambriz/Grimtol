using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using CastleGrimtol.Services;
namespace CastleGrimtol.Utils
{
	public class Commands
	{
		public string[] UserInput()
		{
			Console.WriteLine("\nWhat would you like to do?\n");
			string[] UserInput;
			string Input = Console.ReadLine().ToLower();
			return UserInput = Input.Split(' ');
		}


	}
}

