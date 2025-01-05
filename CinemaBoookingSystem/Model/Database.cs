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
        public static BindingList<Customer> Customers { get; private set; } = [];
        public static BindingList<Movie> Movies { get; private set; } = [];
        public static BindingList<Screen> Screens { get; private set; } = [];
        public static BindingList<Screening> Screenings { get; private set; } = [];


        static Database()
        {
            //Customers.Add(new Customer("John", "Doe", "Prague", 1985));
            //Customers.Add(new Customer("Peter", "Novak", "Kladno", 1995));
            //Customers.Add(new Customer("Moe", "Sziszlak", "Springfield", 1975));
            //Customers.Add(new Customer("Bart", "Simpson", "Springfield", 2014));
            //Customers[3].Rented.Add(new CD("Black Album", "Metallica", "metal", 25));

            //Stock.Add(new CD("Rosenrot", "Rammstein", "metal", 25));
            //Stock.Add(new CD("Black Ice", "AC/DC", "rock", 25));
            //Stock.Add(new CD("Blue Blood", "X Japan", "metal", 25));

            //Stock.Add(new Dvd("Star Wars", "George Lucas", "scifi", 30));
            //Stock.Add(new Dvd("Top Gun", "Tony Scott", "action", 30));
            //Stock.Add(new Dvd("50 Shades of Grey", "Some Person", "erotic", 30, true));
            Deserialize();
        }

        //public static bool Book(object cO, object dO)
        //{
        //    Customer c = (Customer)cO;
        //    Disc d = (Disc)dO;

        //    if (!c.Adult && (d is Dvd dvd) && dvd.Restricted) return false;

        //    c.Rented.Add(d);
        //    Stock.Remove(d);

        //    return true;
        //}

        //public static void Return(object cO, object dO)
        //{
        //    Customer c = (Customer)cO;
        //    Disc d = (Disc)dO;

        //    Stock.Add(d);
        //    c.Rented.Remove(d);
        //}

        public static void Serialize()
        {
            SerializeList(Customers, "customers.xml");
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
            Customers = Deserialize<Customer>("Data/customers.xml");
            Movies = Deserialize<Movie>("Data/movies.xml");
            Screens = Deserialize<Screen>("Data/screens.xml");
            Screenings = Deserialize<Screening>("Data/screenings.xml");
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

        private static List<T> GetRandomElements<T>(BindingList<T> list)
        {
            var random = new Random();
            var random2 = new Random();
            var count = random2.Next(1, list.Count);
            var result = new List<T>();
            var indices = new HashSet<int>();

            while (indices.Count < count)
            {
                int index = random.Next(list.Count);
                if (indices.Add(index))
                {
                    result.Add(list[index]);
                }
            }

            return result;
        }

        public static BindingList<T> Deserialize<T>(string file)
        {
            using (Stream s = File.Open(file, FileMode.Open))
            {
                XmlSerializer x = new XmlSerializer(typeof(BindingList<T>));
                return (BindingList<T>)x.Deserialize(s);
            }
        }
    }
}
