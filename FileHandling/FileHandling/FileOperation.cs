using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.IO.File;
using static FileHandling.FileOperation;

namespace FileHandling
{
	class FileOperation
	{
		public FileOperation()
		{

		}
		public void ReadFile(string fileName)
		{
			if(File.Exists(fileName))
			{
				string data = ReadAllText(fileName);
				Console.WriteLine("File exists: \n" + data);
			}
			else
			{
				StreamWriter sw = CreateText(fileName);
				sw.WriteLine("This is a new file: " + fileName);
				sw.Flush();
				sw.Close();
				string getBackData = ReadAllText(fileName);
				Console.WriteLine(getBackData);
			}
		}

		public void WriteToFile(string fileName)
		{
			WriteAllText(fileName, "We write to a file: " + fileName);
		}
		public void WriteToFileFromArray(string fileName)
		{
			string[] arr =
			{
				"Hello", "World", ":D" 
			};
			WriteAllLines(fileName, arr);
		}
		public void DeleteFile(string fileName)
		{
			if(Exists(fileName))
			{
				Delete(fileName);
			}
			else Console.WriteLine("File does not exist.");
		}
		public void CopyFile(string sourceFile, string destinationFile)
		{
			Copy(sourceFile, destinationFile, true);
		}
		public void ReadFileToArray(string fileName)
		{
			string[] arr = new string[128];
			ReadFileToArray(fileName);
		}
		public void GetFileProperties(string fileName)
		{
			Console.WriteLine(GetCreationTime(fileName));
			Console.WriteLine(GetAttributes(fileName));
			Console.WriteLine(GetLastAccessTime(fileName));
		}
		public void CreateDirectory(string fileName)
		{
			try
			{
				CreateDirectory(fileName);
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
		}
	}
}
