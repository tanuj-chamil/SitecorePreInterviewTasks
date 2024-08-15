using SitecorePreInterviewTasks.Task01;

namespace SitecorePreInterviewTasks.UnitTests.Task01
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Move_ShouldMoveCircleByGivenCoordinates()
        {
            // Arrange
            var circle = new SitecorePreInterviewTasks.Task01.Circle(new Point(1, 1), 1);

            // Act
            circle.Move(2, 3);

            // Assert
            Assert.AreEqual(3, circle.Center.X);
            Assert.AreEqual(4, circle.Center.Y);
        }

        [TestMethod]
        public void Move_ShouldMoveCircleByGivenPoint()
        {
            // Arrange
            var circle = new SitecorePreInterviewTasks.Task01.Circle(new Point(1, 1), 1);
            var movePoint = new Point(2, 3);

            // Act
            circle.Move(movePoint);

            // Assert
            Assert.AreEqual(3, circle.Center.X);
            Assert.AreEqual(4, circle.Center.Y);
        }

        [TestMethod]
        public void Rotate_ShouldRotateCircleByGivenAngle()
        {
            // Arrange
            var circle = new SitecorePreInterviewTasks.Task01.Circle(new Point(1, 1), 1);

            // Act
            circle.Rotate(Math.PI / 2);

            // Assert
            Assert.AreEqual(-1, circle.Center.X, 0.0001);
            Assert.AreEqual(1, circle.Center.Y, 0.0001);
        }

        [TestMethod]
        public void Rotate_ShouldRotateCircleByGivenAngle_DoublePrecision()
        {
            // Arrange
            var circle = new SitecorePreInterviewTasks.Task01.Circle(new Point(1.0, 1.0), 1);

            // Act
            circle.Rotate(Math.PI / 4);

            // Assert
            Assert.AreEqual(0, circle.Center.X, 0.0001);
            Assert.AreEqual(1.4142, circle.Center.Y, 0.0001);
        }

    }
}
