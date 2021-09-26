using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class EventDecorator : IEvent
    {
        public IEvent eventDetails;

        public EventDecorator(IEvent evnt)
        {
            this.eventDetails = evnt;
        }
        
        public virtual IEvent BookTicket()
        {
            return eventDetails.BookTicket();
        }
    }
}
