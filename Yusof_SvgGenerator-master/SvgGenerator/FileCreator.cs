using System;
using System.IO;

namespace SvgGenerator
{
    class FileCreator
    {
        public static void Create(string path, string contents)
        {
            try
            {
                File.WriteAllText(path, contents);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception while writing file - {path}");
                Console.WriteLine($"Message       : {ex.Message}");
                Console.WriteLine($"Inner Message : {ex.InnerException?.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
