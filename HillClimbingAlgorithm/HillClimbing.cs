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

        public HillClimbing(List<int> elements, int area, int amountOfStartPoints)
        {
            WorkArea = area;
            AmountOfStartPoints = amountOfStartPoints;
            WeightVector = elements.ToArray();
            ResultVector = new int[elements.Count];
            CreateRandomVector();
        }

        private void CreateRandomVector() {
            Random random = new Random();
            for (int i = 0; i < ResultVector.Length; i++)
                ResultVector[i] = random.Next(0, 2);
        }

        private int[,] CreateVariantsOfLocalAnswer()
        {
            var array = new int[0,0];
            return array;
        }

        public void FindOptimalVariant()
        {

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
