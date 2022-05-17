namespace CartesianRobot3.Models;

public class Map
{
    public double MinX { get; set; }
    public double MaxX { get; set; }
    public double MinY { get; set; }
    public double MaxY { get; set; }

    public Map(double minX, double maxX, double minY, double maxY)
    {
        MinX = minX;
        MaxX = maxX;
        MinY = minY;
        MaxY = maxY;
    }
}