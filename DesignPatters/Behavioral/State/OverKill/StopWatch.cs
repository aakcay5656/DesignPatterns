using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.State.OverKill
{
   public class StopWatch
    {
        private bool IsRunning { get; set; } = false;

        public void click()
        {
            if (IsRunning)
            {
                IsRunning = false;
                Console.WriteLine("Stopped");
            }
            else
            {
                IsRunning = true;
                Console.WriteLine("Running");
            }
        }
    }
}
