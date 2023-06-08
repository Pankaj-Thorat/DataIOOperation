using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIOOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileExists();
            ReadAllLines();
            ReadAllText();
        }
        public static void FileExists()
        {
            string path = @"C:\Users\thora\source\repos\FileIOOperations\FileIOOperations\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
        public static void ReadAllLines()
        {
            string path = @"C:\Users\thora\source\repos\FileIOOperations\FileIOOperations\Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);//to print line
        }
        public static void ReadAllText()
        {
            string path = @"C:\Users\thora\source\repos\FileIOOperations\FileIOOperations\Example.txt";
            string lines;
            lines = File.ReadAllText(path);

            Console.WriteLine(lines[0]);// to print char
        }
    }
}
