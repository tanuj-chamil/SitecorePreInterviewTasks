using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecorePreInterviewTasks.Task01
{
    /// <summary>
    /// Represents an aggregation of objects in 2D space.
    /// </summary>
    public class Aggregation
    {
        public List<object> List { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Aggregation"/> class.
        /// </summary>
        public Aggregation()
        {
            List = new List<object>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Aggregation"/> class.
        /// </summary>
        /// <param name="list"></param>
        public Aggregation(List<object> list)
        {
            List = list;
        }

        /// <summary>
        /// Adds an object to the aggregation.
        /// </summary>
        /// <param name="obj"></param>
        public void Add(object obj)
        {
            List.Add(obj);
        }

        /// <summary>
        /// Removes an object from the aggregation.
        /// </summary>
        /// <param name="obj"></param>
        public void Remove(object obj)
        {
            List.Remove(obj);
        }


        /// <summary>
        /// Clears the aggregation.
        /// </summary>
        public void Clear() {
            List.Clear();
        }

        /// <summary>
        /// Returns the number of objects in the aggregation.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return List.Count;
        }

        /// <summary>
        /// Moves all objects in the aggregation by the given coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(double x, double y)
        {
            foreach (var obj in List)
            {
                if (obj is Point)
                {
                    ((Point)obj).Move(x, y);
                }
                else if (obj is Line)
                {
                    ((Line)obj).Move(x, y);
                }
                else if (obj is Circle)
                {
                    ((Circle)obj).Move(x, y);
                }
            }
        }

        /// <summary>
        /// Moves all objects in the aggregation by the given point.
        /// </summary>
        /// <param name="point"></param>
        public void Move(Point point)
        {
            foreach (var obj in List)
            {
                if (obj is Point)
                {
                    ((Point)obj).Move(point);
                }
                else if (obj is Line)
                {
                    ((Line)obj).Move(point);
                }
                else if (obj is Circle)
                {
                    ((Circle)obj).Move(point);
                }
            }
        }

        /// <summary>
        /// Rotates all objects in the aggregation by the given angle.
        /// </summary>
        /// <param name="angle"></param>
        public void Rotate(double angle)
        {
            foreach (var obj in List)
            {
                if (obj is Point)
                {
                    ((Point)obj).Rotate(angle);
                }
                else if (obj is Line)
                {
                    ((Line)obj).Rotate(angle);
                }
                else if (obj is Circle)
                {
                    ((Circle)obj).Rotate(angle);
                }
            }
        }

    }
}
