namespace CartesianRobot3.Models;

public class StartingPosition
{
    public double StartingX { get; set; }
    public double StartingY { get; set; }

    public StartingPosition(double startingX, double startingY)
    {
        StartingX = startingX;
        StartingY = startingY;
    }
}