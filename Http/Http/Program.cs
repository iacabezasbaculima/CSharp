using System;
using System.Net;
using System.Diagnostics;

namespace Http
{
	class Program
	{
		static void Main(string[] args)
		{
			var uri = new Uri("https://getbootstrap.com/");

			Console.WriteLine($"Absolute Path: {uri.AbsoluteUri}");
			Console.WriteLine($"Host: {uri.Host}");
			Console.WriteLine($"Port: {uri.Port}");

			// Get page
			using (var localPage = new WebClient())
			{
				//localPage.DownloadString(uri);
				localPage.DownloadFile(uri, "localPage.html");
			}
		}
	}
}
