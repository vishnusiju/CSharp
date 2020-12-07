using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleApplication
{
    class Rectangle
    {
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width");
            width = Convert.ToDouble(Console.ReadLine());

        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());

        }

    }
    
        

    
}




