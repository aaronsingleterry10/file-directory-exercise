using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program that reads a text 
            //    file and displays the number of words.

            var filePath = @"C:\Users\Aaron Singleterry\source\repos\FilesExercise\index.txt";
            Console.WriteLine(NumberOfWordsFromFile(filePath));
            //2 - Write a program that reads a text file 
            //    and displays the longest word in the file.
        }

        public static int NumberOfWordsFromFile(string file)
        {
            var text = File.ReadAllText(file);
            var textArray = text.Split(' ');
            return textArray.Length;
        }
    }
}
