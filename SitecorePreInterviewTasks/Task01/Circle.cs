using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecorePreInterviewTasks.Task01
{
    /// <summary>
    /// Represents a circle in 2D space.
    /// </summary>
    public class Circle
    {
        public decimal Radius { get; set; }
        public Point Center { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="center"></param>
        /// <param name="radius"></param>
        public Circle(Point center, decimal radius)
        {
            Center = center;
            Radius = radius;
        }

        /// <summary>
        /// Moves the circle by the given coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(double x, double y)
        {
            Center.Move(x, y);
        }


        /// <summary>
        /// Moves the circle by the given point.
        /// </summary>
        /// <param name="point"></param>
        public void Move(Point point)
        {
            Center.Move(point);
        }


        /// <summary>
        /// Rotates the circle by the given angle.
        /// </summary>
        /// <param name="angle"></param>
        public void Rotate(double angle)
        {
            Center.Rotate(angle);
        }
    }
}
