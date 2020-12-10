using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{

        //THis illustrates the use of locks to safeguard shared resources when implementing multi-threading
        public class UsingLocks
        {
            //Shared instance variable
            private string _definedByThread = "";

            //Alternative to using "this"
            //Create: private readonly Object _thelock = new Object(); Then use "_thelock" as the param.

            public void RunThreadA()
            {
                lock (this)
                {
                   ThreadOutput();
                }
            }

            public void RunThreadB()
            {
                lock (this)
                {
                   ThreadOutput();
                }
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

