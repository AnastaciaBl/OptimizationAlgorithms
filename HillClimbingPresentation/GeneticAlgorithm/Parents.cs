using System;
using System.Collections.Generic;
using System.Linq;
using HillClimbingPresentation.Utility;

namespace HillClimbingPresentation.GeneticAlgorithm
{
    public class Parents
    {
        public Vector FirstParent { get; set; }
        public Vector SecondParent { get; set; }

        public Parents(List<Vector> population)
        {
            Random random = new Random();
            FirstParent = ChooseParent(population, random);
            SecondParent = ChooseParent(population, random);
        }

        private Vector ChooseParent(List<Vector> population, Random random)
        {
            var sortedPopulation = population.OrderBy(p => p.ProbabilityToBeParent).ToList();
            for (int i = 1; i < sortedPopulation.Count; i++)
                sortedPopulation[i].ProbabilityToBeParent += sortedPopulation[i - 1].ProbabilityToBeParent;

            double randomValue = random.NextDouble();
            if (sortedPopulation[0].ProbabilityToBeParent > randomValue)
                return sortedPopulation[0];

            for (int i = 1; i < sortedPopulation.Count; i++)
            {
                if (sortedPopulation[i - 1].ProbabilityToBeParent < randomValue &&
                    sortedPopulation[i].ProbabilityToBeParent > randomValue)
                    return sortedPopulation[i];
            }
            return null;
        }

        public Vector MakeChild(double[] fitness)
        {
            var firstChild = new State[FirstParent.Elements.Length];
            var secondChild = new State[FirstParent.Elements.Length];
            int indexOfHalf = firstChild.Length / 2;

            for (int i = 0; i < indexOfHalf; i++)
            {
                firstChild[i] = FirstParent.Elements[i];
                secondChild[i] = SecondParent.Elements[i];
            }
            for (int i = indexOfHalf; i < firstChild.Length; i++)
            {
                firstChild[i] = SecondParent.Elements[i];
                secondChild[i] = FirstParent.Elements[i];
            }
            if(Global.HeuristicFunction(firstChild, fitness) <= Global.HeuristicFunction(secondChild, fitness))
                return new Vector(firstChild, Global.HeuristicFunction(firstChild, fitness));
            return new Vector(secondChild, Global.HeuristicFunction(secondChild, fitness));
        }
    }
}
