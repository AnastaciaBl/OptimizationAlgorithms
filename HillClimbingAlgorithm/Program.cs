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
            var elements = generator.GenerateHeap();
            HillClimbing result = new HillClimbing(elements, 1);
            Console.ReadKey();
        }
    }
}
