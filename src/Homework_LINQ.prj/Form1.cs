using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Homework_LINQ
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public string FilePath { get; private set; }
		private void button1_Click(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				FilePath = openFileDialog1.FileName;
			}

			char[] charSeparators = new char[] { '\n',';' ,'\r'};
			List<City> cities = new List<City>();
			//Dataset
			var peaceOfData = File.ReadAllText(FilePath).Trim().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToList();
			//id;"country_en";"region_en";"city_en";"country";"region";"city";"lat";"lng";"population"
			//    "\"id\""
			List<char> charsToRemove = new List<char>() { '@', ' ', ',', '.', '"',(char)92 };


			for(int i = 10; i < peaceOfData.Count; i=i+10)
			{
				City example = new City();
				example.Id = peaceOfData[i];
				example.CountryEng = peaceOfData[i + 1];
				example.RegionEng = peaceOfData[i + 2];
				example.CityEng = peaceOfData[i + 3];
				example.CountryRu = peaceOfData[i + 4];
				example.RegionRu = peaceOfData[i + 5];
				example.CityRu = peaceOfData[i + 6];
				example.Lat = peaceOfData[i + 7];
				example.Lng = peaceOfData[i + 8];
				example.Population = peaceOfData[i + 9];
				example.Filter(example, charsToRemove);
				cities.Add(example);
			}
			//Request №1
			//var request = cities.Where(city => Int32.Parse(city.Id) < 7);

			//Request №2
			var request = cities.Where(city => city.CountryEng.Equals("Russia"));
			//Execution
			foreach(var city in request)
			{
				var item = city;
				dataGridView1.Rows.Add(item.Id,item.CountryEng,item.RegionEng,item.CityEng,item.CountryRu,item.RegionRu,item.CityRu,item.Lat,item.Lng,item.Population);
			}

		}


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}
	}
}
