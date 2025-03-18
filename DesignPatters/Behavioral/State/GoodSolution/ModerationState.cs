using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.State.GoodSolution
{
    class ModerationState: State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            if(_document.CurrentUserRole == UserRoles.Admin)
            _document.State = new PublishedState(_document);
        }
    }
}
