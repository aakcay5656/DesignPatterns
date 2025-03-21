using Microsoft.Testing.Platform.Extensions.TestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Command.Undoable
{
    public class ItalicCommand : UndoableCommand
    {
        private HtmlDocument _doc;
        private string _prevContent = "";
        private History _history;

        public ItalicCommand(HtmlDocument doc, History history)
        {
            _doc = doc;
            
            _history = history;
        }

        public void Execute()
        {
            _prevContent = _doc.Content;
            _doc.MakeItalic();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _doc.Content = _prevContent;
        }
    }
}
