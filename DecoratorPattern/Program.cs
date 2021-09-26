using System;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEvent evnt = new Event();
            evnt.BookTicket();
            Console.WriteLine(evnt + "\n");
            ConferenceDecorator conference = new ConferenceDecorator(evnt);
            conference.BookTicket();
            Console.WriteLine();
            IEvent evnt2 = new Event();
            MovieDecorator movie = new MovieDecorator(evnt2);
            movie.BookTicket();
            Console.ReadKey();
        }
    }
}
