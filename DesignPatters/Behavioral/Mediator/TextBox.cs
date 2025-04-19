using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Mediator
{
    public class TextBox:UIControl
    {
        private string _text = "";

        public TextBox(DialogBox owner) : base(owner)
        {
            
        }

        public String GetText()
        {
            return _text;
        }

        public void SetText(String text)
        {
            _text = text;
            _owner.Change(this);
        }
    }
}
