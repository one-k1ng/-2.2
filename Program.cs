using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = File.CreateText(@"d:\newfile.txt");
            writer.WriteLine("This is my new file");
            writer.WriteLine("Do you like its format?");
            writer.Close();
        }
    }
}
