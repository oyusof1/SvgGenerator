using System;
using System.Drawing;

namespace SvgGenerator
{
    public class Square : Shape
    {
        private readonly string RECT_TEMPLATE = "<rect width='{0}' height='{1}' x='{2}' y='{3}' style='fill:rgb({4},{5},{6})' />";

        public Square(Color color, int x, int y, int size) : base(color, x, y, size) { }
        public Square(Color color, int x) : base(color, x) { }
        public Square(int x, int y, Color color) : base (x, y, color) { }

        public override string SvgStringBuilder(bool noise)
        {
            if (noise)
            {
                color = Noise.MakeNoisyColor(color);
                return string.Format(RECT_TEMPLATE, SHAPE_SIZE, SHAPE_SIZE, Noise.MakeNoisyPosition(X) * SHAPE_SIZE, Noise.MakeNoisyPosition(Y) * SHAPE_SIZE,
                    color.R, color.G, color.B);
            }
            return string.Format(RECT_TEMPLATE, SHAPE_SIZE, SHAPE_SIZE, X * SHAPE_SIZE, Y * SHAPE_SIZE, color.R, color.G, color.B);
        }
    }
}

