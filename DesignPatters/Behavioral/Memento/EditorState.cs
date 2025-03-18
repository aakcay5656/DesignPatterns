using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Memento
{
    // Memento
    public class EditorState
    {
        private readonly string _title;
        private readonly string _content;

        // State meta data
        private readonly DateTime _stateCreateAt;

        public EditorState (string title, string content)
        {
            _title = title;
            _content = content;
            _stateCreateAt = DateTime.Now;
        }

        public string GetTitle()
        {
            return _title;
        }
        public string GetContent()
        {
            return _content;
        }

        public DateTime GetDate()
        {
            return _stateCreateAt;

        }

        public string GetName()
        {
            return $"{_stateCreateAt} / {_title}";
        }

    }
}
