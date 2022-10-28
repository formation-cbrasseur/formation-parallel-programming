using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSampleAsync
{
    public static class WaysToUseAsync
    {
        public static async Task<string> DoTasksV1(string message)
        {
            Console.WriteLine("{0} Entering in method DoTasksV1", DateTime.Now);
            var fakeAsync = new FakeAsyncTasks();
            await fakeAsync.SendEmailAsync();
            var randomNumber = await fakeAsync.GetRandomNumberAsync();
            var upperString = await fakeAsync.GetSpecialStringAsync(message);
            Console.WriteLine("{0} Out of method DoTasksV1", DateTime.Now);
            return string.Format("{0}-{1}", randomNumber, upperString);
        }

        public static async Task<string> DoTasksV2(string message)
        {
            Console.WriteLine("{0} Entering in method DoTasksV2", DateTime.Now);
            var fakeAsync = new FakeAsyncTasks();
            var emailTask = fakeAsync.SendEmailAsync();
            var randomNumber = await fakeAsync.GetRandomNumberAsync();
            var upperString = await fakeAsync.GetSpecialStringAsync(message);
            await emailTask;
            Console.WriteLine("{0} Out of method DoTasksV2", DateTime.Now);
            return string.Format("{0}-{1}", randomNumber, upperString);
        }

        public static async Task<string> DoTasksV3(string message)
        {
            Console.WriteLine("{0} Entering in method DoTasksV3", DateTime.Now);
            var fakeAsync = new FakeAsyncTasks();
            var emailTask = fakeAsync.SendEmailAsync();
            var numberTask = fakeAsync.GetRandomNumberAsync();
            var stringTask = fakeAsync.GetSpecialStringAsync(message);
            
            await emailTask;
            var randomNumber = await numberTask;
            var upperString = await stringTask;
            Console.WriteLine("{0} Out of method DoTasksV3", DateTime.Now);
            return string.Format("{0}-{1}", randomNumber, upperString);
        }
        public static async Task<string> DoTasksV4(string message)
        {
            Console.WriteLine("{0} Entering in method DoTasksV4", DateTime.Now);
            var fakeAsync = new FakeAsyncTasks();
            var emailTask = fakeAsync.SendEmailAsync();
            var numberTask = fakeAsync.GetRandomNumberAsync();
            var stringTask = fakeAsync.GetSpecialStringAsync(message);

            await Task<string>.WhenAll(emailTask, numberTask, stringTask);
            Console.WriteLine("{0} Out of method DoTasksV4", DateTime.Now);
            var randomNumber = numberTask.Result.ToString();
            var upperString = stringTask.Result;
            return string.Format("{0}-{1}", randomNumber, upperString);
        }

    }
}
