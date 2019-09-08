using Singleton.Logger;
using System.Threading.Tasks;

namespace Singleton.WorkerA
{
    class WorkerA
    {
        LoggerSystem logger { get; set; }

        public WorkerA()
        {
            logger = LoggerSystem.getInstance();
        }

        public async Task runner()
        {
            int x = 0;
            while(x<10)
            {
                await Task.Delay(50);
                await logger.writeAsync("WorkerA " + x + " has been printed!! \n");
                x++;
            }
            
        }
    }
}
