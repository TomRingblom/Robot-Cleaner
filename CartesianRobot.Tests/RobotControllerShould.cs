using System;
using System.Collections.Generic;
using CartesianRobot3.Controllers;
using CartesianRobot3.Models;
using Xunit;

namespace CartesianRobot.Tests;

public class RobotControllerShould
{
    [Fact]
    public void RobotMove_Should_Return_Correct_Y()
    {
        // Arrange
        var sut = new RobotController();
        double x = 1;
        double y = 1;
        double moves = 3;
        Enum point = RobotController.Directions.North;
        var map = new Map(-10, 10, -10, 10);
        var pos0 = new Position(x, y);
        var list = new List<Position>
        {
            pos0
        };

        // Act
        var actual = sut.RobotMove(x, y, moves, point, map, list);

        // Assert
        Assert.Equal(4, actual[3].Y);
    }
    [Fact]
    public void RobotMove_Should_Return_Correct_X()
    {
        // Arrange
        var sut = new RobotController();
        double x = 1;
        double y = 1;
        double moves = 3;
        Enum point = RobotController.Directions.East;
        var map = new Map(-10, 10, -10, 10);
        var pos0 = new Position(x, y);
        var list = new List<Position>
        {
            pos0
        };

        // Act
        var actual = sut.RobotMove(x, y, moves, point, map, list);

        // Assert
        Assert.Equal(4, actual[3].X);
    }
}