using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadHtml("http://msdn.microsoft.com");
            DownloadHtmlAsync("http://msdn.microsoft.com");

            Console.ReadKey();
        }


        // not async
        public static void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"D:\apps    \result.html"))
            {
                streamWriter.Write(html);
            }
        }

        // async
        public static async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
    }
}
