using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FileHandling.FileOperation;

namespace FileHandling
{
	class Program
	{
		static void Main(string[] args)
		{
			FileOperation fo = new FileOperation();
			//fo.ReadFile("hello.txt");
			fo.CreateDirectory("myDir");
		}
	}
}
