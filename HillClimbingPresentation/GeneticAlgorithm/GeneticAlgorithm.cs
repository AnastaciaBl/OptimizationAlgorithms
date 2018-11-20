using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingPresentation.GeneticAlgorithm
{
    class GeneticAlgorithm
    {
        public int AmountOfIndividuals { get; }
        public int AmountOfElementsInVector { get; }
        public double[] Fitness { get; }
        public List<Vector> Population { get; private set; }

        public GeneticAlgorithm(int amountOfIndividuals, int amountOfElements, double[] fitness)
        {
            AmountOfIndividuals = amountOfIndividuals;
            AmountOfElementsInVector = amountOfElements;
            Fitness = fitness;
        }

        public void StartGeneticAlgorithm()
        {
            var random = new Random();
            CreatePopulation(random);
        }

        private void CreatePopulation(Random random)
        {
            for (int i = 0; i < AmountOfIndividuals; i++)
            {
                var newIndividual = new State[AmountOfElementsInVector];
                for (int j = 0; j < AmountOfElementsInVector; j++)
                    newIndividual[j] = (State) random.Next(0, 2);
                Population.Add(new Vector(newIndividual, HeuristicFunction(newIndividual)));
            }
        }

        public double HeuristicFunction(State[] vector)
        {
            double sumOne = 0, sumZero = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == 0)
                    sumZero += Fitness[i];
                else
                    sumOne += Fitness[i];
            }
            return Math.Abs(sumOne - sumZero);
        }
    }
}
