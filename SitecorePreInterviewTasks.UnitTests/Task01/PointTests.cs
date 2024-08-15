using SitecorePreInterviewTasks.Task01;

namespace SitecorePreInterviewTasks.UnitTests.Task01
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void Move_ShouldMovePointByGivenCoordinates()
        {
            // Arrange
            var point = new Point(1, 1);

            // Act
            point.Move(2, 3);

            // Assert
            Assert.AreEqual(3, point.X);
            Assert.AreEqual(4, point.Y);
        }

        [TestMethod]
        public void Move_ShouldMovePointByGivenPoint()
        {
            // Arrange
            var point = new Point(1, 1);
            var movePoint = new Point(2, 3);

            // Act
            point.Move(movePoint);

            // Assert
            Assert.AreEqual(3, point.X);
            Assert.AreEqual(4, point.Y);
        }


        [TestMethod]
        public void Rotate_ShouldRotatePointByGivenAngle()
        {
            // Arrange
            var point = new Point(1, 1);

            // Act
            point.Rotate(Math.PI / 2);

            // Assert
            Assert.AreEqual(-1, point.X, 0.0001);
            Assert.AreEqual(1, point.Y, 0.0001);
        }

        [TestMethod]
        public void Rotate_ShouldRotatePointByGivenAngle_DoublePrecision()
        {
            // Arrange
            var point = new Point(1.0, 1.0);

            // Act
            point.Rotate(Math.PI / 4);

            // Assert
            Assert.AreEqual(0.0, point.X, 0.001);
            Assert.AreEqual(1.414, point.Y, 0.001);
        }

    }
}