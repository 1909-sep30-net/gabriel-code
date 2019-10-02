using System;
using ShapesApp.Library;

namespace ShapesApp.App
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double length;
            string input;

            do
            {
                Console.WriteLine("Enter a length:");
                input = Console.ReadLine();
            }

            // While input is not a double, loop (ask again for input) 
            while (!double.TryParse(input, out length));

            double width;
            do
            {
                Console.WriteLine("Enter a length:");
                input = Console.ReadLine();
            }
            while (!double.TryParse(input, out width));

            

            /* Use the collection initializer method instead! */ 

            // var r = new Rectangle();
            // r.Length = length;
            // r.Width = width;

            var r = new Rectangle
            {
                Length = length,
                Width = width
            };

            printRectangle(r);

            Console.WriteLine(r.Area);

        }

        public static void printRectangle(Rectangle rectangle)
        {
            Console.WriteLine($"length: {rectangle.Length}, width: {rectangle.Width}, perimeter: {rectangle.GetPerimeter()}"); 
        }
    }
}
