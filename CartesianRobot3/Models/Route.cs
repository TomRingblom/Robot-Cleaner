namespace CartesianRobot3.Models;

public class Route
{
    public string[] Directions { get; set; } = null!;

    public Route(string[] directions)
    {
        Directions = directions;
    }
}