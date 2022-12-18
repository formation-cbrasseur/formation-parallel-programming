﻿using System;
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
            await FakeAsyncTasks.SendEmailAsync();
            var randomNumber = await FakeAsyncTasks.GetRandomNumberAsync();
            var upperString = await FakeAsyncTasks.GetSpecialStringAsync(message);
            Console.WriteLine("{0} Out of method DoTasksV1", DateTime.Now);
            return string.Format("{0}-{1}", randomNumber, upperString);
        }

        public static async Task<string> DoTasksV2(string message)
        {
            Console.WriteLine("{0} Entering in method DoTasksV2", DateTime.Now);
            var emailTask = FakeAsyncTasks.SendEmailAsync();
            var randomNumber = await FakeAsyncTasks.GetRandomNumberAsync();
            var upperString = await FakeAsyncTasks.GetSpecialStringAsync(message);
            await emailTask;
            Console.WriteLine("{0} Out of method DoTasksV2", DateTime.Now);
            return string.Format("{0}-{1}", randomNumber, upperString);
        }

        public static async Task<string> DoTasksV3(string message)
        {
            Console.WriteLine("{0} Entering in method DoTasksV3", DateTime.Now);
            var emailTask = FakeAsyncTasks.SendEmailAsync();
            var numberTask = FakeAsyncTasks.GetRandomNumberAsync();
            var stringTask = FakeAsyncTasks.GetSpecialStringAsync(message);
            
            await emailTask;
            var randomNumber = await numberTask;
            var upperString = await stringTask;
            Console.WriteLine("{0} Out of method DoTasksV3", DateTime.Now);
            return string.Format("{0}-{1}", randomNumber, upperString);
        }

        public static async Task<string> DoTasksV4(string message)
        {
            Console.WriteLine("{0} Entering in method DoTasksV4", DateTime.Now);
            var emailTask = FakeAsyncTasks.SendEmailAsync();
            var numberTask = FakeAsyncTasks.GetRandomNumberAsync();
            var stringTask = FakeAsyncTasks.GetSpecialStringAsync(message);

            await Task.WhenAll(emailTask, numberTask, stringTask);
            Console.WriteLine("{0} Out of method DoTasksV4", DateTime.Now);
            var randomNumber = numberTask.Result.ToString();
            var upperString = stringTask.Result;
            return string.Format("{0}-{1}", randomNumber, upperString);
        }

        public static async Task<string> DoTasksV5(string message)
        {
            Console.WriteLine("{0} Entering in method DoTasksV5", DateTime.Now);
            var emailTask = FakeAsyncTasks.SendEmailAsync();
            var numberTask = FakeAsyncTasks.GetRandomNumberAsync();
            var stringTask = FakeAsyncTasks.GetSpecialStringAsync(message);

            var allTasks = new List<Task> { emailTask, numberTask, stringTask };
            var randomNumber = 0;
            var upperString = string.Empty;

            while (allTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(allTasks);
                if (finishedTask == emailTask)
                {
                    Console.WriteLine("Email sent");
                }
                else if (finishedTask == numberTask)
                {
                    randomNumber = numberTask.Result;
                    Console.WriteLine("Number got");
                }
                else if (finishedTask == stringTask)
                {
                    upperString = stringTask.Result;
                    Console.WriteLine("String replaced");
                }
                allTasks.Remove(finishedTask);
            }
            Console.WriteLine("{0} Out of method DoTasksV5", DateTime.Now);
            return string.Format("{0}-{1}", randomNumber, upperString);
        }

    }
}
