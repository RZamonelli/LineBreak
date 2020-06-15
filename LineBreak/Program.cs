using System;
using System.IO;

namespace LineBreak
{
    class ProcessBreakLine
    {
        private static ProcessBreakLine _instance;

        static ProcessBreakLine()
        {
            _instance = new ProcessBreakLine();
        }

        public static ProcessBreakLine Instance()
        {
            return _instance;
        }

        public void AnalyzeBreakLine(string url)
        {
            //Your code here
            Console.WriteLine(url);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            using (StreamReader sr = ReadListText())
            {
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        ProcessBreakLine.Instance().AnalyzeBreakLine(line);
                    }
                    catch (UriFormatException e)
                    {
                        Console.WriteLine(e.Message + " Text: " + line);
                    }

                    counter++;
                }
            }

            Console.ReadKey();
        }

        private static StreamReader ReadListText()
        {
            try
            {
                return new StreamReader(@"C:\Users\Renan\Documents\GitHub\LineBreak\LineBreak\Util\breakLine.txt");//change this path              
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
