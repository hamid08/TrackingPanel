using System.ComponentModel;

namespace TrackingPanel.Data.Entites
{
    public class Tracking
    {
        public int Id { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int VehicleId { get; set; }

        public string Imei { get; set; }

        public int Speed { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.UtcNow;


    }
}
