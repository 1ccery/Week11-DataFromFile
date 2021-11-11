using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
              Console.WriteLine(randomLineFromFile();
            }

            

            private static string randomLineFromFile()
            {
              string directoryPath = @"C:\Users\opilane\Samples";
              string filename = "Chuck.txt";
              string fullpath = $@"{directoryPath}\{filename}";


              string[] datafromfile = File.ReadAllLines(fullpath);
              Random rnd = new Random();
              Console.WriteLine(datafromfile[rnd.Next(datafromfile.Length)])
                
            }

        }
    }
}
