using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleArt
{
	class Program
	{
		static void Main(string[] args)
		{
			Message.Display();
			Message.Animate();
			Console.Read();
		}
	}
		public class Message
		{
			static List<string> textArt = new List<string>();
			/// <summary>
			///	Takes stored word art
			///	Breaks down each line into an individual char
			///	Randomly builds a 2d array of chars
			/// </summary>
			public static void Display()
			{
				

				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Blue;

				// Initilize List<string> 
				textArt = new List<string>();
				// Add message
				textArt.Add("db   d8b   db d88888b  d88888b db   88     8888888  ");
				textArt.Add("88   I8I   88 88'      88'     88  88     888    88 ");
				textArt.Add("88   I8I   88 88ooooo  88ooooo 8888           8888  ");
				textArt.Add("Y8   I8I   88 88       88      8888        888");
				textArt.Add("`8b d8'8b d8' 88.      88.     88  88.    888    ");
				textArt.Add(" `8b8' `8d8'  Y88888P  Y88888P 88   88   888888888'  ");
				textArt.Add(" ");
				textArt.Add(" ");						    
				textArt.Add("P8888b      AAA  B88     88B    dGB8BC8Bb");
				textArt.Add("88' '8D    AAAA   888   888B   8R       ");
				textArt.Add("88   DD   AA  AA   BBbb8B88B   9B");
				textArt.Add("88   DD  AAAAAAAA    8b8b8B8    dYBB8b8db");
				textArt.Add("88   8D AA    AAA        88B           88");
				textArt.Add("B8888P AA     AAAA   888888B   d88Y8Y88Yb");
				textArt.Add(" ");
				textArt.Add(" ");
				textArt.Add("db   db   db   d8b   db ");
				textArt.Add("88   88   88   I8I   88 ");
				textArt.Add("88ooo88   88   I8I   88 ");
				textArt.Add("88~~~88   Y8   I8I   88 ");
				textArt.Add("88   88   `8b d8'8b d8' ");
				textArt.Add("YP   YP    `8b8' `8d8'  ");
			}
		
		public static void Animate()
		{
			// Print message
			foreach (string line in textArt)
			{
				Console.WriteLine(line);
			}
			Thread.Sleep(1000);	// make program thread sleep for 1 second
			Console.Clear();	// Clean up console

			//Store each letter in list<string> into 2d array [rows, columns] => [lines, 200]
			char[,] letters = new char[textArt.Count, 200];
			/*
			 *    __Y____________
			 * X |[0,0] [0,1] ... 
			 *   |[1,0] [1,1] ...
			 *   |[2,0] [2,1] ...
			 *   | ...   ...
			*/

			// Y - top to bottom
			for (int y = 0; y < textArt.Count; y++)
			{
				char[] let = textArt[y].ToCharArray();
				// X - left to right
				for (int x = 0; x < let.Length; x++)
				{
					// y = rows, x = columns
					letters[y, x] = (char)let.GetValue(x);
				}
			}
			//Use the 2d array to randomly print out each char of the hidden message
			Random r = new Random();	// row, column
			Random col = new Random();	// color
			foreach (char character in letters)
			{
				int row = r.Next(textArt.Count);
				int column = r.Next(0, textArt[row].Length);
				// Print character on console
				if (!character.Equals(' '))
				{
					var temp = col.Next(9, 13);
					// Set random color
					Console.ForegroundColor = (ConsoleColor)temp;
					// Set console cursor pos
					Console.SetCursorPosition(column, row);
					// Print char from 2d array
					Console.Write(letters[row, column]);
					// Go to sleep main thread
					Thread.Sleep(3);
				}
			}
		}
	}
}
