﻿namespace CinemaBoookingSystem.Data
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string Email { get; set; }
    }
}
