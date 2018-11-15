using System.Collections.Generic;
using System.Linq;

namespace HillClimbingAlgorithm
{
    public class ChartPresentationFormat
    {
        public List<double> FunctionValue { get; set; }
        public int AmountOfIteration => FunctionValue.Count();

        public ChartPresentationFormat()
        {
            FunctionValue = new List<double>();
        }
    }
}
