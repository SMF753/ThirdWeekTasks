using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdWeekTasks
{
    public class Shape
    { 
        public static string Color { get; set; }
        public static bool Filled { get; set; }
        public Shape()
        {

        }
        public Shape(string _color,bool _filled)
        {
            Color = _color;
            Filled = _filled;
        }
        public static string GetColor()
        {
            return "green";
        }
        public static void SetColor(string color)
        {
            Color = color;
        }
        public static bool IsFilled()
        {
            return true;
        }
        public static void SetFilled(bool filled)
        {
            Filled = filled;
        }
        public  virtual string toString()
        {
            return "A Shape with color of "+GetColor()+" and "+IsFilled();
        }
    }
}
