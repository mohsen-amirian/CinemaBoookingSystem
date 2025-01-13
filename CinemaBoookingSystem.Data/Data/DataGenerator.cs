namespace CinemaBoookingSystem.Data
{
    public static class DataGenerator
    {
        public static List<Customer> GenerateCustomers(int count)
        {
            string[] firstNames = { "John", "Jane", "Michael", "Sarah", "David", "Emily", "Robert", "Jessica", "Daniel", "Laura" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };
            string[] emailDomains = { "example.com", "mail.com", "test.com", "demo.com" };

            var customers = new List<Customer>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                string email = $"{firstName.ToLower()}.{lastName.ToLower()}@{emailDomains[random.Next(emailDomains.Length)]}";

                customers.Add(new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = firstName,
                    LastName = lastName,
                    YearOfBirth = 1950 + random.Next(50),
                    Email = email
                });
            }

            return customers;
        }

        public static List<Movie> GenerateMovies()
        {
            string[] titles = { "Inception", "The Matrix", "Interstellar", "The Dark Knight", "Pulp Fiction", "Fight Club", "Forrest Gump", "The Shawshank Redemption", "The Godfather", "The Lord of the Rings" };
            string[] genres = { "Action", "Comedy", "Drama", "Horror", "Sci-Fi", "Fantasy", "Thriller", "Romance" };
            string[] directors = { "Christopher Nolan", "Quentin Tarantino", "Steven Spielberg", "Ridley Scott", "James Cameron", "Martin Scorsese", "Peter Jackson", "David Fincher" };

            var movies = new List<Movie>();
            var random = new Random();

            for (int i = 0; i < titles.Length; i++)
            {
                movies.Add(new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = titles[i],
                    Genre = genres[random.Next(genres.Length)],
                    Rating = Math.Round(5.0 + random.NextDouble() * 5.0, 1),
                    Year = 1990 + random.Next(30),
                    Director = directors[random.Next(directors.Length)]
                });
            }

            return movies;
        }

        public static List<Seat> GenerateSeats(int count)
        {
            var seats = new List<Seat>();
            for (int i = 1; i <= count; i++)
            {
                seats.Add(new Seat
                {
                    Id = Guid.NewGuid(),
                    Number = i
                });
            }
            return seats;
        }

        public static Screen[] GenerateScreens()
        {
            string[] screenNames = { "Screen 1", "Screen 2", "Screen 3", "Screen 4", "Screen 5" };

            var screens = new List<Screen>();
            var random = new Random();

            for (int i = 0; i < 5; i++)
            {
                screens.Add(new Screen() {
                    Id = Guid.NewGuid(),
                    Name = screenNames[i],
                    Seats = GenerateSeats(random.Next(50, 101)).ToArray()
                });
            }

            return screens.ToArray();
        }

        public static List<Screening> GenerateScreenings(Movie[] movies, Screen[] screens, int count)
        {
            var screenings = new List<Screening>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                screenings.Add(new Screening
                {
                    Id = Guid.NewGuid(),
                    DateTime = DateTime.Now.AddDays(random.Next(1, 30)).AddHours(random.Next(0, 24)),
                    Movie = movies[random.Next(movies.Length)],
                    Screen = screens[random.Next(screens.Length)]
                });
            }

            return screenings;
        }
    }
}
