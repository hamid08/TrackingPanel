using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrackingPanel.Data.Context;
using TrackingPanel.Models;

namespace TrackingPanel.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EFDbContext _context;

        public HomeController(ILogger<HomeController> logger, EFDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        //public static double GetRadiusByListLatLong(List<Coordinate> coordinates)
        //{
        //    if (coordinates.Count < 2)
        //    {
        //        return 0;
        //    }

        //    double maxDistance = 0;

        //    double currentDistance;


        //    for (int i = 0; i < coordinates.Count - 1; i++)
        //    {
        //        currentDistance = Haversine(coordinates[i].Latitude, coordinates[i].Longitude, coordinates[i + 1].Latitude, coordinates[i + 1].Longitude);

        //        maxDistance = Math.Max(maxDistance, currentDistance);

        //    }

        //    return maxDistance;
        //}


        //public static double GetRadiusByListLatLong(List<LatLong> coordinates)
        //{
        //    if (coordinates.Count < 2)
        //    {
        //        return 0;
        //    }

        //    double maxDistance = 0;

        //    double currentDistance;


        //    for (int i = 0; i < coordinates.Count - 1; i++)
        //    {
        //        currentDistance = Haversine(coordinates[i].Latitude, coordinates[i].Longitude, coordinates[i + 1].Latitude, coordinates[i + 1].Longitude);

        //        maxDistance = Math.Max(maxDistance, currentDistance);

        //    }

        //    return maxDistance;
        //}


        //public static double Haversine(double lat1, double lon1, double lat2, double lon2)
        //{

        //    const double R = 6371; // Radius of the Earth in km

        //    double dLat = (lat2 - lat1) * Math.PI / 180;

        //    double dLon = (lon2 - lon1) * Math.PI / 180;


        //    double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +

        //               Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) *

        //               Math.Sin(dLon / 2) * Math.Sin(dLon / 2);


        //    double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        //    double d = R * c; // Distance in km


        //    return d;
        //}
    
        public static LatLong GetCenterPoint(List<LatLong> listLatLong)

        {

            if (listLatLong == null || listLatLong.Count == 0)

                throw new ArgumentException("List cannot be null or empty.");


            double averageLatitude = listLatLong.Average(x => x.Latitude);

            double averageLongitude = listLatLong.Average(x => x.Longitude);


            return new LatLong(averageLatitude, averageLongitude);

        }


        public IActionResult Index()
        {

            List<Coordinate> coordinates = new List<Coordinate>
            {
                 new Coordinate{ Latitude =35.585548,  Longitude =51.363681},
                 new Coordinate{ Latitude =35.585579,  Longitude =51.363925},
                 new Coordinate{ Latitude =35.585468,  Longitude =51.363846},
                 new Coordinate{ Latitude =35.585501,  Longitude =51.363637},
                 new Coordinate{ Latitude =35.585577,  Longitude = 51.363683},
                 new Coordinate { Latitude = 35.585616,Longitude = 51.363436},
                 new Coordinate { Latitude = 35.585614,Longitude = 51.363508},

            };


           var t = coordinates.Select(c => new Coordinate {
            Latitude = Math.Round(c.Latitude, 4),
            Longitude = Math.Round(c.Longitude, 4)

            }).GroupBy(c=> new {c.Latitude,c.Longitude }) .ToList();

            //List<LatLong> coordinates = new List<LatLong>
            //{
            //     new LatLong(35.585548,51.363681),
            //     new LatLong(35.585579,51.363925),
            //     new LatLong(35.585468,51.363846),
            //     new LatLong(35.585501,51.363637),
            //     new LatLong( 35.585577, 51.363683),
            //     new LatLong (35.585616, 51.363436),
            //     new LatLong (35.585614, 51.363508),

            //};


            //var centerPoint = GetCenterPoint(coordinates);

            //        List<Coordinate> coordinates = new List<Coordinate>
            //    {
            //          new Coordinate{ Latitude =35.585630, Longitude =51.362226},
            //     new Coordinate{ Latitude =35.586049, Longitude =51.361099},
            //     new Coordinate { Latitude = 35.586154, Longitude = 51.362311 },

            //    };


            //    List<LatLong> listLatLong = new List<LatLong>

            //{

            //    new LatLong(35.585630, 51.362226),

            //    new LatLong(35.586049, 51.361099),

            //    new LatLong(35.586154, 51.362311)

            //};
            //    var centerPoint = GetCenterPoint(listLatLong);

            //    double radius2 = GetRadiusByListLatLong(new List<LatLong> { centerPoint });

            //    double radius = GetRadiusByListLatLong(coordinates);

            //    double value = 3.14159265359;

            //    int decimalPlaces = 2;

            //    double roundedValue = Math.Round(radius, decimalPlaces);
            //    double roundedValue2 = Math.Round(value, decimalPlaces);

            //    Console.WriteLine($"The radius is: {radius} km");


















            //var rand = new Random();

            //for (int i = 1188; i < 2000; i++)
            //{
            //    //Create Vehicle
            //    var vehicle = new Vehicle()
            //    {
            //        CarName = "ماشین-" + i.ToString(),
            //        Identity = "Id" + rand.Next(9999).ToString(),
            //        Imei = rand.Next(9999999).ToString(),
            //        UnitId = i+2,

            //    };

            //    _context.Add(vehicle);
            //    _context.SaveChanges();

            //    //Create Tracking

            //    var trackingList = new List<Tracking>();

            //    for(int j = 0; j < 5; j++)
            //    {
            //        double.TryParse($"29.587{rand.Next(999)}", out double latitude);
            //        double.TryParse($"52.518521{rand.Next(999)}", out double longitude);

            //        var tracking = new Tracking()
            //        {
            //            Imei = vehicle.Imei,
            //            Latitude = latitude,
            //            Longitude = longitude,
            //            Speed = rand.Next(0, 30),
            //            VehicleId = vehicle.Id
            //        };

            //        _context.Add(tracking);
            //        _context.SaveChanges();

            //        trackingList.Add(tracking);
            //    }

            //    //Create VehicleTracking

            //    var lastTracking = trackingList.OrderByDescending(c => c.InsertDate).FirstOrDefault()!;

            //    var vehicleTracking = new VehicleTracking()
            //    {
            //        LastConnectionTime = lastTracking.InsertDate,
            //        LastTrackingTime= lastTracking.InsertDate,
            //        Latitude = lastTracking.Latitude,
            //        Longitude= lastTracking.Longitude,
            //        VehicleId= vehicle.Id
            //    };
            //    _context.Add(vehicleTracking);
            //    _context.SaveChanges();
            //}

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}