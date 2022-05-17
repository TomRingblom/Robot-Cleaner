namespace CartesianRobot3.Views;

public static class InputErrors
{
    public static void TryAgain(string input)
    {
        Console.WriteLine("Your last input: {0}", input);
        Console.WriteLine("Please try again.");
    }
}