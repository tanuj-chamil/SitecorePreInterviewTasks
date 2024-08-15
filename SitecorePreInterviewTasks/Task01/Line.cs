using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecorePreInterviewTasks.Task01
{
    /// <summary>
    /// Represents a line in 2D space.
    /// </summary>
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> class.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        /// <summary>
        /// Moves the line by the given coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(double x, double y)
        {
            Start.Move(x, y);
            End.Move(x, y);
        }


        /// <summary>
        /// Moves the line by the given point.
        /// </summary>
        /// <param name="point"></param>
        public void Move(Point point)
        {
            Start.Move(point);
            End.Move(point);
        }

        /// <summary>
        /// Rotates the line by the given angle.
        /// </summary>
        /// <param name="angle"></param>
        public void Rotate(double angle)
        {
            Start.Rotate(angle);
            End.Rotate(angle);
        }


    }
}
