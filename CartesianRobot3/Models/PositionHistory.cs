namespace CartesianRobot3.Models;

public class PositionHistory
{
    public List<Position> AllPositionsCleaned { get; set; } = null!;
    public List<Position> UniquePositionsCleaned { get; set; } = null!;
}