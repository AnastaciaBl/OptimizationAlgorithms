using System;
using System.Collections.Generic;
using System.Linq;
using HillClimbingPresentation.Utility;

namespace HillClimbingPresentation.GeneticAlgorithm
{
    public class GeneticAlgorithm
    {
        public int AmountOfIndividuals { get; }
        public int AmountOfElementsInVector { get; }
        public double[] Fitness { get; }
        public List<Vector> Population { get; private set; }
        public Info LogInfoAboutPopulation { get; }
        public int MaxAmountOfPopulation { get; }
        public Vector Result { get; private set; }

        private GeneticAlgorithm()
        {
            LogInfoAboutPopulation = new Info();
            Population = new List<Vector>();
        }

        public GeneticAlgorithm(int amountOfIndividuals, int amountOfPopulation, int amountOfElements, double[] fitness): this()
        {
            AmountOfIndividuals = amountOfIndividuals;
            AmountOfElementsInVector = amountOfElements;
            MaxAmountOfPopulation = amountOfPopulation;
            Fitness = fitness;
            StartGeneticAlgorithm();
            GetDecision();
        }

        private void StartGeneticAlgorithm()
        {
            var random = new Random();
            CreatePopulation(random);
            while (IsOptimalFound() || LogInfoAboutPopulation.AmountOfPopulation < MaxAmountOfPopulation)
            {
                SetInfoAboutStrongestWeaknessIndividuals();
                SetRankToPopulation();
                CountProbabilityToBeParent();
                var parents = ChooseParents(random);
                var children = MakeChildren(parents);
                MutateIndividuals(children, random);
                CreateNewPopulation(children);
            }
        }

        private void GetDecision()
        {
            Result = Population.OrderBy(p => p.OptimalValue).First();
        }

        private void CreatePopulation(Random random)
        {
            for (int i = 0; i < AmountOfIndividuals; i++)
            {
                var newIndividual = new State[AmountOfElementsInVector];
                for (int j = 0; j < AmountOfElementsInVector; j++)
                    newIndividual[j] = (State) random.Next(0, 2);
                Population.Add(new Vector(newIndividual, Global.HeuristicFunction(newIndividual, Fitness)));
            }
        }

        private void SetInfoAboutStrongestWeaknessIndividuals()
        {
            var sortedPopulation = Population.OrderBy(p => p.OptimalValue).ToList();
            LogInfoAboutPopulation.SetInfo(sortedPopulation.First(), sortedPopulation.Last());
        }

        private void SetRankToPopulation()
        {
            int rank = 1;
            Population.OrderByDescending(p => p.OptimalValue)
                .ToList()
                .ForEach(p =>
                {
                    p.Rank = rank;
                    rank++;
                });
        }

        private void CountProbabilityToBeParent()
        {
            Population.ForEach(p =>
                p.ProbabilityToBeParent = Math.Round((2.0 * p.Rank) / (AmountOfIndividuals * (AmountOfIndividuals + 1)), 4));
        }

        private List<Parents> ChooseParents(Random random)
        {
            var listOfParents = new List<Parents>();
            for (int i = 0; i < AmountOfIndividuals; i++)
                listOfParents.Add(new Parents(Population, random));
            return listOfParents;
        }

        private List<Vector> MakeChildren(List<Parents> parents)
        {
            var children = new List<Vector>();
            parents.ForEach(p => children.Add(p.MakeChild(Fitness)));
            return children;
        }

        public void MutateIndividuals(List<Vector> children, Random random)
        {
            children.ForEach(c => c.Mutate(Fitness, random));
        }

        private void CreateNewPopulation(List<Vector> children)
        {
            var newPopulation = new List<Vector>();
            var sortedPopulation = children.Union(Population)
                                          .OrderBy(e => e.OptimalValue)
                                          .ToList();
            for (int i = 0; i < AmountOfIndividuals; i++)
                newPopulation.Add(sortedPopulation[i]);
            Population = newPopulation;
        }

        private bool IsOptimalFound()
        {
            foreach (var p in Population)
            {
                if (p.OptimalValue == 0)
                    return true;
            }
            return false;
        }
    }
}
