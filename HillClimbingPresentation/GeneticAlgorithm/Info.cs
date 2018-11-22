using System.Collections.Generic;

namespace HillClimbingPresentation.GeneticAlgorithm
{
    public class Info
    {
        public int AmountOfPopulation { get; set; }
        public List<Vector> StrongestIndividuals { get; set; }
        public List<Vector> WeaknessIndividuals { get; set; }

        public Info()
        {
            StrongestIndividuals = new List<Vector>();
            WeaknessIndividuals = new List<Vector>();
        }

        public void SetInfo(Vector strongest, Vector weakness)
        {
            StrongestIndividuals.Add(strongest);
            WeaknessIndividuals.Add(weakness);
            AmountOfPopulation++;
        }
    }
}
