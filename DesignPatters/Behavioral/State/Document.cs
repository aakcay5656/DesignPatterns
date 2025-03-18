using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.State
{
    public class Document
    {
        public DocumentStates State {get;set;}
        public UserRoles CurrentUserRole { get; set; }

        public void Publish()
        {

            // Incorrect according to the Open/Closed Principle
            if (State == DocumentStates.Draft)
            {
                State = DocumentStates.Moderation;
            }
            else if(State == DocumentStates.Moderation)
            {
                if (CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumentStates.Published;
                }
            }else if (State == DocumentStates.Published)
            {
                // do nothing
            }
        }
    }
}
