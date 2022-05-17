using CartesianRobot3.Models;
using CartesianRobot3.Views;

namespace CartesianRobot3.Controllers;

public class RobotController
{
    private bool _isInsideMap = true;

    public void SetIsInsideMap(bool set)
    {
        _isInsideMap = set;
    }
    public enum Directions
    {
        North, East, South, West
    }

    public void RobotStart(Map map, StartingPosition starPos, Route route)
    {
        var posHistories = new PositionHistory();
        var current = new CurrentPosition{ CurrentX = starPos.StartingX, CurrentY = starPos.StartingY };
        var positions = new List<Position>{ new Position( starPos.StartingX, starPos.StartingY)};

        foreach (var i in route.Directions)
        {
            var moves = int.Parse(i.Remove(0, 1));
            if (!_isInsideMap)
                break;

            switch (i[0])
            {
                case 'N':
                    positions = RobotMove(current.CurrentX, current.CurrentY, moves, Directions.North, map, positions);
                    current.CurrentY += moves;
                    break;
                case 'S':
                    positions = RobotMove(current.CurrentX, current.CurrentY, moves, Directions.South, map, positions);
                    current.CurrentY -= moves;
                    break;
                case 'E':
                    positions = RobotMove(current.CurrentX, current.CurrentY, moves, Directions.East, map, positions);
                    current.CurrentX += moves;
                    break;
                case 'W':
                    positions = RobotMove(current.CurrentX, current.CurrentY, moves, Directions.West, map, positions);
                    current.CurrentX -= moves;
                    break;
            }
        }

        var uniquePositions = positions.GroupBy(p => new { p.X, p.Y }).Select(g => g.First()).ToList();
        posHistories.AllPositionsCleaned = positions;
        posHistories.UniquePositionsCleaned = uniquePositions;
        
        if (_isInsideMap)
            Result.CleaningSuccessful(posHistories);
        else
            Result.CleaningAborted(positions);
    }

    public List<Position> RobotMove(double x, double y, double moves, Enum point, Map map, List<Position> positions)
    {
        try
        {
            for (int j = 1; j <= moves; j++)
            {
                switch (point)
                {
                    case Directions.North:
                        positions.Add(new Position(x, y + j));
                        if (map.MaxY < (y + j))
                            throw new Exception($"{x},{y + j}");
                        break;
                    case Directions.South:
                        positions.Add(new Position(x, y - j));
                        if (map.MinY > (y - j))
                            throw new Exception($"{x},{y - j}");
                        break;
                    case Directions.East:
                        positions.Add(new Position(x + j, y));
                        if (map.MaxX < (x + j))
                            throw new Exception($"{x + j},{y}");
                        break;
                    case Directions.West:
                        positions.Add(new Position(x - j, y));
                        if (map.MinX > (x - j)) 
                            throw new Exception($"{x - j},{y}");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Errors.OutsideMap(ex);
            SetIsInsideMap(false);
        }

        return positions;
    }
}