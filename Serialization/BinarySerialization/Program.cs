using System;
using System.Collections.Generic;
using System.IO;
using JSONSerialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerialization
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Superhero> heroes = new List<Superhero>()
			{
				new Superhero("Flash", "Super Speed"),
				new Superhero("Thor", "Super Strength")
			};

			// formatter : allow to serialize to binary
			var formatter = new BinaryFormatter();

			// stream to file
			using (var stream = new FileStream("data.bin", FileMode.Create, FileAccess.Write, FileShare.None))
			{
				formatter.Serialize(stream, heroes);
			}
			// read file and deserialize
			var myheroes = new List<Superhero>();
			using (var reader = File.OpenRead("data.bin"))
			{
				myheroes = formatter.Deserialize(reader) as List<Superhero>;
			}
			myheroes.ForEach(h => Console.WriteLine($"{h.Name}, {h.Superpower}"));
		}
	}
}
