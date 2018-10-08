namespace HillClimbingAlgorithm
{
    class OptimalRepresentation
    {
        public string Vector { get; }
        public double Value { get; }

        public OptimalRepresentation(string vector, double value)
        {
            Vector = vector;
            Value = value;
        }
    }
}
