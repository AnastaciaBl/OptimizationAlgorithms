using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HillClimbingAlgorithm;

namespace HillClimbingPresentation
{
    public partial class Form1 : Form
    {
        public List<double> Elements { get; set; }
        public HillClimbing Algorithm { get; set; }
        public const int AmountOfTests = 10;

        public Form1()
        {
            InitializeComponent();
            Elements = new List<double>();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        while (!sr.EndOfStream)
                            Elements.Add(Convert.ToDouble(sr.ReadLine()));
                    }
                    FindOptimalDecision();
                    tBAnswer.Text = Algorithm.OptimalValue.Value.ToString();
                    tBElements.Text = Elements.Count.ToString();
                    tBIterations.Text = Algorithm.OptimalValue.AmountOfIteration.ToString();
                    FillChart();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfd.FileName;
                    using (StreamWriter sr = new StreamWriter(fileName))
                    {
                        sr.WriteLine($"Result: {Algorithm.OptimalValue.Value}");
                        string answer = Algorithm.CreateStringFromResultVector();
                        foreach (var r in Algorithm.ResultVector)
                        {
                            sr.WriteLine((int) r);
                        }
                    }
                    MessageBox.Show("Файл сохранен");
                }
            }
        }

        private void FillChart()
        {
            chVectors.Series[0].Points.Clear();
            for (int i = 0; i < Algorithm.OptimalValue.ChartInfo.AmountOfIteration; i++)
            {
                chVectors.Series[0].Points.AddXY(i + 1, Algorithm.OptimalValue.ChartInfo.FunctionValue[i]);
            }
        }
    }
}
