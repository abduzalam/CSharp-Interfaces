using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public AbstractRegularPolygon(int sides, int lengths)
        {
            NumberOfSides = sides;
            SideLength = lengths;
        }
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
        public abstract double GetArea();
    }
}
