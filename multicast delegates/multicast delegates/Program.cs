using System;

namespace multicast_delegates
{
    public delegate void RectangleDelete(double Width, double Height);
    public class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area is {0}", (Width * Height));
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter is {0}", (2 * (Width + Height)));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectangleDelete rectDelegate = new RectangleDelete(rect.GetArea);  //point GetArea method
            rectDelegate += rect.GetPerimeter;  // add another method to point it after GetArea
            rectDelegate(23.45, 67.89);   //ei mangulor jonno first e GetArea ke then GetPerimeter ke call korbe.
            Console.WriteLine();
            rectDelegate.Invoke(13.45, 76.89);
            Console.WriteLine();
            //Removing a method from delegate object
            rectDelegate -= rect.GetPerimeter;
            rectDelegate.Invoke(13.45, 76.89);
            Console.ReadKey();
        }
    }
}
