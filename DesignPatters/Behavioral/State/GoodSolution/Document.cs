using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.State.GoodSolution
{
    public class Document
    {
        public State State { get; set; }

        public UserRoles CurrentUserRole { get; set; }

        public Document(UserRoles currentUserRole) {
            State = new DraftState(this);
            CurrentUserRole = currentUserRole; 
        }

        public void Publish()
        {
            State.Publish();
        }
    }
}
