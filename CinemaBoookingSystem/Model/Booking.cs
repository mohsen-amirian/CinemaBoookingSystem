using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBoookingSystem.Model
{
    public class Booking()
    {
        public Guid Id { get; set; } 
        public Customer Customer { get; set; } 
        public Screening Screening { get; set; } 
        public Seat Seat { get; set; } 
        public DateTime BookingTime { get; set; } 
    }
}
