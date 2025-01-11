using CinemaBoookingSystem.Model;
using System.ComponentModel;

namespace CinemaBoookingSystem
{
    public partial class Form1 : Form
    {
        private BindingList<Seat> seatsListSource = [];
        private BindingList<Screening> screeningGridSource = [];

        private Screening? selectedScreening;
        private Customer? selectedCustomer;
        public Form1()
        {
            InitializeComponent();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = Database.Customers;

            dgvMovies.AutoGenerateColumns = false;
            dgvMovies.DataSource = Database.Movies;

            dgvScreening.AutoGenerateColumns = false;
            dgvScreening.DataSource = screeningGridSource;

            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.DataSource = Database.Bookings;

            lstbSeats.DataSource = seatsListSource;
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            selectedCustomer = (Customer)dgvCustomers.CurrentRow.DataBoundItem;
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            screeningGridSource.Clear();

            var selectedMovieId = ((Movie)dgvMovies.CurrentRow.DataBoundItem).Id;
            var screenings = Database.Screenings.Where(x => x.Movie.Id == selectedMovieId);

            foreach (var screening in screenings)
                screeningGridSource.Add(screening);
        }

        private void dgvScreening_SelectionChanged(object sender, EventArgs e)
        {
            if (!screeningGridSource.Any()) return;

            selectedScreening = (Screening)dgvScreening.CurrentRow.DataBoundItem;
            updateSeats(selectedScreening);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            var selectedSeat = (Seat)lstbSeats.SelectedItem;
            Database.Book(selectedCustomer, selectedScreening, selectedSeat);
            seatsListSource.Remove(selectedSeat);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Serialize();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            var booking = (Booking)dgvBookings.CurrentRow.DataBoundItem;
            Database.Bookings.Remove(booking);
            updateSeats(booking.Screening);
        }

        private void updateSeats(Screening screening)
        {
            var takenSeatIds =
                Database.Bookings.Where(b => b.Screening.Id == screening.Id)
                .Select(b => b.Seat.Id)
                .ToList();

            var feeSeats = screening.Screen.Seats.ExceptBy(takenSeatIds, s => s.Id).ToList();

            seatsListSource.Clear();
            foreach (var seat in feeSeats)
                seatsListSource.Add(seat);
        }
    }
}
