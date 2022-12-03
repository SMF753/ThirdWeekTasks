using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdWeekTasks
{
    public class Circle:Shape
    {
        public static double Radius { get; set; }
        public Circle()
        {

        }
        public Circle( double radius)
        {
            Radius = radius;
        }
        public Circle(double radius,string color,bool filled)
        {
            Radius = radius;
            Color = color;
            Filled = filled;
        }
        public static double GetRadius()
        {
            return Radius;
        }
        public static void SetRadius( double radius)
        {
            Radius = radius;
        }
        public static double GetArea()
        {
            return Math.PI * Radius*Radius;
        }
        public static double GetPerimetr()
        {
            return 2 * Math.PI * Radius;
        }
        public  override string toString()
        {
            return "A Circle with radius = "+Radius+", which is a subclass of Shape";
        }
    }
}
