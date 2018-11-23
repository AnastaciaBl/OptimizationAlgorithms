namespace HillClimbingPresentation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chVectors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tBAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBIterations = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBElements = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btsSave = new System.Windows.Forms.Button();
            this.btnGeneticStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPopulation = new System.Windows.Forms.TextBox();
            this.tbGeneticActualPopulation = new System.Windows.Forms.TextBox();
            this.tbIndividuals = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGeneticAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chGenetic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chVectors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGenetic)).BeginInit();
            this.SuspendLayout();
            // 
            // chVectors
            // 
            chartArea3.Name = "ChartArea1";
            this.chVectors.ChartAreas.Add(chartArea3);
            this.chVectors.Location = new System.Drawing.Point(6, 8);
            this.chVectors.Name = "chVectors";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Red;
            series3.Name = "Series1";
            this.chVectors.Series.Add(series3);
            this.chVectors.Size = new System.Drawing.Size(487, 450);
            this.chVectors.TabIndex = 0;
            this.chVectors.Text = "chart1";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(302, 51);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tBAnswer
            // 
            this.tBAnswer.Location = new System.Drawing.Point(141, 206);
            this.tBAnswer.Name = "tBAnswer";
            this.tBAnswer.Size = new System.Drawing.Size(134, 20);
            this.tBAnswer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount of iterations:";
            // 
            // tBIterations
            // 
            this.tBIterations.Location = new System.Drawing.Point(141, 235);
            this.tBIterations.Name = "tBIterations";
            this.tBIterations.Size = new System.Drawing.Size(134, 20);
            this.tBIterations.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount of elements:";
            // 
            // tBElements
            // 
            this.tBElements.Location = new System.Drawing.Point(141, 261);
            this.tBElements.Name = "tBElements";
            this.tBElements.Size = new System.Drawing.Size(134, 20);
            this.tBElements.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 89);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 52);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save as...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tBElements);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBAnswer);
            this.groupBox1.Controls.Add(this.tBIterations);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(499, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 450);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 493);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chVectors);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hill Climbing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btsSave);
            this.tabPage2.Controls.Add(this.btnGeneticStart);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.chGenetic);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Genetic Algorithm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btsSave
            // 
            this.btsSave.Location = new System.Drawing.Point(557, 301);
            this.btsSave.Name = "btsSave";
            this.btsSave.Size = new System.Drawing.Size(167, 56);
            this.btsSave.TabIndex = 12;
            this.btsSave.Text = "Save as...";
            this.btsSave.UseVisualStyleBackColor = true;
            this.btsSave.Click += new System.EventHandler(this.btsSave_Click);
            // 
            // btnGeneticStart
            // 
            this.btnGeneticStart.Location = new System.Drawing.Point(557, 226);
            this.btnGeneticStart.Name = "btnGeneticStart";
            this.btnGeneticStart.Size = new System.Drawing.Size(167, 56);
            this.btnGeneticStart.TabIndex = 11;
            this.btnGeneticStart.Text = "Start";
            this.btnGeneticStart.UseVisualStyleBackColor = true;
            this.btnGeneticStart.Click += new System.EventHandler(this.btnGeneticStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbPopulation);
            this.groupBox2.Controls.Add(this.tbGeneticActualPopulation);
            this.groupBox2.Controls.Add(this.tbIndividuals);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbGeneticAnswer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(487, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 171);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount of population:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Amount of actual population:";
            // 
            // tbPopulation
            // 
            this.tbPopulation.Location = new System.Drawing.Point(165, 22);
            this.tbPopulation.Name = "tbPopulation";
            this.tbPopulation.Size = new System.Drawing.Size(100, 20);
            this.tbPopulation.TabIndex = 2;
            this.tbPopulation.Text = "50";
            // 
            // tbGeneticActualPopulation
            // 
            this.tbGeneticActualPopulation.Location = new System.Drawing.Point(165, 132);
            this.tbGeneticActualPopulation.Name = "tbGeneticActualPopulation";
            this.tbGeneticActualPopulation.Size = new System.Drawing.Size(100, 20);
            this.tbGeneticActualPopulation.TabIndex = 8;
            // 
            // tbIndividuals
            // 
            this.tbIndividuals.Location = new System.Drawing.Point(165, 59);
            this.tbIndividuals.Name = "tbIndividuals";
            this.tbIndividuals.Size = new System.Drawing.Size(100, 20);
            this.tbIndividuals.TabIndex = 3;
            this.tbIndividuals.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Answer:";
            // 
            // tbGeneticAnswer
            // 
            this.tbGeneticAnswer.Location = new System.Drawing.Point(165, 96);
            this.tbGeneticAnswer.Name = "tbGeneticAnswer";
            this.tbGeneticAnswer.Size = new System.Drawing.Size(100, 20);
            this.tbGeneticAnswer.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amount of individuals:";
            // 
            // chGenetic
            // 
            chartArea4.Name = "ChartArea1";
            this.chGenetic.ChartAreas.Add(chartArea4);
            this.chGenetic.Location = new System.Drawing.Point(3, 6);
            this.chGenetic.Name = "chGenetic";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Red;
            series4.Name = "Series1";
            this.chGenetic.Series.Add(series4);
            this.chGenetic.Size = new System.Drawing.Size(487, 455);
            this.chGenetic.TabIndex = 1;
            this.chGenetic.Text = "chGenetic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Optimization";
            ((System.ComponentModel.ISupportInitialize)(this.chVectors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGenetic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chVectors;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tBAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBIterations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBElements;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGenetic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGeneticActualPopulation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGeneticAnswer;
        private System.Windows.Forms.TextBox tbIndividuals;
        private System.Windows.Forms.TextBox tbPopulation;
        private System.Windows.Forms.Button btsSave;
        private System.Windows.Forms.Button btnGeneticStart;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

