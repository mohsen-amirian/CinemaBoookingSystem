using System.Xml.Serialization;

namespace CinemaBoookingSystem.Model
{
    public class Booking()
    {
        public Guid Id { get; set; } 
        public Customer Customer { get; set; } 
        public Screening Screening { get; set; } 
        public Seat Seat { get; set; } 
        public DateTime BookingDate { get; set; }

        [XmlIgnore]
        public string CustomerName => $"{Customer.Name} {Customer.LastName}"; 
        [XmlIgnore]
        public string MovieName => Screening.Movie.Title;
        [XmlIgnore]
        public string ScreenName => Screening.ScreenName;
        [XmlIgnore]
        public int SeatNumber => Seat.Number;
        [XmlIgnore]
        public DateTime ScreeningDate => Screening.DateTime;
    }
}
