using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdWeekTasks
{
    public class Rectangle:Shape
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(double width,double height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(double width, double height,string color,bool filled)
        {
            Width = width;
            Height = height;
            Color = color;
            Filled = filled;
        }
        public static double GetWidth()
        {
            return Width;
        }
        public static void SetWidth( double width)
        {
            Width = width;
        }
        public static double GetHeight()
        {
            return Height;
        }
        public static void SetHeight(double height)
        {
            Height = height;
        }
        public static double GetArea()
        {
            return Height * Width;
        }
        public static double GetPerimetr()
        {
            return 2 * (Height + Width);
        }
        public override string toString()
        {
            return "A Rectangle with width ="+Width+" and length = "+Height+",which is a subclass of Shape";
        }
    }
}
