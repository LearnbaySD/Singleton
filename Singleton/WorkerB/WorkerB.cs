using Singleton.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.WorkerB
{
    class WorkerB
    {
        LoggerSystem logger { get; set; }

        public WorkerB()
        {
            logger = LoggerSystem.getInstance();
        }
        public async Task runner()
        {
            int x = 0;
            while (x < 10)
            {
                await Task.Delay(50);
                await logger.writeAsync("WorkerB " + x + " has been printed!! \n");
                x++;
            }

        }
    }
}
