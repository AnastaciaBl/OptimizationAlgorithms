using HillClimbingPresentation.GeneticAlgorithm;
using System;

namespace HillClimbingPresentation.Utility
{
    public static class Global
    {
        public static double HeuristicFunction(State[] vector, double[] fitness)
        {
            double sumOne = 0, sumZero = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == 0)
                    sumZero += fitness[i];
                else
                    sumOne += fitness[i];
            }
            return Math.Abs(sumOne - sumZero);
        }
    }
}
