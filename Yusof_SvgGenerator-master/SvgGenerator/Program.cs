using System;

namespace SvgGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            int svgModeInput = 0;

            Console.WriteLine("Please enter the file output name (use the absolute path): ");
            var input = Console.ReadLine();

            Console.WriteLine("Do you wish to add noise to this svg? Enter 1 for yes or 0 for no.");
            var noise = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

            // Loop menu until valid selection has been made 
            while (menu)
            {
                Console.WriteLine("Please enter the number for the svg generation mode: \n 1 for Manual \n 2 for File Input");
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    continue;
                }
                else
                {
                    if (num == 1 || num == 2)
                    {
                        svgModeInput = num;
                        menu = false;
                    }
                }
            }

            Mode svgMode = svgModeInput == 1 ? new ManualMode() : new FileReader();
            svgMode.init();

            SvgBuilder svgBuilder = new();
            var svg = svgBuilder.Build(svgMode.listOfShapes, noise);

            FileCreator.Create(input, svg);

        }
    }
}
