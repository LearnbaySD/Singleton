
using System;
using System.IO;
using System.Threading.Tasks;

namespace Singleton.Logger
{
    class LoggerSystem
    {
        static LoggerSystem instance = null;
        static Object singletonLockObject = new Object();

        string filepath = @"Logs9.txt";
        StreamWriter streamWriter;

        private LoggerSystem(){
            streamWriter = new StreamWriter(new FileStream(filepath, FileMode.Append, FileAccess.Write));
        }

        public static LoggerSystem getInstance()
        {
            if (instance == null)
            {
                lock (singletonLockObject) 
                if (instance == null)
                {
                    instance = new LoggerSystem();
                    return instance;
                }
                return instance;
            }
            return instance;
        }
        public async Task writeAsync(string str)
        {
                await streamWriter.WriteLineAsync(str);
                streamWriter.Flush();
        }

    }
}
