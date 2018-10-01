using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingAlgorithm
{
    class HillClimbing
    {
        public int WorkArea { get; }
        public int AmountOfStartPoints { get; }
        public int[] ResultVector { get; private set; }
        public int[] WeightVector { get; private set; }

        public HillClimbing()
        {
            WorkArea = 1;
        }

        public HillClimbing(List<int> elements, int amountOfStartPoints):this()
        {
            AmountOfStartPoints = amountOfStartPoints;
            WeightVector = elements.ToArray();
            ResultVector = new int[elements.Count];            
        }

        private void CreateRandomVector() {
            Random random = new Random();
            for (int i = 0; i < ResultVector.Length; i++)
                ResultVector[i] = random.Next(0, 2);
        }

        //TODO expand function for bigger work area
        private int[] CreateVariantsOfLocalAnswer()
        {
            var array = new int[Convert.ToInt32(Math.Pow(2, WorkArea))];
            array[0] = 0;
            array[1] = 1;
            return array;
        }

        public void FindOptimalVariant(int amountOfStarts)
        {
            List<string> optimal = new List<string>();
            for(int i = 0; i < amountOfStarts; i++)
            {
                CreateRandomVector();
                for(int j = 0; j < ResultVector.Length; j++)
                {
                    var variants = CreateVariantsOfLocalAnswer();
                    var tempResult = new List<double>();
                    for (int k = 0; k < variants.Length; k++)
                    {
                        ResultVector[j] = variants[k];
                        tempResult.Add(HeuristicFunction());
                    }
                    ResultVector[j] = variants[FindIndexOfLocalOptimumVariant(tempResult)];
                }
            }
        }

        //choose result wich has minimal value of HeuristicFunction
        private int FindIndexOfLocalOptimumVariant(List<double> results)
        {
            double min = results.Min();
            int index = -1;
            for(int i=0;i< results.Count;i++)
            {
                if (min == results[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public double HeuristicFunction()
        {
            int xc = 0, c = 0;
            for(int i=0;i<ResultVector.Length;i++)
            {
                xc += ResultVector[i] * WeightVector[i];
                c += WeightVector[i];
            }
            return Math.Abs(xc - 0.5 * c);
        }
    }
}
