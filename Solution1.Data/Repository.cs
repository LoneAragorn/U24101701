using System;
using System.Collections.Generic;
using System.Text;

namespace Solution1.Data
{
    public class Repository
    {
        private static Repository _repo = new Repository();
        public static Repository GetRepo { get { return _repo; } }

        private List<Booking> booking = new List<Booking>();
        
        public Repository()
        {
            booking.Add(new Booking() { EventName = "Skola", Place = "Östra", Date = "25.10.2017 kl 14", Name = "Kuben" });
            booking.Add(new Booking() { EventName = "Fika", Place = "Café", Date = "12.12.2017 kl 13", Name = "Gurkan" });
            booking.Add(new Booking() { EventName = "Bowling", Place = "Högdalen", Date = "27.10.2017 kl 14", Name = "Jenny" });
            booking.Add(new Booking() { EventName = "Streetrace", Place = "Stuvsta", Date = "25.11.2017 kl 06:30", Name = "Alle" });
            booking.Add(new Booking() { EventName = "Simmning", Place = "Farsta", Date = "03.01.2018 kl 15", Name = "Thompa" });
        }

        public List<Booking> Bookings
        {
            get
            {
                return booking;
            }
        }

        public void Add(Booking b)
        {
            booking.Add(b);
        }
    }
}
