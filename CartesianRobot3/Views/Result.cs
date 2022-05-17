using System.Text;
using CartesianRobot3.Models;
using static System.Console;

namespace CartesianRobot3.Views;

public static class Result
{
    public static void CleaningSuccessful(PositionHistory posHistory)
    {
        WriteLine("Cleaning successful!\n");
        WriteLine("All Positions Cleaned:");
        var sb = new StringBuilder();

        foreach (var i in posHistory.AllPositionsCleaned)
        {
            sb.Append(i.X + "," + i.Y + ";");
        }

        sb.Length--;
        WriteLine(sb);


        sb.Clear();
        WriteLine("\n");
        WriteLine("Unique Positions Cleaned:");
        foreach (var i in posHistory.UniquePositionsCleaned)
        {
            sb.Append(i.X + "," + i.Y + ";");
        }

        sb.Length--;
        WriteLine(sb);
    }

    public static void CleaningAborted(List<Position> posHistory)
    {
        WriteLine("Cleaning Aborted!\n");
        WriteLine("All Positions traveled so far:");
        var cleaned = posHistory.Take(posHistory.Count - 1);
        var sb = new StringBuilder();
        foreach (var i in cleaned)
        {
            sb.Append(i.X + "," + i.Y + ";");
        }

        sb.Length--;
        WriteLine(sb);
    }
}