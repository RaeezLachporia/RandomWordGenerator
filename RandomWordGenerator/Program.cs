using System;
using System.IO;
using System.Linq;
namespace RandomWordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of words you would like to generate");
            int NumWords = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(NumWords);
            String FileName = "WordBank.txt";
            int[] myNumbers = File.ReadLines(FileName).Select(line => int.Parse(line)).ToArray();

            for (int i = 0; i < NumWords; i++)
            {
                Random r = new Random();
                int rIndex = r.Next(FileName.Length);
                Console.WriteLine("your random words are: " + FileName[rIndex]);
            }
        }

       
    }
}
