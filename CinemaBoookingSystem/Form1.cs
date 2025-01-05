using CinemaBoookingSystem.Model;
using Screen = CinemaBoookingSystem.Model.Screen;

namespace CinemaBoookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = Database.Customers;
            dgvMovies.AutoGenerateColumns = false;
            dgvMovies.DataSource = Database.Movies;
            dgvScreen.AutoGenerateColumns = false;
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            var selectedMovieId = ((Movie)dgvMovies.CurrentRow.DataBoundItem).Id;
            var correctScreenIds = Database.Screenings.Where(x => x.MovieId == selectedMovieId).Select(x => x.ScreenId).ToHashSet();


            dgvScreen.DataSource = Database.Screens.Where(s => correctScreenIds.Contains(s.Id)).ToList();
        }

        private void dgvScreen_SelectionChanged(object sender, EventArgs e)
        {

            var selectedScreen = (Screen)dgvScreen.CurrentRow.DataBoundItem;
            var takenSeatIds =
                Database.Bookings.Where(b => b.ScreeningId == selectedScreen.Id)
                .Select(b => b.SeatId)
                .ToList();

            lstbSeats.DataSource = selectedScreen.Seats.ExceptBy(takenSeatIds, s => s.Id).ToList();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

            //var selectedCustomer = (Customer)dgvCustomers.CurrentRow.DataBoundItem;
            //var selectedMovieId = (Movie)dgvMovies.CurrentRow.DataBoundItem;
            //var selectedScreenId = (Screen)dgvScreen.CurrentRow.DataBoundItem;
            
            //Database.Book()
        }
    }
}
