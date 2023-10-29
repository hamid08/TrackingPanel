namespace TrackingPanel.Controllers
{
    public partial class HomeController
    {
        public class LatLong

        {

            public double Latitude { get; set; }

            public double Longitude { get; set; }


            public LatLong(double latitude, double longitude)

            {

                Latitude = latitude;

                Longitude = longitude;

            }

        }
    }
}