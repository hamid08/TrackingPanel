namespace TrackingPanel.Controllers;


public static class Haversine
{
    private const double EarthRadius = 6371; // km

    public static double Calculate(Coordinate start, Coordinate end)
    {
        var dLat = ToRadian(end.Latitude - start.Latitude);
        var dLon = ToRadian(end.Longitude - start.Longitude);

        var lat1 = ToRadian(start.Latitude);
        var lat2 = ToRadian(end.Latitude);

        var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return EarthRadius * c; // in km
    }

    private static double ToRadian(double angle)
    {
        return (Math.PI / 180) * angle;
    }


    public static IEnumerable<IGrouping<Coordinate, Coordinate>> GroupByRadius(
    this IEnumerable<Coordinate> coordinates,
    double radius)
    {
        return coordinates
            .SelectMany(c => coordinates.Select(other => new { Coordinate = c, OtherCoordinate = other }))
            .Where(pair => !ReferenceEquals(pair.Coordinate, pair.OtherCoordinate))
            .Where(pair => Haversine.Calculate(pair.Coordinate, pair.OtherCoordinate) <= radius)
            .GroupBy(pair => pair.Coordinate, pair => pair.OtherCoordinate);
    }
}
