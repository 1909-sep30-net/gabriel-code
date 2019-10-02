using System;

namespace ShapesApp.Library
{
    public class ColorCircle : Circle
    {
        public ColorCircle()
        {
            
        }
        public string Color{ get; set; }

        public override double GetPerimeter()
        {
            Console.WriteLine("IM SO FANCY IM A COLOR CIRCLE but also heres my perimeter");
            return base.GetPerimeter();
        }
    }
}