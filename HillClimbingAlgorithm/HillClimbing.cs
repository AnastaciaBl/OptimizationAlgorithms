using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingAlgorithm
{
    enum State
    {
        Zero,
        One
    }

    class HillClimbing
    {
        public int WorkArea { get; }
        public int AmountOfStartPoints { get; }
        public State[] ResultVector { get; private set; }
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
            ResultVector = new State[elements.Count];
            FindOptimalVariant();
        }

        private void CreateRandomVector(Random random)
        {
            for (int i = 0; i < ResultVector.Length; i++)
                ResultVector[i] = (State)random.Next(0, 2);
        }

        private void FindOptimalVariant()
        {
            Random random = new Random();
            var optimals = new List<OptimalRepresentation>();
            for(int i = 0; i < AmountOfStartPoints; i++)
            {
                int iterationCounter = 0;
                CreateRandomVector(random);
                int optimalIndex = FindIndexOfOptimalElement(ResultVector); ;
                while (optimalIndex != -1)
                {
                    iterationCounter++;
                    SwitchElements(ResultVector, optimalIndex);
                    optimalIndex = FindIndexOfOptimalElement(ResultVector);
                }
                optimals.Add(new OptimalRepresentation(CreateStringFromResultVector(), HeuristicFunction(), iterationCounter));
            }
            int index = FindIndexOfOptimumVariant(optimals);
            OptimalValue = optimals[index].Value;
            CreateResultVectorFromString(optimals[index].Vector);
            AmountOfIteration = optimals[index].AmountOfIteration;
        }

        private int FindIndexOfOptimalElement(State[] vector)
        {
            int index = -1;
            double difference = HeuristicFunction(vector);
            State[] tempVector = new State[vector.Length];
            vector.CopyTo(tempVector, 0);
            for (int i = 0; i < vector.Length; i++)
            {
                SwitchElements(tempVector, i);
                if (HeuristicFunction(tempVector) < difference)
                    index = i;
                SwitchElements(tempVector, i);
            }
            return index;
        }

        private void SwitchElements(State[] vector, int index)
        {
            if (vector[index] == State.Zero)
                vector[index] = State.One;
            else
                vector[index] = State.Zero;
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
            double sumOne = 0, sumZero = 0;
            for (int i = 0; i < ResultVector.Length; i++)
            {
                if(ResultVector[i] == 0)
                    sumZero += WeightVector[i];
                else
                    sumOne += WeightVector[i];
            }
            return Math.Abs(sumOne - sumZero);
        }

        public double HeuristicFunction(State[] vector)
        {
            double sumOne = 0, sumZero = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == 0)
                    sumZero += WeightVector[i];
                else
                    sumOne += WeightVector[i];
            }
            return Math.Abs(sumOne - sumZero);
        }

        public string CreateStringFromResultVector()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ResultVector.Length; i++)
                sb.Append((int)ResultVector[i]);
            return sb.ToString();
        }

        private void CreateResultVectorFromString(string vector)
        {
            for (int i = 0; i < ResultVector.Length; i++)
                ResultVector[i] = (State)char.GetNumericValue(vector[i]);
        }
    }
}
