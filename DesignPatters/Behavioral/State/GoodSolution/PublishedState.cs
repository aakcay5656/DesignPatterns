using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.State.GoodSolution
{
    public class PublishedState : State
    {
        private Document _document;

        public PublishedState ( Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            // do nothing if already publish state
            return;
        }

    }
}
