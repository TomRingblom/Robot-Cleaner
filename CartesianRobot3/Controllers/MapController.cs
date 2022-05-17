using CartesianRobot3.Models;
using CartesianRobot3.Views;

namespace CartesianRobot3.Controllers;

public class MapController
{
    public Map MapInputControl(string map)
    {
        try
        {
            string remove = map.Substring(2);
            string[] mapArray = remove.Split(",");
            List<double> mapSize2 = new List<double>();

            foreach (var i in mapArray)
                mapSize2.Add(double.Parse(i));

            if (mapSize2.Count != 4)
            {
                MapErrors.NotFourPoints();
                return null!;
            }
            
            return new Map(mapSize2[0], mapSize2[1], mapSize2[2], mapSize2[3]);
        }
        catch
        {
            Console.WriteLine("Something wrong with the input at the map");
            return null!;
        }
    }
}