using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdWeekTasks
{
    public class Square:Rectangle
    {
        public static double Side { get; set; }
        public Square()
        {

        }
        public Square(double side)
        {
            Side = side;
        }
        public Square(double side,string color,bool filled)
        {
            Side = side;
            Color = color;
            Filled = filled;
        }
        public static void SetSide(double side)
        {
            Side = side;
        }
        public override string toString()
        {
            return "A Square with side="+Side+", which is a subclass of Rectangle";
        }
    }
}
