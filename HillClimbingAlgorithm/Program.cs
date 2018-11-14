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
                SaveInFile("answer.txt", result.CreateStringFromResultVector(), i + 1, result.OptimalValue);
                SaveInFileAnotherFormat("answerExtra.txt", result.CreateStringFromResultVector(), i + 1, result.OptimalValue);
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

        public static void SaveInFile(string file, string answer, int test, double difference)
        {
            using (StreamWriter sr = new StreamWriter(file, true))
            {
                sr.WriteLine($"Test #{test}: {answer}");
            }
        }

        public static void SaveInFileAnotherFormat(string file, string answer, int test, double difference)
        {
            using (StreamWriter sr = new StreamWriter(file, true))
            {
                sr.WriteLine($"Test #{test}: {difference}");
                for (int i = 0; i < answer.Length; i++)
                {
                    sr.WriteLine(answer[i]);
                }
            }
        }
    }
}
