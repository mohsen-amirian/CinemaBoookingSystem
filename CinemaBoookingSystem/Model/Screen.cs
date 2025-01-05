using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBoookingSystem.Model
{
    public class Screen
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Seat> Seats { get; set;}
    }
}
