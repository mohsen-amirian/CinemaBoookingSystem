using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CinemaBoookingSystem.Model
{
    public static class Database
    {
        public static Customer[] Customers { get; private set; } = [];
        public static Movie[] Movies { get; private set; } = [];
        public static Screen[] Screens { get; private set; } = [];
        public static Screening[] Screenings { get; private set; } = [];
        public static List<Booking> Bookings { get; private set; } = [];


        static Database()
        {
            Deserialize();
        }

        public static bool Book(Guid customerId, Guid screeningId, Guid seatId)
        {
            var b = new Booking()
            {
                Id = Guid.NewGuid(),
                CustomerId = customerId,
                BookingTime = DateTime.Now,
                ScreeningId = screeningId,
                SeatId = seatId,
            };

            Bookings.Add(b);

            return true;
        }

        //public static void Return(object cO, object dO)
        //{
        //    Customer c = (Customer)cO;
        //    Disc d = (Disc)dO;

        //    Stock.Add(d);
        //    c.Rented.Remove(d);
        //}

        public static void Serialize()
        {
            Serialize(Bookings, "bookings.xml");
        }

        public static void SerializeList<T>(BindingList<T> list, string file)
        {
            using (Stream s = File.Open(file, FileMode.Create))
            {
                XmlSerializer x = new XmlSerializer(list.GetType());
                x.Serialize(s, list);
            }
        }

        public static void Deserialize()
        {
            Customers = Deserialize<Customer[]>("Data/customers.xml");
            Movies = Deserialize<Movie[]>("Data/movies.xml");
            Screens = Deserialize<Screen[]>("Data/screens.xml");
            Screenings = Deserialize<Screening[]>("Data/screenings.xml");

            var tempBookings = Deserialize<List<Booking>>("Data/bookings.xml");
            if (tempBookings != null && tempBookings.Count > 0) Bookings = tempBookings;
        }

        private static BindingList<Screening> GenerateScreeinings()
        {
            var random = new Random();
            var data = new BindingList<Screening>();
            foreach (var screen in Screens)
            {
                var selectedMovies = GetRandomElements(Movies);
                foreach (var movie in selectedMovies)
                {
                    data.Add(new Screening() { 
                        Id = Guid.NewGuid(),
                        MovieId = movie.Id,
                        ScreenId = screen.Id,
                        DateTime = DateTime.Now.AddDays(random.Next(20)) });
                }
            }
            return data;
        }

        private static List<T> GetRandomElements<T>(T[] list)
        {
            var random = new Random();
            var random2 = new Random();
            var count = random2.Next(1, list.Count());
            var result = new List<T>();
            var indices = new HashSet<int>();

            while (indices.Count < count)
            {
                int index = random.Next(list.Count());
                if (indices.Add(index))
                {
                    result.Add(list[index]);
                }
            }

            return result;
        }

        public static T Deserialize<T>(string file)
        {
            using (Stream s = File.Open(file, FileMode.Open))
            {
                XmlSerializer x = new XmlSerializer(typeof(T));
                return (T)x.Deserialize(s);
            }
        }

        public static void Serialize<T>(T data, string fileName)
        {
            using (Stream s = File.Open(fileName, FileMode.Create))
            {
                XmlSerializer x = new XmlSerializer(data.GetType());
                x.Serialize(s, data);
            }
        }
    }
}
