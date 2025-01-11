using CinemaBoookingSystem.Data;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CinemaBoookingSystem.Model
{
    public static class Database
    {
        public static BindingList<Customer> Customers { get; private set; } = [];
        public static BindingList<Movie> Movies { get; private set; } = [];
        public static Screen[] Screens { get; private set; } = [];
        public static BindingList<Screening> Screenings { get; private set; } = [];
        public static BindingList<Booking> Bookings { get; private set; } = [];


        static Database()
        {
            DeserializeFromFile();

            GenerateDataIfEmpty();
        }

        public static bool Book(Customer customer, Screening screening, Seat seat)
        {
            Bookings.Add(
                new Booking()
                {
                    Id = Guid.NewGuid(),
                    Screening = screening,
                    BookingTime = DateTime.Now,
                    Customer = customer,
                    Seat = seat,
                });

            return true;
        }

        //public static void DeRegister(object cO, object dO)
        //{
        //    Customer c = (Customer)cO;
        //    Disc d = (Disc)dO;

        //    Stock.Add(d);
        //    c.Rented.Remove(d);
        //}

        public static void Serialize()
        {
            Serialize(Customers, "Data/customers.xml");
            Serialize(Movies, "Data/movies.xml");
            Serialize(Screens, "Data/screens.xml");
            Serialize(Screenings, "Data/screenings.xml");
            Serialize(Bookings, "Data/bookings.xml");
        }

        public static void SerializeList<T>(BindingList<T> list, string file)
        {
            using (Stream s = File.Open(file, FileMode.Create))
            {
                XmlSerializer x = new XmlSerializer(list.GetType());
                x.Serialize(s, list);
            }
        }

        public static void DeserializeFromFile()
        {
            Customers = Deserialize<BindingList<Customer>>("Data/customers.xml");
            Movies = Deserialize<BindingList<Movie>>("Data/movies.xml");
            Screens = Deserialize<Screen[]>("Data/screens.xml");
            Screenings = Deserialize<BindingList<Screening>>("Data/screenings.xml");

            var tempBookings = Deserialize<BindingList<Booking>>("Data/bookings.xml");
            if (tempBookings != null && tempBookings.Count > 0) Bookings = tempBookings;
        }

        public static void GenerateDataIfEmpty()
        {
            if (!Customers.Any())
                Customers = new BindingList<Customer>(DataGenerator.GenerateCustomers(10));

            if (!Movies.Any())
                Movies = new BindingList<Movie>(DataGenerator.GenerateMovies());

            if (!Screens.Any())
                Screens = DataGenerator.GenerateScreens();

            if (!Screenings.Any())
                Screenings = new BindingList<Screening>(DataGenerator.GenerateScreenings([.. Movies], Screens, 100));
        }
        

        public static T Deserialize<T>(string file)
        {
            using Stream s = File.Open(file, FileMode.Open);
            XmlSerializer x = new (typeof(T));
            return (T)x.Deserialize(s)!;
        }

        public static void Serialize<T>(T data, string fileName)
        {
            using Stream s = File.Open(fileName, FileMode.Create);
            XmlSerializer x = new (data!.GetType());
            x.Serialize(s, data);
        }
    }
}
