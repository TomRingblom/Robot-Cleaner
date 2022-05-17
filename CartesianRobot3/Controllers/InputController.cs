using CartesianRobot3.Views;

namespace CartesianRobot3.Controllers;

public class InputController
{
    public string InputCheck(string input)
    {
        var semicolons = input.Count(x => x == ';');
        var bracket1 = input.Count(x => x == '[');
        var bracket2 = input.Count(x => x == ']');
        var brackets = bracket1 + bracket2;
        var mapCheck = input.Contains("M:");
        var startCheck = input.Contains("S:");

        if (semicolons != 2)
        {
            Errors.NotTwoSemicolons();
            return null!;
        }
        else if (brackets != 2)
        {
            Errors.NotTwoBrackets();
            return null!;
        }
        else if (!mapCheck)
        {
            Errors.NotContainMColon();
            return null!;
        }
        else if (!startCheck)
        {
            Errors.NotContainSColon();
            return null!;
        }
        else
            return input;
    }

    public string[] InputSort(string input)
    {
        try
        {
            string[] map = new string[1];
            string[] start = new string[1];
            string[] routes = new string[1];
            string[] inputs = input.Split(";");

            foreach (var i in inputs)
            {
                if (i.Contains("S:"))
                    start[0] = i;
                else if (i.Contains("M:"))
                    map[0] = i;
                else
                    routes[0] = i;
            }

            if (map[0] == "" || start[0] == "" || routes[0] == "")
                return null!;

            return new[] { map[0], start[0], routes[0] };
        }
        catch
        {
            return null!;
        }
    }
}