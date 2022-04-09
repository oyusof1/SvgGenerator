using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SvgGenerator
{
    public class SvgBuilder
    {
        private readonly string XML_HEADER = "<?xml version='1.0' encoding='utf-8'?>";
        private readonly string SVG_FILE_HEADER = "<!DOCTYPE svg PUBLIC '-//W3C//DTD SVG 1.1//EN' 'http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd'>";

        private readonly string SVG_TAG_HEADER = "<svg version='1.1' id='Layer_1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' x='0px' y='0px' width='10000px' height='10000px' viewBox='0 0 10000 10000' enable-background='new 0 0 10000 10000' xml:space='preserve'>";
        private readonly string SVG_TAG_FOOTER = "</svg>";

        // You may not change the signature of this method.
        public string Build(List<Shape> shapes, bool noise)
        {
            return
                XML_HEADER
                + SVG_FILE_HEADER
                + SVG_TAG_HEADER
                + BuildShapes(shapes, noise)
                + SVG_TAG_FOOTER;
        }

        public static StringBuilder BuildShapes(List<Shape> shapes, bool noise)
        {
            StringBuilder sb = new();
            foreach (var shape in shapes)
            {
                sb.Append(shape.SvgStringBuilder(noise));
            }
            return sb;
        }
    }
}


