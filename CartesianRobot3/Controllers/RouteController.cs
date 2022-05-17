using CartesianRobot3.Models;

namespace CartesianRobot3.Controllers;

public class RouteController
{
    public Route RouteInputControl(string routes)
    {
        try
        {
            string removeFirst = routes.Substring(1);
            string removeLast = removeFirst.Remove(removeFirst.Length - 1);
            string[] allRoutes = removeLast.Split(",");
            char[] values = new[] { 'N', 'E', 'S', 'W' };

            foreach (string route in allRoutes)
            {
                var check = values.Any(c => c == route[0]);
                if (check)
                {
                    double.Parse(route.Substring(1));
                    continue;
                }
                throw new Exception("Routes can only start with N,E,S or W");
            }

            return new Route(allRoutes);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }
}