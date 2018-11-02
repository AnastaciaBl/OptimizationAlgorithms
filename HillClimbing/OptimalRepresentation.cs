namespace HillClimbingLibrary
{
    class OptimalRepresentation
    {
        public string Vector { get; }
        public double Value { get; }
        public int AmountOfIteration { get; set; }

        public OptimalRepresentation(string vector, double value, int amountOfIteration)
        {
            Vector = vector;
            Value = value;
            AmountOfIteration = amountOfIteration;
        }
    }
}
