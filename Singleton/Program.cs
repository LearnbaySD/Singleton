using System;
using System.IO;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerA.WorkerA workerA = new WorkerA.WorkerA();
            WorkerB.WorkerB workerB = new WorkerB.WorkerB();
            Task A = workerA.runner();
            Task B = workerB.runner();
            
            try
            {
                A.Wait();
                B.Wait();
            } catch (Exception e)
            {
                Console.WriteLine(e.InnerException + " " + e.StackTrace);
            }
            
            Console.ReadKey();
        }
    }
}
