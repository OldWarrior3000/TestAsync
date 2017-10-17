using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            //Task<HttpResponseMessage> volContent =  new HttpClient().GetAsync("http://www.google.com");

            //string c = volContent.Result.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(c);
            //Console.ReadLine();
            #endregion

            #region Example 2
            //LongRunningTask();
            //while (true)
            //{
            //    Console.WriteLine("Main thread");
            //     Thread.Sleep(1000);
            //}
            #endregion

            Console.WriteLine(GetWebPageContent("http://www.google.com").Result);
            Console.ReadLine();
        }

        public async static void LongRunningTask()
        {
            await Task.Delay(10000);
            Console.WriteLine("Child process");
        }

        public async static Task<string> GetWebPageContent(string uri)
        {
            using (WebClient webClient = new WebClient())
            {
                string data = await webClient.DownloadStringTaskAsync(new Uri(uri));
                return data;
            }
        }
    }
}
