using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    //THis illustrates the common "race condition" issue experienced when implementing multi-threading
    public class RaceCondition
    {
        //Shared instance variable
        private string _definedByThread = "";

        public void RunThreadA()
        {
            ThreadOutput();

        }

        public void RunThreadB()
        {
            ThreadOutput();
        }

        void ThreadOutput()
        {
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("The current thread running is Thread: #{0}", Thread.CurrentThread.ManagedThreadId);

                // Shared variable defined by
                _definedByThread = "Shared Variable Value Set by Thread #" +
                                   Thread.CurrentThread.ManagedThreadId.ToString();

                // Simulate Processing Task
                Thread.Sleep(1000);

                Console.WriteLine(_definedByThread);
            }
        }
    }
}

