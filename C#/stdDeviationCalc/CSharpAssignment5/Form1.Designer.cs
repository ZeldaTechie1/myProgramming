namespace CSharpAssignment5
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
            this.description = new System.Windows.Forms.TextBox();
            this.instructions = new System.Windows.Forms.TextBox();
            this.scoresInputBox = new System.Windows.Forms.TextBox();
            this.saveToArray = new System.Windows.Forms.Button();
            this.scoresOutput = new System.Windows.Forms.TextBox();
            this.numberOfScoresTitle = new System.Windows.Forms.TextBox();
            this.sumOfDeviationSqTitle = new System.Windows.Forms.TextBox();
            this.stdDevTitle = new System.Windows.Forms.TextBox();
            this.sumTitle = new System.Windows.Forms.TextBox();
            this.averageTitle = new System.Windows.Forms.TextBox();
            this.noOfScores = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.TextBox();
            this.sumOfDevSq = new System.Windows.Forms.TextBox();
            this.stdDev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.Menu;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(-2, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(562, 20);
            this.description.TabIndex = 0;
            this.description.TabStop = false;
            this.description.Text = "This Program Calculates Standard Deviation for a set of scores entered";
            this.description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.SystemColors.Menu;
            this.instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(14, 58);
            this.instructions.Name = "instructions";
            this.instructions.ReadOnly = true;
            this.instructions.Size = new System.Drawing.Size(502, 16);
            this.instructions.TabIndex = 0;
            this.instructions.TabStop = false;
            this.instructions.Text = "Enter Scores Seperated by Spaces and Press Save to Array Button";
            // 
            // scoresInputBox
            // 
            this.scoresInputBox.Location = new System.Drawing.Point(14, 77);
            this.scoresInputBox.Name = "scoresInputBox";
            this.scoresInputBox.Size = new System.Drawing.Size(444, 20);
            this.scoresInputBox.TabIndex = 0;
            // 
            // saveToArray
            // 
            this.saveToArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToArray.Location = new System.Drawing.Point(464, 77);
            this.saveToArray.Name = "saveToArray";
            this.saveToArray.Size = new System.Drawing.Size(81, 20);
            this.saveToArray.TabIndex = 1;
            this.saveToArray.Text = "Save to Array";
            this.saveToArray.UseVisualStyleBackColor = true;
            this.saveToArray.Click += new System.EventHandler(this.saveToArray_Click);
            // 
            // scoresOutput
            // 
            this.scoresOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoresOutput.Location = new System.Drawing.Point(14, 115);
            this.scoresOutput.Multiline = true;
            this.scoresOutput.Name = "scoresOutput";
            this.scoresOutput.ReadOnly = true;
            this.scoresOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.scoresOutput.Size = new System.Drawing.Size(85, 178);
            this.scoresOutput.TabIndex = 2;
            // 
            // numberOfScoresTitle
            // 
            this.numberOfScoresTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.numberOfScoresTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberOfScoresTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfScoresTitle.Location = new System.Drawing.Point(131, 118);
            this.numberOfScoresTitle.Name = "numberOfScoresTitle";
            this.numberOfScoresTitle.ReadOnly = true;
            this.numberOfScoresTitle.Size = new System.Drawing.Size(84, 16);
            this.numberOfScoresTitle.TabIndex = 5;
            this.numberOfScoresTitle.TabStop = false;
            this.numberOfScoresTitle.Text = "No of Scores";
            // 
            // sumOfDeviationSqTitle
            // 
            this.sumOfDeviationSqTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.sumOfDeviationSqTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sumOfDeviationSqTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumOfDeviationSqTitle.Location = new System.Drawing.Point(119, 198);
            this.sumOfDeviationSqTitle.Name = "sumOfDeviationSqTitle";
            this.sumOfDeviationSqTitle.ReadOnly = true;
            this.sumOfDeviationSqTitle.Size = new System.Drawing.Size(96, 16);
            this.sumOfDeviationSqTitle.TabIndex = 6;
            this.sumOfDeviationSqTitle.TabStop = false;
            this.sumOfDeviationSqTitle.Text = "Sum of Dev Sq";
            // 
            // stdDevTitle
            // 
            this.stdDevTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.stdDevTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdDevTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdDevTitle.Location = new System.Drawing.Point(144, 274);
            this.stdDevTitle.Name = "stdDevTitle";
            this.stdDevTitle.ReadOnly = true;
            this.stdDevTitle.Size = new System.Drawing.Size(71, 16);
            this.stdDevTitle.TabIndex = 7;
            this.stdDevTitle.TabStop = false;
            this.stdDevTitle.Text = "Std Dev";
            // 
            // sumTitle
            // 
            this.sumTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.sumTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sumTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumTitle.Location = new System.Drawing.Point(300, 118);
            this.sumTitle.Name = "sumTitle";
            this.sumTitle.ReadOnly = true;
            this.sumTitle.Size = new System.Drawing.Size(27, 16);
            this.sumTitle.TabIndex = 8;
            this.sumTitle.TabStop = false;
            this.sumTitle.Text = "Sum";
            // 
            // averageTitle
            // 
            this.averageTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.averageTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.averageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTitle.Location = new System.Drawing.Point(411, 118);
            this.averageTitle.Name = "averageTitle";
            this.averageTitle.ReadOnly = true;
            this.averageTitle.Size = new System.Drawing.Size(65, 16);
            this.averageTitle.TabIndex = 9;
            this.averageTitle.TabStop = false;
            this.averageTitle.Text = "Average";
            // 
            // noOfScores
            // 
            this.noOfScores.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.noOfScores.Location = new System.Drawing.Point(221, 115);
            this.noOfScores.Name = "noOfScores";
            this.noOfScores.ReadOnly = true;
            this.noOfScores.Size = new System.Drawing.Size(63, 20);
            this.noOfScores.TabIndex = 3;
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sum.Location = new System.Drawing.Point(333, 115);
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.Size = new System.Drawing.Size(63, 20);
            this.sum.TabIndex = 4;
            // 
            // average
            // 
            this.average.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.average.Location = new System.Drawing.Point(473, 115);
            this.average.Name = "average";
            this.average.ReadOnly = true;
            this.average.Size = new System.Drawing.Size(63, 20);
            this.average.TabIndex = 5;
            this.average.TextChanged += new System.EventHandler(this.average_TextChanged);
            // 
            // sumOfDevSq
            // 
            this.sumOfDevSq.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sumOfDevSq.Location = new System.Drawing.Point(221, 197);
            this.sumOfDevSq.Name = "sumOfDevSq";
            this.sumOfDevSq.ReadOnly = true;
            this.sumOfDevSq.Size = new System.Drawing.Size(63, 20);
            this.sumOfDevSq.TabIndex = 6;
            // 
            // stdDev
            // 
            this.stdDev.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stdDev.Location = new System.Drawing.Point(221, 273);
            this.stdDev.Name = "stdDev";
            this.stdDev.ReadOnly = true;
            this.stdDev.Size = new System.Drawing.Size(63, 20);
            this.stdDev.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 313);
            this.Controls.Add(this.stdDev);
            this.Controls.Add(this.sumOfDevSq);
            this.Controls.Add(this.average);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.noOfScores);
            this.Controls.Add(this.averageTitle);
            this.Controls.Add(this.sumTitle);
            this.Controls.Add(this.stdDevTitle);
            this.Controls.Add(this.sumOfDeviationSqTitle);
            this.Controls.Add(this.numberOfScoresTitle);
            this.Controls.Add(this.scoresOutput);
            this.Controls.Add(this.saveToArray);
            this.Controls.Add(this.scoresInputBox);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox instructions;
        private System.Windows.Forms.TextBox scoresInputBox;
        private System.Windows.Forms.Button saveToArray;
        private System.Windows.Forms.TextBox scoresOutput;
        private System.Windows.Forms.TextBox numberOfScoresTitle;
        private System.Windows.Forms.TextBox sumOfDeviationSqTitle;
        private System.Windows.Forms.TextBox stdDevTitle;
        private System.Windows.Forms.TextBox sumTitle;
        private System.Windows.Forms.TextBox averageTitle;
        private System.Windows.Forms.TextBox noOfScores;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.TextBox average;
        private System.Windows.Forms.TextBox sumOfDevSq;
        private System.Windows.Forms.TextBox stdDev;
    }
}

