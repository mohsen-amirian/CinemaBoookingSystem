using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CinemaBoookingSystem.Model
{
    public class Screening
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }

        public Movie Movie { get; set; }
        public Screen Screen { get; set; }

        [XmlIgnore]
        public string ScreenName => Screen.Name;
    }
}
