using System;

namespace RGIS.GeoTIFF.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("RGIS v1.0");
            System.Console.WriteLine("RGIS.GeoTIFF Console v1.0");
            string path = "";
            if (args.Length == 0)
            {
                System.Console.WriteLine("Enter GeoTiff Filepath");
                path = System.Console.ReadLine();
            }
            else
            {
                path = args[0];
            }

            RGIS.GeoTIFF.FileContent file = new FileContent(path);

        }
    }
}
