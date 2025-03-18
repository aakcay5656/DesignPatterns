using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Memento
{
    // Originator

    public class Editor
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Title,Content); 
        }


        public void Restore(EditorState state)
        {
            Title = state.GetTitle();
            Content = state.GetContent();
        }

    }
}
