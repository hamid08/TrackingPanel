namespace TrackingPanel.Data.Entites
{
    public class VehicleTracking
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public DateTime LastTrackingTime { get; set; }
        public DateTime LastConnectionTime { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.UtcNow;


    }
}
