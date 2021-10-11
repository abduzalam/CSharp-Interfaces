using System;

namespace Polygon.Library
{
    public class ConcreteRegularPolygon
    {
        public int NumberOfSides {  get; set; }
        public int SideLength {  get; set; }

        public ConcreteRegularPolygon(int sides, int lengths)
        {
            NumberOfSides = sides;
            SideLength = lengths;
        }
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
        //GetArea is declared virtual because the calculation varies based on the Polygon
        //So its up to the child class to implement the correct formula

        //Even if child class does not implement the GetArea, the compilation will pass,
        //and during run time GetArea of base class gets executed and we get NotImplementedException
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
