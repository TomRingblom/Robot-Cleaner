namespace CartesianRobot3.Views;

public static class Welcome
{
    public static void WelcomeText()
    {
        Console.WriteLine("Welcome to the Robot Cleaner");
        Console.WriteLine();
        Console.WriteLine("To configure the robot please enter map, starting position and it's intended route.");
        Console.WriteLine("The instructions must contain a map M: followed by 4 numbers (MinX, MaxX, MinY, MaxY) separated by commas.");
        Console.WriteLine("The instructions must contain a starting position S: followed by 2 numbers (StartX, StartY) separated by commas.");
        Console.WriteLine("The instructions must contain routes in brackets ([]) put direction (N,E,S,W) plus length separated by commas.");
        Console.WriteLine("Each instruction part must be separated with semicolons, please look at the example below.");
        Console.WriteLine("NOTE! The order is not important.");
        Console.WriteLine("Example: M:-10,10,-10,10;S:-5,5;[W5,E5,N4,E3,S2,W1]");
        Console.WriteLine("Enter the instructions and press enter to start");
        Console.WriteLine();
    }
}