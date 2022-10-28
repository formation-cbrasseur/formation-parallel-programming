using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSampleAsync
{
    public static class SimpleAsyncUsage
    {
        public static async void SimpleAsyncCall()
        {
            try
            {
                var client = new HttpClient();
                string[] results = await Task.WhenAll(
                    client.GetStringAsync("https://official-joke-api.appspot.com/random_joke"),
                    client.GetStringAsync("https://official-joke-api.appspot.com/random_joke")
                );

                Console.WriteLine("FIRST RESULT");
                Console.WriteLine(results[0]);

                Console.WriteLine("SECOND RESULT");
                Console.WriteLine(results[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
