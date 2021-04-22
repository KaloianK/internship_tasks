using System;
using System.IO;
using System.Text;

namespace StreamFIlesDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader("sample.txt", Encoding.GetEncoding("UTF-8"));

            //int lineNumber = 0;

            //string line = reader.ReadLine();

            //while (line != null)
            //{
            //    lineNumber++;
            //    Console.WriteLine("Line {0}: {1}", lineNumber, line);
            //    line = reader.ReadLine();
            //}

            //reader.Close();

            //StreamWriter writer = new StreamWriter("test.txt");

            //using (writer)
            //{
            //    for (int i = 1; i <= 20; i++)
            //    {
            //        writer.WriteLine(i);
            //    }
            //}

            string fileName = "sample.txt";
            string word = "C#";

            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    int occurrences = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        int index = line.IndexOf(word);

                        while (index != -1)
                        {
                            occurrences++;
                            index = line.IndexOf(word, (index + 1));
                        }
                        line = reader.ReadLine();
                    }

                    Console.WriteLine("The WOrd {0} occurrs {1} times.", word, occurrences);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}", fileName);
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can not read the file {0}", fileName);
            }
        }
    }
}

