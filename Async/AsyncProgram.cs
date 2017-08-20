using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    static class AsyncProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program");
            //TestSyncHello();
            TestAsyncHello();
            Console.WriteLine("End of program");
            Console.ReadLine();
        }

        /// <summary>
        /// Test synchronous hello
        /// </summary>
        private static void TestSyncHello()
        {
            var helloString = GetHelloSync();
            Console.WriteLine(helloString);
        }

        /// <summary>
        /// Test asynchronous hello
        /// </summary>
        private static async void TestAsyncHello()
        {
            var helloString = await GetHelloAsync();
            Console.WriteLine(helloString);
        }

        /// <summary>
        /// Make thread sleep 5 secs
        /// </summary>
        /// <returns>hello string</returns>
        private static string GetHelloSync()
        {
            Console.WriteLine("Starting Long running sync method...");
            Thread.Sleep(5000);
            Console.WriteLine("End Long Running sync method...");
            return "Hello!";
        }

        /// <summary>
        /// Create async task, that waits 5 secs
        /// </summary>
        /// <returns>Hello as string</returns>
        private static async Task<string> GetHelloAsync()
        {
            Console.WriteLine("Starting Long Running async method...");
            await Task.Delay(5000);
            Console.WriteLine("End Long Running async method...");
            return "Hello!";
        }
    }
}