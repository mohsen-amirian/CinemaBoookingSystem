namespace CinemaBoookingSystem.Data
{
    public class Screen()
    {
        public Guid Id { get; set; } 
        public string Name { get; set; } 
        public Seat[] Seats { get; set; } 
    }
}
