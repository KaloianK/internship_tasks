using System;
using System.Text;
using System.IO;

namespace Exceptions
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            //Exception e = new Exception("There was a problem!");
            //throw e;

            try
            {
                string fileName = "WrongFileName.txt";
                ReadFile(fileName);
            }
            catch(Exception e)
            {
                throw new ApplicationException("Bad Thing Happened", e);
            }
            
        }

        static void ReadFile(string fileName)
        {
            try
            {
                TextReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("The file {0} does not exist!", fileName);
                
            }
        }
    }
}
