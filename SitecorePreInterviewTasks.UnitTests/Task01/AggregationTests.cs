using SitecorePreInterviewTasks.Task01;

namespace SitecorePreInterviewTasks.UnitTests.Task01
{
    [TestClass]
    public class AggregationTests
    {

        [TestMethod]
        public void Add_ShouldAddObjectToList()
        {
            // Arrange
            var aggregation = new Aggregation();
            var point = new Point(1, 1);

            // Act
            aggregation.Add(point);

            // Assert
            Assert.AreEqual(1, aggregation.Count());
        }

        [TestMethod]
        public void Remove_ShouldRemoveObjectToList() {
            // Arrange
            var aggregation = new Aggregation();
            var point = new Point(1, 1);
            aggregation.Add(point);

            // Act
            aggregation.Remove(point);

            // Assert
            Assert.AreEqual(0, aggregation.Count());
        }

        [TestMethod]
        public void Clear_ShouldClearList()
        {
            // Arrange
            var aggregation = new Aggregation();
            var point = new Point(1, 1);
            aggregation.Add(point);

            // Act
            aggregation.Clear();

            // Assert
            Assert.AreEqual(0, aggregation.Count());
        }

        [TestMethod]
        public void Move_ShouldMoveObjectsByGivenCoordinates()
        {
            // Arrange
            var aggregation = new Aggregation();
            var point = new Point(1, 1);
            var line = new Line(new Point(1, 1), new Point(2, 2));
            var circle = new Circle(new Point(1, 1), 1);
            aggregation.Add(point);
            aggregation.Add(line);
            aggregation.Add(circle);

            // Act
            aggregation.Move(2, 3);

            // Assert
            Assert.AreEqual(3, ((Point)aggregation.List[0]).X);
            Assert.AreEqual(4, ((Point)aggregation.List[0]).Y);
            Assert.AreEqual(3, ((Line)aggregation.List[1]).Start.X);
            Assert.AreEqual(4, ((Line)aggregation.List[1]).Start.Y);
            Assert.AreEqual(4, ((Line)aggregation.List[1]).End.X);
            Assert.AreEqual(5, ((Line)aggregation.List[1]).End.Y);
            Assert.AreEqual(3, ((Circle)aggregation.List[2]).Center.X);
            Assert.AreEqual(4, ((Circle)aggregation.List[2]).Center.Y);
        }

        [TestMethod]
        public void Move_ShouldMoveObjectsByGivenPoint()
        {
            // Arrange
            var aggregation = new Aggregation();
            var point = new Point(1, 1);
            var line = new Line(new Point(1, 1), new Point(2, 2));
            var circle = new Circle(new Point(1, 1), 1);
            aggregation.Add(point);
            aggregation.Add(line);
            aggregation.Add(circle);
            var movePoint = new Point(2, 3);

            // Act
            aggregation.Move(movePoint);

            // Assert
            Assert.AreEqual(3, ((Point)aggregation.List[0]).X);
            Assert.AreEqual(4, ((Point)aggregation.List[0]).Y);
            Assert.AreEqual(3, ((Line)aggregation.List[1]).Start.X);
            Assert.AreEqual(4, ((Line)aggregation.List[1]).Start.Y);
            Assert.AreEqual(4, ((Line)aggregation.List[1]).End.X);
            Assert.AreEqual(5, ((Line)aggregation.List[1]).End.Y);
            Assert.AreEqual(3, ((Circle)aggregation.List[2]).Center.X);
            Assert.AreEqual(4, ((Circle)aggregation.List[2]).Center.Y);
        }


        [TestMethod]
        public void Move_ShouldMoveObjectsByGivenCoordinates_DoublePrecision()
        {
            // Arrange
            var aggregation = new Aggregation();
            var point = new Point(1.0, 1.0);
            var line = new Line(new Point(1.0, 1.0), new Point(2.0, 2.0));
            var circle = new Circle(new Point(1.0, 1.0), 1);
            aggregation.Add(point);
            aggregation.Add(line);
            aggregation.Add(circle);

            // Act
            aggregation.Move(2.0, 3.0);

            // Assert
            Assert.AreEqual(3.0, ((Point)aggregation.List[0]).X);
            Assert.AreEqual(4.0, ((Point)aggregation.List[0]).Y);
            Assert.AreEqual(3.0, ((Line)aggregation.List[1]).Start.X);
            Assert.AreEqual(4.0, ((Line)aggregation.List[1]).Start.Y);
            Assert.AreEqual(4.0, ((Line)aggregation.List[1]).End.X);
            Assert.AreEqual(5.0, ((Line)aggregation.List[1]).End.Y);
            Assert.AreEqual(3.0, ((Circle)aggregation.List[2]).Center.X);
            Assert.AreEqual(4.0, ((Circle)aggregation.List[2]).Center.Y);
        }

        [TestMethod]
        public void Rotate_ShouldRotateObjectsByGivenAngle()
        {
            // Arrange
            var aggregation = new Aggregation();
            var point = new Point(1, 1);
            var line = new Line(new Point(1, 1), new Point(2, 2));
            var circle = new Circle(new Point(1, 1), 1);
            aggregation.Add(point);
            aggregation.Add(line);
            aggregation.Add(circle);

            // Act
            aggregation.Rotate(Math.PI / 2);

            // Assert
            Assert.AreEqual(-1, ((Point)aggregation.List[0]).X, 0.0001);
            Assert.AreEqual(1, ((Point)aggregation.List[0]).Y, 0.0001);
            Assert.AreEqual(-1, ((Line)aggregation.List[1]).Start.X, 0.0001);
            Assert.AreEqual(1, ((Line)aggregation.List[1]).Start.Y, 0.0001);
            Assert.AreEqual(-2, ((Line)aggregation.List[1]).End.X, 0.0001);
            Assert.AreEqual(2, ((Line)aggregation.List[1]).End.Y, 0.0001);
            Assert.AreEqual(-1, ((Circle)aggregation.List[2]).Center.X, 0.0001);
            Assert.AreEqual(1, ((Circle)aggregation.List[2]).Center.Y, 0.0001);

        }

        [TestMethod]
        public void Rotate_ShouldRotateObjectsByGivenAngle_DoublePrecision()
        {
            // Arrange
            var aggregation = new Aggregation();
            var point = new Point(1.0, 1.0);
            var line = new Line(new Point(1.0, 1.0), new Point(2.0, 2.0));
            var circle = new Circle(new Point(1.0, 1.0), 1);
            aggregation.Add(point);
            aggregation.Add(line);
            aggregation.Add(circle);

            // Act
            aggregation.Rotate(Math.PI / 4);

            // Assert
            Assert.AreEqual(0.0, ((Point)aggregation.List[0]).X, 0.001);
            Assert.AreEqual(1.414, ((Point)aggregation.List[0]).Y, 0.001);
            Assert.AreEqual(0.0, ((Line)aggregation.List[1]).Start.X, 0.001);
            Assert.AreEqual(1.414, ((Line)aggregation.List[1]).Start.Y, 0.001);
            Assert.AreEqual(0, ((Line)aggregation.List[1]).End.X, 0.001);
            Assert.AreEqual(2.828, ((Line)aggregation.List[1]).End.Y, 0.001);
            Assert.AreEqual(0.0, ((Circle)aggregation.List[2]).Center.X, 0.001);
            Assert.AreEqual(1.414, ((Circle)aggregation.List[2]).Center.Y, 0.001);
        }
    }
}
