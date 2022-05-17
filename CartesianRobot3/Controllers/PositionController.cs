using CartesianRobot3.Models;

namespace CartesianRobot3.Controllers;

public class PositionController
{
    public StartingPosition StartInputControl(string startPosition)
    {
        try
        {
            string removeFirstTwo = startPosition.Substring(2);
            string[] removeCommas = removeFirstTwo.Split(",");
            List<double> startPositions = new List<double>();

            foreach (var i in removeCommas)
                startPositions.Add(double.Parse(i));

            if (startPositions.Count != 2)
                throw new Exception("Something wrong with the input at the starting position");

            return new StartingPosition(startPositions[0], startPositions[1]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }
}