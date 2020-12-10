using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    public class UsingManualResetEvent
    {
        ManualResetEvent _manualReset = new ManualResetEvent(false);
        public UsingManualResetEvent()
        {
            new Thread(FileWriter).Start();

            for (int i = 0; i<=5; i++) {
                new Thread(FileReader).Start();
            }
        }

        public void FileWriter()
        {
            _manualReset.Reset();
            Console.WriteLine("Writing process started by Thread: #{0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine("Writing process finished");
            _manualReset.Set();
        }

        public void FileReader()
        {
            Console.WriteLine("Reading process waiting for writing to complete..");
            _manualReset.WaitOne();
            Console.WriteLine("Reading process started by Thread: #{0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Reading process finished");
        }


    }
}
