using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MovieDecorator : EventDecorator
    {
        public MovieDecorator(IEvent evnt) : base(evnt)
        {
        }

        public override IEvent BookTicket()
        {
            eventDetails.BookTicket();
            AddIntervalMinutes(eventDetails);
            return eventDetails;
        }

        private void AddIntervalMinutes(IEvent eventDetails)
        {
            Event nevnt = (Event)eventDetails;
            nevnt.DurationInHours += 0.15m;
            Console.WriteLine("Interval Minutes added to Movie Duration");
        }
    }
}
