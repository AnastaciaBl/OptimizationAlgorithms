using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HillClimbingLibrary
{
    public class HillClimbing
    {
        public int WorkArea { get; }
        public int AmountOfStartPoints { get; }
        public int[] ResultVector { get; private set; }
        public double[] WeightVector { get; private set; }
        public double OptimalValue { get; private set; }
        public int AmountOfIteration { get; private set; }

        public HillClimbing()
        {
            WorkArea = 1;
        }

        public HillClimbing(List<double> elements, int amountOfStartPoints):this()
        {
            AmountOfStartPoints = amountOfStartPoints;
            WeightVector = elements.ToArray();
            ResultVector = new int[elements.Count];
            FindOptimalVariant();
        }

        private void CreateRandomVector(Random random) {
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

        private void FindOptimalVariant()
        {
            Random random = new Random();
            var optimals = new List<OptimalRepresentation>();
            for(int i = 0; i < AmountOfStartPoints; i++)
            {
                int iterationCounter = 0;
                CreateRandomVector(random);
                for(int j = 0; j < ResultVector.Length; j++)
                {
                    int oldVariant = ResultVector[j];
                    var variants = CreateVariantsOfLocalAnswer();
                    var tempResult = new List<double>();
                    for (int k = 0; k < variants.Length; k++)
                    {
                        ResultVector[j] = variants[k];
                        tempResult.Add(HeuristicFunction());
                    }
                    int newVariant = variants[FindIndexOfLocalOptimumVariant(tempResult)];
                    if (newVariant != oldVariant)
                        iterationCounter++;
                    ResultVector[j] = newVariant;
                }
                optimals.Add(new OptimalRepresentation(CreateStringFromResultVector(), HeuristicFunction(), iterationCounter));
            }
            int index = FindIndexOfOptimumVariant(optimals);
            OptimalValue = optimals[index].Value;
            CreateResultVectorFromString(optimals[index].Vector);
            AmountOfIteration = optimals[index].AmountOfIteration;
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

        private int FindIndexOfOptimumVariant(List<OptimalRepresentation> optimals)
        {
            double min = optimals[0].Value;
            int index = 0;
            for (int i = 0; i < optimals.Count; i++)
            {
                if (min > optimals[i].Value)
                {
                    min = optimals[i].Value;
                    index = i;
                }
            }
            return index;
        }

        public double HeuristicFunction()
        {
            double xc = 0, c = 0;
            for(int i=0;i<ResultVector.Length;i++)
            {
                xc += ResultVector[i] * WeightVector[i];
                c += WeightVector[i];
            }
            return Math.Abs(xc - 0.5 * c);
        }

        public string CreateStringFromResultVector()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ResultVector.Length; i++)
                sb.Append(ResultVector[i]);
            return sb.ToString();
        }

        private void CreateResultVectorFromString(string vector)
        {
            for (int i = 0; i < ResultVector.Length; i++)
                ResultVector[i] = (int)char.GetNumericValue(vector[i]);
        }
    }
}
