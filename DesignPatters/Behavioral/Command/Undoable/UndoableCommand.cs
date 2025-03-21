using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Command.Undoable
{
    public interface UndoableCommand : Command
    {
        void Unexecute();
    }
}
