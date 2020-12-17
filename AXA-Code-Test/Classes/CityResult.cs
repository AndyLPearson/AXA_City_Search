using AXA_Code_Test.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AXA_Code_Test.Classes
{
    public class CityResult : ICityResult
    {
		public CityResult()
		{
			NextLetters = new HashSet<string>();
			NextCities = new HashSet<string>();
		}

		public ICollection<string> NextLetters { get; set; }
		public ICollection<string> NextCities { get; set; }
	}
}
