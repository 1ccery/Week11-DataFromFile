using System;
using System.IO;

namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ente your favorite colour : ");
            string usercolor = Console.ReadLine();



            

        }

        private static string[] ReadDataFromFile()
        {
           string directoryPath = @"C:\Users\opilane\Samples";
           string filename = "Personality.txt";
           string fullpath = $@"{directoryPath}\{filename}";

           string[] datafrofile = File.ReadAllLines(fullpath);
           return DataFromFile;

        }
           
      private static string GetTheFileFromFileData(string userinput)
        {
            string[] datafromfile = ReadDataFromFile();
            string result = "";
            
            foreach (string line in datafrofile)
            {
                if (line.Contains(userinput))
                {
                    Console.WriteLine(line);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry i didnt notrcognize the color");
                    Console.ReadLine();
                }


            }


        }
        
      
    }
}
