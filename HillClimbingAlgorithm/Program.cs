using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            SeriesGenerator generator = new SeriesGenerator();
            int amountOfTests = 100;
            double amountOfIncorrectOptimals = 0;
            for(int i=0;i< amountOfTests;i++)
            {
                var elements = generator.GenerateHeap(500);
                HillClimbing result = new HillClimbing(elements, 1);
                if (result.OptimalValue != 0)
                    amountOfIncorrectOptimals++;
                Console.WriteLine($"Test #{i + 1}:");
                Console.WriteLine($"Amount of elements: {elements.Count}");
                Console.WriteLine($"Difference between heaps: {result.OptimalValue}");
            }
            Console.WriteLine($"Mistake: {(amountOfIncorrectOptimals / amountOfTests) * 100}%");
            Console.ReadKey();
        }
    }
}
