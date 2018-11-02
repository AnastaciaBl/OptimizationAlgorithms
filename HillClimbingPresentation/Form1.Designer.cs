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
            ((System.ComponentModel.ISupportInitialize)(this.chVectors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chVectors
            // 
            chartArea3.Name = "ChartArea1";
            this.chVectors.ChartAreas.Add(chartArea3);
            this.chVectors.Location = new System.Drawing.Point(0, 0);
            this.chVectors.Name = "chVectors";
            series3.ChartArea = "ChartArea1";
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
            this.groupBox1.Location = new System.Drawing.Point(485, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 438);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chVectors);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chVectors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

