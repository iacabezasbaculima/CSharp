using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace JSONSerialization
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Superhero> heroes = new List<Superhero>()
			{
				new Superhero("Superman", "Super Strength"),
				new Superhero("Batman", "Super Intelligence")
			};

			// Serialize lis to JSON format
			var jsonHeroList = JsonConvert.SerializeObject(heroes);

			// Create JSON file with heroes list
			File.WriteAllText("heroes.json", jsonHeroList);

			// Read from new JSON file
			var jsonString = File.ReadAllText("heroes.json");
			var heroesFromJSON = JsonConvert.DeserializeObject<List<Superhero>>(jsonString);

			heroesFromJSON.ForEach(h => Console.WriteLine($"{h.Name}, {h.Superpower}"));

			// From XML to JSON

			string xml = @"<?xml version='1.0' standalone='no'?>
				<root>
				  <person id='1'>
					<name>Alan</name>
					<url>http://www.google.com</url>
				  </person>
				  <person id='2'>
					<name>Louis</name>
					<url>http://www.yahoo.com</url>
				  </person>
				</root>";
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xml);

			string jsonText = JsonConvert.SerializeXmlNode(doc);
			Console.WriteLine("==========================================================");
			Console.WriteLine(jsonText);
		}
	}
	[Serializable]
	public class Superhero
	{
		[NonSerialized]
		private string RealName;
		public string Name { get; set; }
		public string Superpower { get; set; }
		public Superhero(string name, string power)
		{
			Name = name;
			Superpower = power;
		}
	}
}
