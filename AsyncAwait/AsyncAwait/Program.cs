using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace AsyncAwait
{
	class Program
	{
		static void Main(string[] args)
		{
			//GetWebpageSync();
			GetWebpageAsync();
		}

		public async static void GetWebpageAsync()
		{
			await RunAsync();
		}

		public static async Task RunAsync()
		{
			Uri site = new Uri("https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings?redirectedfrom=MSDN#ttSpecifier");
			WebsiteModel model = await Task.Run(() => DownloadWebsite(site));
		}
		private static async Task<WebsiteModel> DownloadWebsite(Uri uri)
		{
			WebsiteModel output = new WebsiteModel();
			WebClient client = new WebClient();
			client.DownloadFile(uri, "localpage.html");
			output.url = uri;
			output.data = client.DownloadString(uri);
			Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
				"localpage.html");

			return output;
		}
		public class WebsiteModel
		{
			public Uri url { get; set; }
			public string data { get; set; }
		}
	}
}
