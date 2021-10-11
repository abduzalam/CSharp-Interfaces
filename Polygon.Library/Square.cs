using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public class Square : ConcreteRegularPolygon
    {
        //Here number 4 will pass to base class constructor , that is ConcreteRegularPolygon and mapped to Parameter sides
        public Square(int length):base(4,length)
        {}
        //Our own implementation of GetArea by overriding base class GetArea method

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
        
    }
}
