using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace SvgGenerator
{
    public class Circle : Shape
    {
        private readonly string CIRCLE_TEMPLATE = "<circle cx='{0}' cy='{1}' r='{2}' style='fill:rgb({3},{4},{5})' />";
        public static int Radius => SHAPE_SIZE / 2;
        public Circle(Color color, int cx, int cy, int size) : base(color, cx, cy, size) { }
        public Circle(Color color, int cx) : base(color, cx) { }
        public Circle(int x, int y, Color color) : base (x, y, color) { }

        public override string SvgStringBuilder(bool noise)
        {
            if (noise)
            {
                color = Noise.MakeNoisyColor(color);
                return string.Format(CIRCLE_TEMPLATE, (Noise.MakeNoisyPosition(X) * SHAPE_SIZE) + Radius, (Noise.MakeNoisyPosition(Y) * SHAPE_SIZE) + Radius, Radius, color.R, color.G, color.B);
            }
            return string.Format(CIRCLE_TEMPLATE, (X * SHAPE_SIZE) + Radius, (Y * SHAPE_SIZE) + Radius, Radius, color.R, color.G, color.B);
        }
    }
}