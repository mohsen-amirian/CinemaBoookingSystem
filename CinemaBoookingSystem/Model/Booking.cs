using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBoookingSystem.Model
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid ScreeningId { get; set; }

        public Guid CustomerId { get; set; }
        public Guid SeatId { get; set; }

        public DateTime BookingTime { get; set; }
    }
}
