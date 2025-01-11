using CinemaBoookingSystem.Model;
using System.ComponentModel;

namespace CinemaBoookingSystem
{
    public partial class Form1 : Form
    {
        private BindingList<ScreeningViewModel> screeningGridSource = [];
        private BindingList<Seat> seatsListSource = [];

        private ScreeningViewModel? selectedScreening;
        private Guid? selectedCustomerId;
        public Form1()
        {
            InitializeComponent();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = Database.Customers;

            dgvMovies.AutoGenerateColumns = false;
            dgvMovies.DataSource = Database.Movies;

            dgvScreening.AutoGenerateColumns = false;
            dgvScreening.DataSource = screeningGridSource;

            lstbSeats.DataSource = seatsListSource;
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            selectedCustomerId = ((Customer)dgvCustomers.CurrentRow.DataBoundItem).Id;
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            screeningGridSource.Clear();

            var selectedMovieId = ((Movie)dgvMovies.CurrentRow.DataBoundItem).Id;
            var screenings = Database.Screenings
                .Where(x => x.MovieId == selectedMovieId)
                .Select(s => new ScreeningViewModel()
                {
                    Id = s.Id,
                    DateTime = s.DateTime,
                    MovieId = s.MovieId,
                    ScreenId = s.ScreenId,
                    ScreenName = Database.Screens.Single(x => x.Id == s.ScreenId).Name,
                });

            foreach (var screening in screenings)
                screeningGridSource.Add(screening);
        }

        private void dgvScreening_SelectionChanged(object sender, EventArgs e)
        {
            if (!screeningGridSource.Any()) return;

            selectedScreening = (ScreeningViewModel)dgvScreening.CurrentRow.DataBoundItem;
            var takenSeatIds =
                Database.Bookings.Where(b => b.ScreeningId == selectedScreening.Id)
                .Select(b => b.SeatId)
                .ToList();

            var seats = Database.Screens
                .Single(s => s.Id == selectedScreening.ScreenId).Seats
                .ExceptBy(takenSeatIds, s => s.Id).ToList();

            seatsListSource.Clear();
            foreach (var seat in seats)
                seatsListSource.Add(seat);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            var selectedSeat = (Seat)lstbSeats.SelectedItem;
            Database.Book(selectedCustomerId.Value, selectedScreening.Id, selectedSeat.Id);
            seatsListSource.Remove(selectedSeat);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Serialize();
        }
    }
}
