using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace SvgGenerator
{
    public abstract class Shape
    {
        public readonly static int SHAPE_SIZE = 50;

        public Color color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }

          public Shape(Color color, int x, int y, int size = 50)
        {
            this.color = color;
            this.X = x;
            this.Y = y;
            this.Size = size;
        }

        public Shape(Color color)
        {
            this.color = color;
        }

        public Shape(Color color, int x)
        {
            this.color = color;
            this.X = x;
        }

        public Shape(int x, int y, Color color)
        {
            this.color = color;
            this.X = x;
            this.Y = y;
        }

        public abstract string SvgStringBuilder(bool noise);
    }
}