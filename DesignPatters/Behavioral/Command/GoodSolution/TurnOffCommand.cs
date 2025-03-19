using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Command.GoodSolution
{
    public class TurnOffCommand : ICommand
    {
        private Light _light;

        public TurnOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
