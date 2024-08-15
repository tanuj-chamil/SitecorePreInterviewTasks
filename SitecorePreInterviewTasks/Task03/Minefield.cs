using System.Collections.Generic;

namespace SitecorePreInterviewTasks.Task01
{
    public class Minefield(int[,] gridData, Traverser traverser, Point start, Point end)
    {
        private readonly int[,] gridData = gridData;
        private readonly int n = gridData.GetLength(0);
        private readonly int m = gridData.GetLength(1);
        private readonly Traverser traverser = traverser;
        private readonly Point start = start;
        private readonly Point end = end;
        private readonly HashSet<Point> visited = new HashSet<Point>();
        private readonly List<Point> currentPath = new List<Point>();
        private List<Point>? foundPath = null;
        private List<List<Point>> allPaths = new List<List<Point>>();

        private bool IsInBounds(Point point)
        {
            return point.X >= 0 && point.X < n && point.Y >= 0 && point.Y < m;
        }

        /// <summary>
        /// Sniffer Pup searches a path to navigate minefield alone 
        /// </summary>
        public void SearchOne()
        {
            if (start.Equals(end))
            {
                foundPath = new List<Point> { start };
                return;
            }

            foundPath = null;
            visited.Clear();
            currentPath.Clear();
            SearchOne(start);
        }

        public void SearchOne(Point position)
        {
            if (foundPath != null || !IsInBounds(position) || gridData[(int)position.X, (int)position.Y] == 0 || visited.Contains(position))
                return;

            if (position.Equals(end))
            {
                foundPath = new List<Point>(currentPath) { position };
                return;
            }

            visited.Add(position);
            currentPath.Add(position);

            foreach (Point direction in traverser.Directions)
            {
                Point newPosition = position + direction;
                SearchOne(newPosition);
                if (foundPath != null) return;
            }

            currentPath.RemoveAt(currentPath.Count - 1);
            visited.Remove(position);
        }

        public List<Point>? GetFoundPath()
        {
            return foundPath;
        }

        /// <summary>
        /// Sniffer Pup searches for all path to navigate minefield alone 
        /// </summary>
        public void SearchAll()
        {
            allPaths.Clear();
            visited.Clear();
            currentPath.Clear();
            SearchAll(start);
        }

        public void SearchAll(Point position)
        {
            if (!IsInBounds(position) || gridData[(int)position.X, (int)position.Y] == 0 || visited.Contains(position))
                return;

            if (position.Equals(end))
            {
                allPaths.Add(new List<Point>(currentPath) { position });
                return;
            }

            visited.Add(position);
            currentPath.Add(position);

            foreach (Point direction in traverser.Directions)
            {
                Point newPosition = position + direction;
                SearchAll(newPosition);
            }

            currentPath.RemoveAt(currentPath.Count - 1);
            visited.Remove(position);
        }

        /// <summary>
        /// Sniffer Puppy searches a path to navigate minefield with Ally
        /// </summary>
        public void SearchOneWithoutPrevious()
        {
            if (start.Equals(end))
            {
                foundPath = new List<Point> { start };
                return;
            }

            foundPath = null;
            visited.Clear();
            currentPath.Clear();
            SearchOneWithoutPrevious(start, null); // Pass 'null' as the previous point for the start
        }

        public void SearchOneWithoutPrevious(Point position, Point? previous)
        {
            if (foundPath != null || !IsInBounds(position) || gridData[(int)position.X, (int)position.Y] == 0 || visited.Contains(position))
                return;

            if (position.Equals(end))
            {
                foundPath = new List<Point>(currentPath) { position };
                return;
            }

            visited.Add(position);
            currentPath.Add(position);

            foreach (Point direction in traverser.Directions)
            {
                Point newPosition = position + direction;
                if (!newPosition.Equals(previous)) // Ensure not to revisit the previous position
                {
                    SearchOneWithoutPrevious(newPosition, position);
                    if (foundPath != null) return;
                }
            }

            currentPath.RemoveAt(currentPath.Count - 1);
            visited.Remove(position);
        }

        /// <summary>
        /// Sniffer Puppy searches for all path to navigate minefield with Ally
        /// </summary>
        public void SearchAllWithoutPrevious()
        {
            allPaths.Clear();
            visited.Clear();
            currentPath.Clear();
            SearchAll(start, null); // Pass 'null' as the previous point for the start
        }

        public void SearchAll(Point position, Point? previous)
        {
            if (!IsInBounds(position) || gridData[(int)position.X, (int)position.Y] == 0 || visited.Contains(position))
                return;

            if (position.Equals(end))
            {
                allPaths.Add(new List<Point>(currentPath) { position });
                return;
            }

            visited.Add(position);
            currentPath.Add(position);

            foreach (Point direction in traverser.Directions)
            {
                Point newPosition = position + direction;
                if (!newPosition.Equals(previous)) // Ensure not to revisit the previous position
                {
                    SearchAll(newPosition, position);
                }
            }

            currentPath.RemoveAt(currentPath.Count - 1);
            visited.Remove(position);
        }

        public List<List<Point>> GetAllPaths()
        {
            return allPaths;
        }
    }
}
