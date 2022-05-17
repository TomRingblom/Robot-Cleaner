using CartesianRobot3.Models;
using static System.Console;

namespace CartesianRobot3.Views;

public static class Errors
{
    private static readonly string _message = "The input does not contain";
    private static readonly string _message2 = ", please check your input and compare with the Example.";
    public static void OutsideMap(Exception e)
    {
        WriteLine($"The Robot tried to clean position:({e.Message}) which is outside of the map.");
        WriteLine("The routes does not correlate with the given starting position and the map.");
    }

    public static void NotTwoSemicolons()
    {
        WriteLine($"{_message} two semicolons{_message2}");
    }

    public static void NotTwoBrackets()
    {
        WriteLine($"{_message} two brackets{_message2}");
    }

    public static void NotContainMColon()
    {
        WriteLine($"{_message} (M:){_message2}");
    }
    public static void NotContainSColon()
    {
        WriteLine($"{_message} (S:){_message2}");
    }
}