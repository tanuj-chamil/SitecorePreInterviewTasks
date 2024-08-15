using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecorePreInterviewTasks.Task01
{
        public class Traverser
        {
            public List<Point> Directions { get; }
            public Point Position { get; }

            public Traverser(List<Point> directions, Point position)
            {
                Directions = directions;
                Position = position;
            }
        }
    }

