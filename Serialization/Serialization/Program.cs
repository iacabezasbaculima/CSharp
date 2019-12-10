using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
	[Serializable]
	public class Yoda
	{
		public string Name { get; set; }
		public int ForcePower { get; set; }

		[NonSerialized]
		public string HiddenPower;

		public Yoda()
		{

		}
		public Yoda(string name, int power, string hidden)
		{
			Name = name;
			ForcePower = power;
			HiddenPower = hidden;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//WriteXML();
			ReadXML();

			Yoda baby = new Yoda("Super Yoda", 1_000_000, "Fire");

			// Serialize the customer into XML file

			var formatter = new SoapFormatter();

			using (var stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write, FileShare.None))
			{
				formatter.Serialize(stream, baby);
			}

			// Read from XML file
			var y = new Yoda();

			using (var reader = File.OpenRead("data.xml"))
			{
				y = formatter.Deserialize(reader) as Yoda;
			}
			Console.WriteLine($"{y.Name}{y.ForcePower}{y.HiddenPower}");
		}

		public static void WriteXML()
		{
			var babyYoda = new Yoda { Name = "Baby Yoda", ForcePower = 9000 };
			var writer = new System.Xml.Serialization.XmlSerializer(typeof(Yoda));

			var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//yoda.xml";
			System.IO.FileStream file = System.IO.File.Create(path);

			writer.Serialize(file, babyYoda);

			file.Close();
		}
		public static void ReadXML()
		{
			// Now we can read the serialized book ...  
			System.Xml.Serialization.XmlSerializer reader =
				new System.Xml.Serialization.XmlSerializer(typeof(Yoda));
			var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//yoda.xml";
			System.IO.StreamReader file = new System.IO.StreamReader(path);
			Yoda myYoda = (Yoda)reader.Deserialize(file);
			file.Close();

			Console.WriteLine($"{myYoda.Name, -15}{myYoda.ForcePower}");

		}
	}
}
