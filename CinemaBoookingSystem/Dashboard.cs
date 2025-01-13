using CinemaBoookingSystem.Data;
using System.ComponentModel;

namespace CinemaBoookingSystem
{
    public partial class Dashboard : Form
    {
        private BindingList<Seat> seatsListSource = [];
        private BindingList<Screening> screeningGridSource = [];

        private Screening? selectedScreening;
        private Customer? selectedCustomer;
        private Customer? updatingCustomer;
        public Dashboard()
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

            dgvManageCustomers.AutoGenerateColumns = false;
            dgvManageCustomers.DataSource = Database.Customers;
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
            if (lstbSeats.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a seat to book.",
                    "No Seat Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var selectedSeat = (Seat)lstbSeats.SelectedItem;
            Database.Book(selectedCustomer!, selectedScreening!, selectedSeat);
            seatsListSource.Remove(selectedSeat);

            MessageBox.Show("Successfully booked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Serialize();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a booking to cancel.",
                    "No Booking Selected", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            var booking = (Booking)dgvBookings.CurrentRow.DataBoundItem;
            Database.CancelBooking(booking);
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

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvManageCustomers.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a customer to edit.",
                    "No Customer Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            updatingCustomer = (Customer)dgvManageCustomers.CurrentRow.DataBoundItem;
            gbCustomerEdit.Enabled = true;
            txtEditCustomerName.Text = updatingCustomer.Name;
            txtEditCustomerLastName.Text = updatingCustomer.LastName;
            txtEditCustomerEmail.Text = updatingCustomer.Email;
            txtEditCustomerYOB.Text = updatingCustomer.YearOfBirth.ToString();

            dgvManageCustomers.Enabled = false;
        }

        private void btnCustomerEditSave_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomerInput(
                txtEditCustomerName,
                txtEditCustomerLastName,
                txtEditCustomerEmail,
                txtEditCustomerYOB,
                out int yearOfBirth)) return;

            Database.UpdateCustomer(
                updatingCustomer!.Id,
                txtEditCustomerName.Text,
                txtEditCustomerLastName.Text,
                yearOfBirth,
                txtEditCustomerEmail.Text
                );

            ClearCustomerEditForm();
            dgvManageCustomers.Refresh();
            MessageBox.Show("Customer Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCustomerEditCancel_Click(object sender, EventArgs e)
        {
            ClearCustomerEditForm();
        }

        private void ClearCustomerEditForm()
        {
            txtEditCustomerName.Clear();
            txtEditCustomerLastName.Clear();
            txtEditCustomerYOB.Clear();
            txtEditCustomerEmail.Clear();

            gbCustomerEdit.Enabled = false;
            dgvManageCustomers.Enabled = true;
        }

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomerInput(
                txtNewCustomerName,
                txtNewCustomerLastName,
                txtNewCustomerEmail,
                txtNewCustomerYOB,
                out int yearOfBirth)) return;

            Database.CreateCustomer(
                txtNewCustomerName.Text,
                txtNewCustomerLastName.Text,
                int.Parse(txtNewCustomerYOB.Text),
                txtNewCustomerEmail.Text
                );

            MessageBox.Show("New Customer Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNewCustomerName.Clear();
            txtNewCustomerLastName.Clear();
            txtNewCustomerEmail.Clear();
            txtNewCustomerYOB.Clear();
        }

        private bool ValidateCustomerInput(
            TextBox nameTextBox, TextBox lastNameTextBox, TextBox emailTextBox, TextBox yobTextBox, out int yearOfBirth)
        {
            yearOfBirth = 0;

            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(yobTextBox.Text))
            {
                MessageBox.Show("Please ensure all fields are filled correctly:\n" +
                                "- Name, Last Name, and Email should have values.\n" +
                                "- Year of Birth must be a valid number.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(yobTextBox.Text, out yearOfBirth))
            {
                MessageBox.Show("Year of Birth must be a valid number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var customer = (Customer)dgvManageCustomers.CurrentRow.DataBoundItem;

            var result = MessageBox.Show(
                "Are you sure about deleting a customer? Customer bookings will be removed too.", 
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) { 
                Database.DeleteCustomer(customer.Id);
                MessageBox.Show("Customer Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
