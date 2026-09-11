using System;
using System.Collections.Generic;
using System.Text;

namespace OmAnandDemo
{
    
    public class SquareArea
    {
        public int length;
        public int breadth;
    }



    public class RectangleArea
    {
        public int length;
        public int breadth;
    }

    public class ScopeOfVariableDemo
    {
        static void Main(string[] args)
        {
            SquareArea square = new SquareArea();
            square.length = 5;

            RectangleArea rectangle = new RectangleArea();
            rectangle.length = 10;

            Console.WriteLine("Square Length: " + square.length + ", Rectangle Length: " + rectangle.length);

        }
    }

}
