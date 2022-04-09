using System.Collections.Generic;

namespace SvgGenerator
{
    public abstract class Mode
    {
        public List<Shape> listOfShapes;

        public Mode()
        {
            this.listOfShapes = new List<Shape>();
        }
        public abstract void init();

    }
}