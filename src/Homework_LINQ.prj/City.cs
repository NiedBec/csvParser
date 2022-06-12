using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework_LINQ
{
	public class City
	{
		//id;"country_en";"region_en";"city_en";"country";"region";"city";"lat";"lng";"population"
		public string Id { get; set; }
		public string CountryEng { get; set; }
		public string RegionEng { get; set; }
		public string CityEng { get; set; }
		public string CountryRu { get; set; }
		public string RegionRu { get; set; }
		public string CityRu { get; set; }
		public string Lat { get;set; }
		public string Lng { get; set; }
		public string Population { get; set; }
		public void Filter(City city, List<char> charsToRemove)
		{
			foreach(char c in charsToRemove)
			{
				city.Id = city.Id.Replace(c.ToString(), String.Empty);
				city.CountryEng = city.CountryEng.Replace(c.ToString(), String.Empty);
				city.RegionEng = city.RegionEng.Replace(c.ToString(), String.Empty);
				city.CityEng = city.CityEng.Replace(c.ToString(), String.Empty);
				city.CountryRu = city.CountryRu.Replace(c.ToString(), String.Empty);
				city.RegionRu = city.RegionRu.Replace(c.ToString(), String.Empty);
				city.CityRu = city.CityRu.Replace(c.ToString(), String.Empty);
				city.Lat = city.Lat.Replace(c.ToString(), String.Empty);
				city.Lng = city.Lng.Replace(c.ToString(), String.Empty);
				city.Population = city.Population.Replace(c.ToString(), String.Empty);
			}

			return;
		}


		//public class Example
		//{
		//	public static void Main()
		//	{
		//		string str = "@Hello, World.";
		//		List<char> charsToRemove = new List<char>() { '@', '_', ',', '.' };

		//		str = str.Filter(charsToRemove);
		//		Console.WriteLine(str);
		//	}
		//}
	}
}
