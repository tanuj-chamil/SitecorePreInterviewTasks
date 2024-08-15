using SitecorePreInterviewTasks.Task01;

namespace SitecorePreInterviewTasks.UnitTests.Task01
{
    [TestClass]
    public class LineTests
    {
        [TestMethod]
        public void Move_ShouldMoveLineByGivenCoordinates()
        {
            // Arrange
            var start = new Point(1, 1);
            var end = new Point(2, 2);
            var line = new Line(start, end);

            // Act
            line.Move(2, 3);

            // Assert
            Assert.AreEqual(3, line.Start.X);
            Assert.AreEqual(4, line.Start.Y);
            Assert.AreEqual(4, line.End.X);
            Assert.AreEqual(5, line.End.Y);
        }

        [TestMethod]
        public void Move_ShouldMoveLineByGivenPoint()
        {
            // Arrange
            var start = new Point(1, 1);
            var end = new Point(2, 2);
            var line = new Line(start, end);
            var movePoint = new Point(2, 3);

            // Act
            line.Move(movePoint);

            // Assert
            Assert.AreEqual(3, line.Start.X);
            Assert.AreEqual(4, line.Start.Y);
            Assert.AreEqual(4, line.End.X);
            Assert.AreEqual(5, line.End.Y);
        }

        [TestMethod]
        public void Rotate_ShouldRotateLineByGivenAngle()
        {
            // Arrange
            var start = new Point(1, 1);
            var end = new Point(2, 2);
            var line = new Line(start, end);

            // Act
            line.Rotate(Math.PI / 2);

            // Assert
            Assert.AreEqual(-1, line.Start.X, 0.0001);
            Assert.AreEqual(1, line.Start.Y, 0.0001);
            Assert.AreEqual(-2, line.End.X, 0.0001);
            Assert.AreEqual(2, line.End.Y, 0.0001);
        }


        [TestMethod]
        public void Rotate_ShouldRotateLineByGivenAngle_DoublePrecision()
        {
            // Arrange
            var start = new Point(1.0, 1.0);
            var end = new Point(2.0, 2.0);
            var line = new Line(start, end);

            // Act
            line.Rotate(Math.PI / 4);

            // Assert
            Assert.AreEqual(0.0, line.Start.X, 0.001);
            Assert.AreEqual(1.414, line.Start.Y, 0.001);
            Assert.AreEqual(0, line.End.X, 0.001);
            Assert.AreEqual(2.828, line.End.Y, 0.001);
        }


    }
}
