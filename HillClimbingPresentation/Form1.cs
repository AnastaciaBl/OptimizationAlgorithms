using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using HillClimbingPresentation.HillClimbingAlgorithm;
using HillClimbingPresentation.Utility;

namespace HillClimbingPresentation
{
    public partial class Form1 : Form
    {
        public List<double> Elements { get; set; }
        public HillClimbing Algorithm { get; set; }
        public const int AmountOfTests = 10;
        public GeneticAlgorithm.GeneticAlgorithm GeneticAlg { get; set; }

        public Form1()
        {
            InitializeComponent();
            Elements = new List<double>();
        }

        #region HillClimbing
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    Elements.Clear();
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        while (!sr.EndOfStream)
                            Elements.Add(Convert.ToDouble(sr.ReadLine()));
                    }
                    FindOptimalDecision();
                    tBAnswer.Text = Algorithm.OptimalValue.Value.ToString();
                    tBElements.Text = Elements.Count.ToString();
                    tBIterations.Text = Algorithm.OptimalValue.AmountOfIteration.ToString();
                    FillHillClimbingChart();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfd.FileName;
                    SaveFile(fileName, Algorithm.OptimalValue.Value, Algorithm.ResultVector);
                }
            }
        }

        private void FindOptimalDecision()
        {
            double optimal = 1000;
            for (int i = 0; i < AmountOfTests; i++)
            {
                var temp = new HillClimbing(Elements, 5);
                if (temp.OptimalValue.Value < optimal)
                {
                    Algorithm = temp;
                    optimal = temp.OptimalValue.Value;
                }
            }
        }

        private void FillHillClimbingChart()
        {
            chVectors.Series[0].Points.Clear();
            for (int i = 0; i < Algorithm.OptimalValue.ChartInfo.AmountOfIteration; i++)
            {
                chVectors.Series[0].Points.AddXY(i, Algorithm.OptimalValue.ChartInfo.FunctionValue[i]);
            }
            chVectors.Series[0].Points.AddXY(Algorithm.OptimalValue.ChartInfo.AmountOfIteration, Algorithm.OptimalValue.Value);
        }
        #endregion

        #region GeneticAlgorithm
        private void btnGeneticStart_Click(object sender, EventArgs e)
        {
            GeneticAlg = new GeneticAlgorithm.GeneticAlgorithm(5, 500, Elements.Count, Elements.ToArray());
            tbGeneticAnswer.Text = GeneticAlg.Result.OptimalValue.ToString();
            tbGeneticActualPopulation.Text = GeneticAlg.LogInfoAboutPopulation.AmountOfPopulation.ToString();
            FillGeneticChart();
        }

        private void btsSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfd.FileName;
                    SaveFile(fileName, GeneticAlg.Result.OptimalValue, GeneticAlg.Result.Elements);
                }
            }
        }

        private void FillGeneticChart()
        {
            chGenetic.Series[0].Points.Clear();
            for (int i = 0; i < GeneticAlg.LogInfoAboutPopulation.AmountOfPopulation; i++)
            {
                chGenetic.Series[0].Points.AddXY(i, GeneticAlg.LogInfoAboutPopulation.WeaknessIndividuals[i].OptimalValue);
                chGenetic.Series[0].Points.AddXY(i, GeneticAlg.LogInfoAboutPopulation.StrongestIndividuals[i].OptimalValue);
            }
            chGenetic.Series[0].Points.AddXY(GeneticAlg.LogInfoAboutPopulation.AmountOfPopulation, GeneticAlg.Result.OptimalValue);
        }
        #endregion
        
        private void SaveFile(string fileName, double answer, State[] vector)
        {
            using (StreamWriter sr = new StreamWriter(fileName))
            {
                sr.WriteLine($"Result: {answer}");
                foreach (var v in vector)
                {
                    sr.WriteLine((int) v);
                }
            }
            MessageBox.Show("Файл сохранен");
        }
    }
}
