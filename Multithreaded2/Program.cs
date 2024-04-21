using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreaded2
{
    class Program
    {
        static void Main(string[] args)
        {
            string state = "Hello World!";
            ThreadPool.QueueUserWorkItem(NewThread,state);
            Console.WriteLine("Main Thread Does some work and then sleeps");
            Thread.Sleep(1000);
            Console.WriteLine("Main Thread Exits");

            int workerThreads;
            int completionPortThreads;
            ThreadPool.GetAvailableThreads(out workerThreads,
            out completionPortThreads);
            Console.WriteLine("Available threads: " + workerThreads.ToString());
            Console.ReadLine();
        }

        static void NewThread(object stateinfo)
        {

            string state = (string)stateinfo;
            Console.WriteLine("Hello From The ThreadPool:"+state);

        }
    }
}
