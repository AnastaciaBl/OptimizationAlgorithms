using System;
using HillClimbingPresentation.Utility;

namespace HillClimbingPresentation.GeneticAlgorithm
{
    public class Vector
    {
        public State[] Elements { get; set; }
        public double OptimalValue { get; set; }
        public double ProbabilityToBeParent { get; set; }
        public int Rank { get; set; }

        public Vector(State[] elements, double optimalValue)
        {
            Elements = elements;
            OptimalValue = optimalValue;
        }

        public void Mutate(double[] fitness, Random random)
        {
            int amountOfMutateSigns = Elements.Length / 20;
            for (int i = 0; i < amountOfMutateSigns; i++)
            {
                int index = random.Next(0, Elements.Length);
                Elements[index] = Elements[index] == State.One ? State.Zero : State.One;
            }
            OptimalValue = Global.HeuristicFunction(Elements, fitness);
        }
    }
}
