using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecorePreInterviewTasks.Task01
{
    /// <summary>
    /// Represents a point in 2D space.
    /// </summary>
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Moves the point by the given coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(double x, double y)
        {
            X += x;
            Y += y;
        }

        /// <summary>
        /// Moves the point by the given point.
        /// </summary>
        /// <param name="point"></param>
        public void Move(Point point)
        {
            Move(point.X, point.Y);
        }

        /// <summary>
        /// Rotates the point by the given angle.
        /// </summary>
        /// <param name="angle"></param>
        public void Rotate(double angle)
        {
            var x = X * Math.Cos(angle) - Y * Math.Sin(angle);
            var y = X * Math.Sin(angle) + Y * Math.Cos(angle);

            X = x;
            Y = y;
        }
    }
}
