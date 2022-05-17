using CartesianRobot3.Views;

namespace CartesianRobot3.Controllers;

public static class MenuController
{
    public static void StartMenu()
    {
        Console.Clear();

        var inputController = new InputController();
        var mapController = new MapController();
        var positionController = new PositionController();
        var routeController = new RouteController();
        var robotController = new RobotController();
        bool isInputCorrect = false;

        Welcome.WelcomeText();
        do
        {
            var input = Console.ReadLine();
            var instructions = inputController.InputCheck(input);
            
            if (instructions != null!)
            {
                var sortInstructions = inputController.InputSort(instructions);
                if (sortInstructions == null!)
                    InputErrors.TryAgain(input);
                else
                {
                    var map = mapController.MapInputControl(sortInstructions[0]);
                    var start = positionController.StartInputControl(sortInstructions[1]);
                    var route = routeController.RouteInputControl(sortInstructions[2]);

                    if (map != null! && start != null! && route != null!)
                    {
                        isInputCorrect = true;
                        Console.Clear();
                        robotController.RobotStart(map, start, route);
                    }
                    else
                        InputErrors.TryAgain(input);
                }
            }
            else
                InputErrors.TryAgain(input);   
        } while (!isInputCorrect);
        
        End.Message();
        var choice = Console.ReadLine();
        if (choice.ToLower() == "no")
            Environment.Exit(1);
        else
            StartMenu();

        Console.ReadLine();
    }
}