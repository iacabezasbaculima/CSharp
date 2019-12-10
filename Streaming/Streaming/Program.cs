using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Streaming
{
	class Program
	{
		static void Main(string[] args)
		{
			#region MiniRecap In FIle Handling

			// FILES ARE CREATED IN /bin/debug/netcoreapp3.0/

			// Create and write data to a file
			File.WriteAllText("data.txt", "this is some data");
			
			// Create and write data to a file from an array of strings
			var myArray = new string[] { "this", " is", " some", " data."};
			File.WriteAllLines("ArrayData.txt", myArray);

			// Append data
			for (int i = 0; i < 10; i++)
			{
				File.AppendAllText("data.txt", $"{Environment.NewLine}Adding line {i} at {DateTime.Now}");
			}

			// Read all lines from a file
			var output = File.ReadAllLines("data.txt").ToList();
			output.ForEach(l => Console.WriteLine(l));

			// Create directory with file
			Directory.CreateDirectory("Here is a folder");
			Directory.CreateDirectory("Here is another folder");
			File.Create(@"Here is another folder\myfile.txt");

			Directory.CreateDirectory(@"C:/RootFolder");
			Console.WriteLine(Directory.Exists(@"C:/RootFolder"));
			#endregion

			var w = new Stopwatch();
			using (var stream1 = new StreamWriter("output.dat"))
			{
				w.Start();
				for (int i = 0; i < 100_000; i++)
				{
					
					stream1.Write($"{Environment.NewLine}Logging some data {i} at {DateTime.Now}");
				}
				w.Stop();
				Console.WriteLine($"Finished writing to file in {w.ElapsedMilliseconds} ms.");
				stream1.Close();
			}

			using (var reader = new StreamReader("output.dat"))
			{
				// reader does not know how big file is
				// read until reader.readline is not null
				string nextLine;
				w.Restart();
				while ((nextLine = reader.ReadLine()) != null)
				{
					//Console.WriteLine($"Reading line: {nextLine}");
				}
				w.Stop();
				Console.WriteLine($"Finished reading in {w.ElapsedMilliseconds}");
				reader.Close();
			}

			var sb = new StringBuilder();

			using (var reader = new StreamReader("output.dat"))
			{
				w.Restart();
				var nextLine = "";
				while ((nextLine = reader.ReadLine()) != null)
				{
					sb.Append(nextLine);
				}
				w.Stop();
				reader.Close();
				Console.WriteLine($"It took {w.ElapsedMilliseconds} to read lines.");
			}
		}
	}
}
