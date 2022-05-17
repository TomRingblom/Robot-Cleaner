using CartesianRobot3.Controllers;
using CartesianRobot3.Models;
using Xunit;

namespace CartesianRobot.Tests;

public class InputControllerShould
{
    [Fact]
    public void InputCheck_Should_Return_Null()
    {
        // Arrange
        var sut = new InputController();

        // Act
        var actual = sut.InputCheck("M:-10,10,-10,10;S:-5,5;W5,E5,N4,E3,S2,W1]");

        // Assert
        Assert.Equal(null!, actual);
    }
}