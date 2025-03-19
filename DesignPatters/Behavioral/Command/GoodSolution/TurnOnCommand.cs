using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Command.GoodSolution
{
   public class TurnOnCommand : ICommand
    {
        private Light _light;

        public TurnOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn(); 
        }

    }
}
