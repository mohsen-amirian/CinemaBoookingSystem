using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBoookingSystem.Model
{
    public class Screening
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }

        public Guid MovieId { get; set; }
        public Guid ScreenId { get; set; }
    }

    public class ScreeningViewModel: Screening
    {
        public string ScreenName { get; set; }
    }
}
