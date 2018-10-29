using System;
using System.Collections.Generic;
using System.IO;

namespace HillClimbingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            SeriesGenerator generator = new SeriesGenerator();
            int amountOfTests = 10;
            for(int i=0;i< amountOfTests;i++)
            {
                //var elements = generator.GenerateHeap(500);
                var elements = ReadFromFile("example.txt");
                HillClimbing result = new HillClimbing(elements, 5);
                Console.WriteLine($"Test #{i + 1}:");
                Console.WriteLine($"Amount of elements: {elements.Count}");
                Console.WriteLine($"Difference between heaps: {result.OptimalValue}");
                Console.WriteLine($"Amount of iteration: {result.AmountOfIteration}");
                SaveInFile("answer", result.CreateStringFromResultVector(), i + 1);
            }
            //Console.WriteLine($"Mistake: {(amountOfIncorrectOptimals / amountOfTests) * 100}%");
            Console.ReadKey();
        }

        public static List<double> ReadFromFile(string file)
        {
            var elements = new List<double>();
            using (StreamReader sr = new StreamReader(file))
            {
                while (!sr.EndOfStream)
                    elements.Add(Convert.ToDouble(sr.ReadLine()));
            }
            return elements;
        }

        public static void SaveInFile(string file, string answer, int test)
        {
            using (StreamWriter sr = new StreamWriter(file, true))
            {
                sr.WriteLine($"Test #{test}: {answer}");
            }
        }
    }
}
