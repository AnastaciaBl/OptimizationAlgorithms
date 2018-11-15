namespace HillClimbingAlgorithm
{
    public class OptimalRepresentation
    {
        public string Vector { get; private set; }
        public double Value { get; private set; }
        public int AmountOfIteration { get; set; }
        public ChartPresentationFormat ChartInfo { get; set; }

        public OptimalRepresentation()
        {
            ChartInfo = new ChartPresentationFormat();
        }

        public OptimalRepresentation(string vector, double value, int amountOfIteration): this()
        {
            Vector = vector;
            Value = value;
            AmountOfIteration = amountOfIteration;
        }

        public void SetValues(string vector, double value, int amountOfIteration)
        {
            Vector = vector;
            Value = value;
            AmountOfIteration = amountOfIteration;
        }
    }
}
