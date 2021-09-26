using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Event: IEvent
    {
        public string Name { get; set; }
        public decimal DurationInHours { get; set; }
        public decimal Price { get; set; }

        public IEvent BookTicket()
        {
            Name = "Movie";
            DurationInHours = 2.5m;
            Price = 50;
            return this;
        }

        public override string ToString()
        {
            return "Event " +  Name + " Duration " + DurationInHours + " Price " + Price;
        }
    }
}
