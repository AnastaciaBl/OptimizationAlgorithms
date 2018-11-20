namespace HillClimbingPresentation.GeneticAlgorithm
{
    class Vector
    {
        public State[] Elements { get; set; }
        public double OptimalValue { get; set; }

        public Vector(State[] elements, double optimalValue)
        {
            Elements = elements;
            OptimalValue = optimalValue;
        }
    }
}
