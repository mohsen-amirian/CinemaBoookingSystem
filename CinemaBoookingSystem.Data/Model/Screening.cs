using System.Xml.Serialization;

namespace CinemaBoookingSystem.Data
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
