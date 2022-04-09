using System;
using System.IO;
using System.Drawing;

namespace SvgGenerator
{
    public class FileReader : Mode
    {
        public override void init()
        {
            Console.WriteLine("Please enter the absolute path to the shapes properties file: ");
            var input = Console.ReadLine();

            string[] shapes = File.ReadAllLines(input);

            foreach (var _shape in shapes)
            {
                Shape shape;
                var shapeProps = _shape.Split(',');

                if (shapeProps[3].Trim() == "Square")
                {
                    shape = new Square(
                        Convert.ToInt32(shapeProps[0].Trim()),
                        Convert.ToInt32(shapeProps[1].Trim()),
                        Color.FromName(shapeProps[2].Trim())
                    );
                }
                else
                {
                    shape = new Circle(
                        Convert.ToInt32(shapeProps[0].Trim()),
                        Convert.ToInt32(shapeProps[1].Trim()),
                        Color.FromName(shapeProps[2].Trim())
                    );
                }

                this.listOfShapes.Add(shape);
            }
        }
    }
}