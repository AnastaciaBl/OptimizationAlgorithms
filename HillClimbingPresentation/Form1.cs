using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HillClimbingLibrary;

namespace HillClimbingPresentation
{
    public partial class Form1 : Form
    {
        public List<double> Elements { get; set; }
        public HillClimbing Algorithm { get; set; }

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
    }
}
