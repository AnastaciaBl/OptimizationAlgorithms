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
        public const int AmountOfTest = 10;

        public Form1()
        {
            InitializeComponent();
            Elements = new List<double>();
            for (var i = 0; i < AmountOfTest; i++)
            {
                chVectors.Series.Add(new Series());
            }
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
                    Algorithm = new HillClimbing(Elements, 3);
                    tBAnswer.Text = Algorithm.OptimalValue.ToString();
                    tBElements.Text = Elements.Count.ToString();
                    tBIterations.Text = Algorithm.AmountOfIteration.ToString();
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
                        sr.WriteLine($"Result: {Algorithm.CreateStringFromResultVector()}");
                    }
                    MessageBox.Show("Файл сохранен");
                }
            }
        }

        private void FillChart()
        {
            for (var i = 0; i < chVectors.Series.Count; i++)
            {
                chVectors.Series[i].Points.Clear();
            }

        }
    }
}
