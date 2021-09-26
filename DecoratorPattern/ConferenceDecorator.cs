using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ConferenceDecorator: EventDecorator
    {
        public ConferenceDecorator(IEvent evnt): base(evnt)
        {
        }

        public override IEvent BookTicket()
        {
            eventDetails.BookTicket();
            AddLunchHours(eventDetails);
            return eventDetails;
        }

        private void AddLunchHours(IEvent eventDetails)
        {
            Event nevnt = (Event)eventDetails;
            nevnt.DurationInHours += 0.5m;
            Console.WriteLine("Lunch Hours added to Conference Duration");
        }
    }
}
