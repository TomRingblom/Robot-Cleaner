using CartesianRobot3.Controllers;
using Xunit;

namespace CartesianRobot.Tests;

public class PositionControllerShould
{
    [Fact]
    public void StartInputControl_Should_Return_StartingX_0()
    {
        // Arrange
        var sut = new PositionController();

        // Act
        var actual = sut.StartInputControl("S:0,0");

        // Assert
        Assert.Equal(0, actual.StartingX);
    }

    [Fact]
    public void StartInputControl_Should_Return_StartingY_5()
    {
        // Arrange
        var sut = new PositionController();

        // Act
        var actual = sut.StartInputControl("S:0,5");

        // Assert
        Assert.Equal(5, actual.StartingY);
    }
}