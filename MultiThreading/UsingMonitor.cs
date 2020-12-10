using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    //THis illustrates the use of monitor to safeguard shared resources when implementing multi-threading whilst using exceptions
    public class UsingMonitor
    {
        //Shared instance variable
        private string _definedByThread = "";
        
        public void RunThreadA()
        {
            try
            {
                Monitor.Enter(this);
                ThreadOutput();
                
                Monitor.Exit(this);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
            finally
            {
                Monitor.Exit(this);
            }

        }

        public void RunThreadB()
        {
            try
            {
                Monitor.Enter(this);
                ThreadOutput();
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
            finally
            {
                Monitor.Exit(this);
            }

        }

        void ThreadOutput()
        {
            for (int a = 0; a < 10; a++) {
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
