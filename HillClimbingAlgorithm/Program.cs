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
            double amountOfCorrectOptimals = 0;
            for(int i=0;i< amountOfTests;i++)
            {
                var elements = generator.GenerateHeap(30);
                HillClimbing result = new HillClimbing(elements, 3);
                if (result.OptimalValue == 0)
                    amountOfCorrectOptimals++;
            }
            Console.WriteLine($"Mistake: {amountOfCorrectOptimals / amountOfTests}%");
            Console.ReadKey();
        }
    }
}
