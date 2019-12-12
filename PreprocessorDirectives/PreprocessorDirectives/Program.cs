using System;
using System.Diagnostics;

namespace PreprocessorDirectives
{
	class Program
	{
		static void Main(string[] args)
		{
#if DEBUG
			Console.WriteLine("Hello, Debug World!");
			Trace.WriteLine("THIS IS A TRACE");
#else
			global::System.Console.WriteLine("Hello, Release World!");
			Trace.WriteLine("THIS IS A TRACE");
#endif
		}
	}
}
