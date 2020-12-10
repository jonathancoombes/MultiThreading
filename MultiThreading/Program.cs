using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uncomment to Run: RaceCondition
             Example 1 demonstrates: execution order of unmanaged threads are unpredictable and not as expected.

            RaceCondition raceCon = new RaceCondition();

            Thread TA = new Thread(raceCon.RunThreadA);
            Thread TB = new Thread(raceCon.RunThreadB);

            TA.Start();
            TB.Start();
            */


            /* Uncomment to Run: UsingLocks 
            Example 2 demonstrates: How to use locks to prevent other threads from accessing the shared code until the current thread has run through the code.

            UsingLocks useLock = new UsingLocks();

            Thread TA = new Thread(useLock.RunThreadA);
            Thread TB = new Thread(useLock.RunThreadB);

            TA.Start();
            TB.Start();
            */


            /* Uncomment to Run: UsingMonitor 
             Example 3 demonstrates: How to use monitor to prevent other threads from accessing from shared code whilst handling exceptions.

             UsingMonitor useMonitor = new UsingMonitor();

             Thread TA = new Thread(useMonitor.RunThreadA);
             Thread TB = new Thread(useMonitor.RunThreadB);

             TA.Start();
             TB.Start();
             */


            // Uncomment to Run: UsingManualResetEvent
             // Example 4 demonstrates: How to use manualResetEvent to prevent other threads from accessing specific code whilst it is being processed by another thread.

             UsingManualResetEvent manualRe = new UsingManualResetEvent();

            Console.ReadLine();
        }
    }
}
