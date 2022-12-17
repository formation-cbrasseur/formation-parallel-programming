using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSampleAsync
{
    public class TaskExceptionGetAll
    {
        public static async Task<IEnumerable<T>> WhenAll<T>(params Task<T>[] tasks)
        {
            var allTasks = Task.WhenAll(tasks);

            try
            {
                return await allTasks;
            }
            catch (Exception)
            {
                // Ignoring exception here
            }

            throw allTasks.Exception ?? throw new Exception("Should never throw this one");
        }
    }
}
