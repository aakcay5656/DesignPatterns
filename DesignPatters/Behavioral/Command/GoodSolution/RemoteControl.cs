using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Command.GoodSolution
{
    public class RemoteControl
    {
        private ICommand _command;

        public RemoteControl(ICommand command) { 
            _command = command;
        }

        public void SetCommend(ICommand command) {
            _command = command;
        }


        public void PressButton()
        {
            _command.Execute();
        }
    }
}
