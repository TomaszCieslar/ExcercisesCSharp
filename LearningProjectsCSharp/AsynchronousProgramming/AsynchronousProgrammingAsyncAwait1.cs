using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    public class AsynchronousProgrammingAsyncAwait1
    {
        public void Main()
        {

            string result = DownloadContent().Result;
            Console.WriteLine(result);

            Console.ReadLine();
        }
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://microsoft.com");
                return result;
            }
        }
    }
}
