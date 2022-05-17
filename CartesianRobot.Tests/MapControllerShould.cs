using CartesianRobot3.Controllers;
using CartesianRobot3.Models;
using CartesianRobot3.Views;
using Xunit;

namespace CartesianRobot.Tests
{
    public class MapControllerShould
    {
        [Fact]
        public void MapInputControl_Should_Return_4_Doubles()
        {
            // Arrange
            var sut = new MapController();
            var map = new Map(-10, 10, -10, 10);
            
            // Act
            var actual = sut.MapInputControl("M:-10,10,-10,10");

            // Assert
            Assert.Equal(map.MaxX, actual.MaxX);
            Assert.Equal(map.MaxY, actual.MaxY);
            Assert.Equal(map.MinX, actual.MinY);
            Assert.Equal(map.MinY, actual.MinY);
        }

        [Fact]
        public void MapInputControl_Should_Return_Null()
        {
            // Arrange
            var sut = new MapController();

            // Act
            var actual = sut.MapInputControl("M:-10,10,-10");

            // Assert
            Assert.Equal(null!, actual);
        }
    }
}