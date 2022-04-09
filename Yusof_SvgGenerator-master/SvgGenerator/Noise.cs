using System;
using System.Drawing;

namespace SvgGenerator
{
    public class Noise
    {
        public static Color MakeNoisyColor(Color color)
        {
            return Color.FromArgb(RandomColor(color.R), RandomColor(color.G), RandomColor(color.B));
        }

        private static int RandomColor(int color)
        {
            Random rand = new();
            int startingColor = color;
            for (;;)
            {
                color = startingColor + rand.Next(-10, 10);
                if (!(color < 0 || color > 255)) break;
            }
            return color;
        }

        public static int MakeNoisyPosition(int position)
        {
            int startingPosition = position;
            Random rand = new();
            for (;;)
            {
                position = startingPosition + rand.Next(-1, 1);
                if (!(position < 0)) break;
            }

            return position;
        }
    }
}
