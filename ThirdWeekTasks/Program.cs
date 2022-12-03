using System;

namespace ThirdWeekTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Circle circle = new Circle(5);
            Square square = new Square(4);
            Rectangle rectangle = new Rectangle(4, 5);
            Console.WriteLine(shape.toString());
            Console.WriteLine(circle.toString());
            Console.WriteLine(square.toString());
            Console.WriteLine(rectangle.toString());

        }
    }
}
