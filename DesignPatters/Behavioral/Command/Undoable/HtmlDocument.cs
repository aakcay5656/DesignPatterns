using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Command.Undoable
{
   public class HtmlDocument
    {
        public string Content {  get; set; }
        public void MakeItalic()
        {
            Content = "<i>" + Content + "</i>";
        }
    }
}
