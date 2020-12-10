using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    public class UsingAutoResetEvent
    {
        AutoResetEvent _autoReset = new AutoResetEvent(true);
        public UsingAutoResetEvent()
        {
            for (int i = 0; i <= 5; i++)
            {
                new Thread(FileWriter).Start();
            }
        }

        public void FileWriter()
        {
            _autoReset.WaitOne();
            Console.WriteLine("Writing process started by Thread: #{0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine("Writing process finished");
            _autoReset.Set();
        }

    }
}
