using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Mediator
{
    public abstract class DialogBox
    {
        public abstract void Change(UIControl uiControl);
    }
}
