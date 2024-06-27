using System;
using System.Threading;

namespace RoboSiga.Process
{
    public class ProcessManager
    {
        public void Start()
        {
            while (true)
            {
                ExecuteProcess();
                Thread.Sleep(30000);
            }
        }

        private void ExecuteProcess()
        {
            Console.WriteLine(new SigaProcess().Start().Message);
        }
    }
}
