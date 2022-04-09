using System;
using System.Drawing;

namespace SvgGenerator
{
    public class ManualMode : Mode
    {
        public override void init()
        {
            Console.WriteLine("Please enter the number of shapes: ");
            var numShapes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numShapes; i++)
            {
                Console.WriteLine("Type 1 for circle or 2 for square for shape #" + (i + 1));
                var inputShape = Console.ReadLine();
                Console.WriteLine("Please enter the color for shape #" + (i + 1));
                var inputColor = Console.ReadLine();
                var color = Color.FromName(inputColor);
                Shape shape = inputShape == "2" ? new Square(color, i) : new Circle(color, i);
                this.listOfShapes.Add(shape);
            }
        }
    }
}