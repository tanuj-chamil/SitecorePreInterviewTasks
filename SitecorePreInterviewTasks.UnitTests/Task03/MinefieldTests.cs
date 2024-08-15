using SitecorePreInterviewTasks.Task01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecorePreInterviewTasks.UnitTests.Task03
{
    [TestClass]
    public class MinefieldTests
    {
        [TestMethod]
        public void SearchOne_FindsSinglePath_Correctly()
        {
            // Arrange
            int rows = 10;
            int cols = 10;
            int[,] grid = new int[rows, cols];
            Point start = new Point(0, 0);
            Point end = new Point(rows - 1, cols - 1);

            // Create a grid with a path
            int[,] gridWithPath = GridGenerator.GenerateGridWithPath(grid, start, end, 1);

            var directions = new List<Point>
            {
                new Point(0, 1), // Right
                new Point(1, 0), // Down
                new Point(0, -1), // Left
                new Point(-1, 0), // Up
                new Point(1, 1), // Down-right diagonal
                new Point(1, -1), // Down-left diagonal
                new Point(-1, 1), // Up-right diagonal
                new Point(-1, -1) // Up-left diagonal
            };

            var traverser = new Traverser(directions, start);
            var minefield = new Minefield(gridWithPath, traverser, start, end);

            // Act
            minefield.SearchOne();
            var foundPath = minefield.GetFoundPath();

            // Assert
            Assert.IsNotNull(foundPath, "Path should be found.");
            Assert.IsTrue(foundPath.Count > 0, "Path length should be greater than 0.");
            Assert.AreEqual(start, foundPath[0], "Path should start at the start point.");
            Assert.AreEqual(end, foundPath[foundPath.Count - 1], "Path should end at the end point.");
        }

        [TestMethod]
        public void SearchOne_NoPathExists_ReturnsNull()
        {
            // Arrange
            int rows = 10;
            int cols = 10;
            int[,] grid = new int[rows, cols];
            Point start = new Point(0, 0);
            Point end = new Point(rows - 1, cols - 1);

            // Initialize grid with no path by blocking it
            // For instance, making the entire grid have 0s will block the path
            var gridWithNoPath = new int[rows, cols];

            var directions = new List<Point>
            {
                new Point(0, 1), // Right
                new Point(1, 0), // Down
                new Point(0, -1), // Left
                new Point(-1, 0), // Up
                new Point(1, 1), // Down-right diagonal
                new Point(1, -1), // Down-left diagonal
                new Point(-1, 1), // Up-right diagonal
                new Point(-1, -1) // Up-left diagonal
            };

            var traverser = new Traverser(directions, start);
            var minefield = new Minefield(gridWithNoPath, traverser, start, end);

            // Act
            minefield.SearchOne();
            var foundPath = minefield.GetFoundPath();

            // Assert
            Assert.IsNull(foundPath, "Path should be null when no path exists.");
        }

        [TestMethod]
        public void SearchOne_SingleCellGrid_PathFound()
        {
            // Arrange
            int rows = 1;
            int cols = 1;
            int[,] grid = new int[rows, cols];
            Point start = new Point(0, 0);
            Point end = new Point(0, 0);

            var directions = new List<Point>(); // No directions needed in a single cell grid

            var traverser = new Traverser(directions, start);
            var minefield = new Minefield(grid, traverser, start, end);

            // Act
            minefield.SearchOne();
            var foundPath = minefield.GetFoundPath();

            // Assert
            Assert.IsNotNull(foundPath, "Path should be found.");
            Assert.AreEqual(start, foundPath[0], "Path should be the single cell.");
        }
        [TestMethod]
        public void SearchAll_FindsAllPaths_Correctly()
        {
            // Arrange
            int rows = 10;
            int cols = 10;
            int[,] grid = new int[rows, cols];
            Point start = new Point(0, 0);
            Point end = new Point(rows - 1, cols - 1);

            // Create a grid with multiple paths
            int[,] gridWithPaths = GridGenerator.GenerateGridWithPath(grid, start, end, 2);

            var directions = new List<Point>
            {
                new Point(0, 1), // Right
                new Point(1, 0), // Down
                new Point(0, -1), // Left
                new Point(-1, 0), // Up
                new Point(1, 1), // Down-right diagonal
                new Point(1, -1), // Down-left diagonal
                new Point(-1, 1), // Up-right diagonal
                new Point(-1, -1) // Up-left diagonal
            };

            var traverser = new Traverser(directions, start);
            var minefield = new Minefield(gridWithPaths, traverser, start, end);

            // Act
            minefield.SearchAll();
            var allPaths = minefield.GetAllPaths();

            // Assert
            Assert.IsNotNull(allPaths, "Paths should be found.");
            Assert.IsTrue(allPaths.Count > 0, "Number of paths should be greater than 0.");

            foreach (var path in allPaths)
            {
                Assert.IsTrue(path.Count > 0, "Path length should be greater than 0.");
                Assert.AreEqual(start, path[0], "Path should start at the start point.");
                Assert.AreEqual(end, path[path.Count - 1], "Path should end at the end point.");
            }
        }

        [TestMethod]
        public void SearchOneWithoutPrevious_FindsSinglePath_Correctly()
        {
            // Arrange
            int rows = 10;
            int cols = 10;
            int[,] grid = new int[rows, cols];
            Point start = new Point(0, 0);
            Point end = new Point(rows - 1, cols - 1);

            // Create a grid with a path
            int[,] gridWithPath = GridGenerator.GenerateGridWithPath(grid, start, end, 1);

            var directions = new List<Point>
            {
                new Point(0, 1), // Right
                new Point(1, 0), // Down
                new Point(0, -1), // Left
                new Point(-1, 0), // Up
                new Point(1, 1), // Down-right diagonal
                new Point(1, -1), // Down-left diagonal
                new Point(-1, 1), // Up-right diagonal
                new Point(-1, -1) // Up-left diagonal
            };

            var traverser = new Traverser(directions, start);
            var minefield = new Minefield(gridWithPath, traverser, start, end);

            // Act
            minefield.SearchOneWithoutPrevious();
            var foundPath = minefield.GetFoundPath();

            // Assert
            Assert.IsNotNull(foundPath, "Path should be found.");
            Assert.IsTrue(foundPath.Count > 0, "Path length should be greater than 0.");
            Assert.AreEqual(start, foundPath[0], "Path should start at the start point.");
            Assert.AreEqual(end, foundPath[foundPath.Count - 1], "Path should end at the end point.");
        }

        [TestMethod]
        public void SearchAllWithoutPrevious_FindsAllPaths_Correctly()
        {
            // Arrange
            int rows = 10;
            int cols = 10;
            int[,] grid = new int[rows, cols];
            Point start = new Point(0, 0);
            Point end = new Point(rows - 1, cols - 1);

            // Create a grid with multiple paths
            int[,] gridWithPaths = GridGenerator.GenerateGridWithPath(grid, start, end, 2);

            var directions = new List<Point>
            {
                new Point(0, 1), // Right
                new Point(1, 0), // Down
                new Point(0, -1), // Left
                new Point(-1, 0), // Up
                new Point(1, 1), // Down-right diagonal
                new Point(1, -1), // Down-left diagonal
                new Point(-1, 1), // Up-right diagonal
                new Point(-1, -1) // Up-left diagonal
            };

            var traverser = new Traverser(directions, start);
            var minefield = new Minefield(gridWithPaths, traverser, start, end);

            // Act
            minefield.SearchAllWithoutPrevious();
            var allPaths = minefield.GetAllPaths();

            // Assert
            Assert.IsNotNull(allPaths, "Paths should be found.");
            Assert.IsTrue(allPaths.Count > 0, "Number of paths should be greater than 0.");

            foreach (var path in allPaths)
            {
                Assert.IsTrue(path.Count > 0, "Path length should be greater than 0.");
                Assert.AreEqual(start, path[0], "Path should start at the start point.");
                Assert.AreEqual(end, path[path.Count - 1], "Path should end at the end point.");
            }

        }
        [TestMethod]
        public void SearchAllWithoutPrevious_NoBacktracking()
        {
            // Arrange
            int rows = 10;
            int cols = 10;
            int[,] grid = new int[rows, cols];
            Point start = new Point(0, 0);
            Point end = new Point(rows - 1, cols - 1);

            // Create a grid with multiple paths
            int[,] gridWithPaths = GridGenerator.GenerateGridWithPath(grid, start, end, 2);

            var directions = new List<Point>
            {
                new Point(0, 1), // Right
                new Point(1, 0), // Down
                new Point(0, -1), // Left
                new Point(-1, 0), // Up
                new Point(1, 1), // Down-right diagonal
                new Point(1, -1), // Down-left diagonal
                new Point(-1, 1), // Up-right diagonal
                new Point(-1, -1) // Up-left diagonal
            };

            var traverser = new Traverser(directions, start);
            var minefield = new Minefield(gridWithPaths, traverser, start, end);

            // Act
            minefield.SearchAllWithoutPrevious();
            var allPaths = minefield.GetAllPaths();

            // Assert
            Assert.IsNotNull(allPaths, "Paths should be found.");
            Assert.IsTrue(allPaths.Count > 0, "Number of paths should be greater than 0.");

            foreach (var path in allPaths)
            {
                Assert.IsTrue(path.Count > 0, "Path length should be greater than 0.");
                Assert.AreEqual(start, path[0], "Path should start at the start point.");
                Assert.AreEqual(end, path[path.Count - 1], "Path should end at the end point.");

                // Check for backtracking
                for (int i = 0; i < path.Count - 2; i++)
                {
                    Assert.AreNotEqual(path[i], path[i + 2], "Path should not backtrack.");
                }
            }
        }
    } 
    }

    internal static class GridGenerator
    {
        private static Random random = new Random();

        public static int[,] GenerateGridWithPath(int[,] grid, Point start, Point end, int numPaths)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            int[,] gridData = (int[,])grid.Clone();

            // Set start and end points
            gridData[(int)start.X, (int)start.Y] = 1;
            gridData[(int)end.X, (int)end.Y] = 1;

            for (int i = 0; i < numPaths; i++)
            {
                Point current = start;

                while (!current.Equals(end))
                {
                    List<Point> directions = new List<Point>();
                    Point direction = end - current;

                    if (direction.X > 0)
                        directions.Add(new Point(1, 0));
                    if (direction.X < 0)
                        directions.Add(new Point(-1, 0));
                    if (direction.Y > 0)
                        directions.Add(new Point(0, 1));
                    if (direction.Y < 0)
                        directions.Add(new Point(0, -1));

                    // Add diagonal directions if applicable
                    if (directions.Count == 2)
                    {
                        directions.Add(directions[0] + directions[1]);
                    }

                    if (directions.Count == 0)
                        break;

                    Point chosenDirection = directions[random.Next(directions.Count)];
                    Point newPosition = current + chosenDirection;

                    if (IsInBounds(newPosition, rows, cols))
                    {
                        current = newPosition;
                        gridData[(int)current.X, (int)current.Y] = 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return gridData;
        }

        private static bool IsInBounds(Point point, int rows, int cols)
        {
            return point.X >= 0 && point.X < rows && point.Y >= 0 && point.Y < cols;
        }
    }
