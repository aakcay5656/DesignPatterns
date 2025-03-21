using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Command.Undoable
{
   public class History
    {
        private List<UndoableCommand> _command = new List<UndoableCommand>();

        public void Push (UndoableCommand command)
        {
            _command.Add(command);
        }

        public UndoableCommand Pop()
        {
            var last = _command.Last();
            _command.Remove(last);
            return last;
        }

        public int Size()
        {
            return _command.Count;
        }
    }
}
