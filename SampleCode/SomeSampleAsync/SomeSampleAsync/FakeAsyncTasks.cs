using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSampleAsync
{
    public class FakeAsyncTasks
    {
        public Task SendEmailAsync()
        {
            Console.WriteLine("{0} SendEmail", DateTime.Now);
            return Task.Delay(2000);
        }

        public async Task<int> GetRandomNumberAsync()
        {
            Console.WriteLine("{0} GetRandomNumber", DateTime.Now);
            await Task.Delay(2000);
            return new Random().Next(1,10);
        }

        public async Task<string> GetSpecialStringAsync(string message)
        {
            Console.WriteLine("{0} GetSpecialString", DateTime.Now);
            await Task.Delay(2000);
            return string.IsNullOrEmpty(message) ? "<Nothing>" : message.ToUpper();
        }
    }
}
