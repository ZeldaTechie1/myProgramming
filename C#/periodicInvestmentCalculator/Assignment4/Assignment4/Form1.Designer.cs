namespace Assignment4
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
            this.initialDeposit = new System.Windows.Forms.TextBox();
            this.retirementAge = new System.Windows.Forms.TextBox();
            this.ageWhen = new System.Windows.Forms.TextBox();
            this.rateOf = new System.Windows.Forms.TextBox();
            this.depositEvery = new System.Windows.Forms.TextBox();
            this.inputContainer = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.printDataBox = new System.Windows.Forms.TextBox();
            this.inputContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialDeposit
            // 
            this.initialDeposit.Location = new System.Drawing.Point(335, 23);
            this.initialDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.initialDeposit.Name = "initialDeposit";
            this.initialDeposit.Size = new System.Drawing.Size(124, 22);
            this.initialDeposit.TabIndex = 0;
            this.initialDeposit.TextChanged += new System.EventHandler(this.initialDeposit_TextChanged);
            // 
            // retirementAge
            // 
            this.retirementAge.Location = new System.Drawing.Point(335, 199);
            this.retirementAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.retirementAge.Name = "retirementAge";
            this.retirementAge.Size = new System.Drawing.Size(124, 22);
            this.retirementAge.TabIndex = 4;
            // 
            // ageWhen
            // 
            this.ageWhen.Location = new System.Drawing.Point(335, 155);
            this.ageWhen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ageWhen.Name = "ageWhen";
            this.ageWhen.Size = new System.Drawing.Size(124, 22);
            this.ageWhen.TabIndex = 3;
            // 
            // rateOf
            // 
            this.rateOf.Location = new System.Drawing.Point(335, 112);
            this.rateOf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rateOf.Name = "rateOf";
            this.rateOf.Size = new System.Drawing.Size(124, 22);
            this.rateOf.TabIndex = 2;
            // 
            // depositEvery
            // 
            this.depositEvery.Location = new System.Drawing.Point(335, 68);
            this.depositEvery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depositEvery.Name = "depositEvery";
            this.depositEvery.Size = new System.Drawing.Size(124, 22);
            this.depositEvery.TabIndex = 1;
            // 
            // inputContainer
            // 
            this.inputContainer.Controls.Add(this.label5);
            this.inputContainer.Controls.Add(this.label4);
            this.inputContainer.Controls.Add(this.label2);
            this.inputContainer.Controls.Add(this.label3);
            this.inputContainer.Controls.Add(this.label1);
            this.inputContainer.Controls.Add(this.depositEvery);
            this.inputContainer.Controls.Add(this.rateOf);
            this.inputContainer.Controls.Add(this.ageWhen);
            this.inputContainer.Controls.Add(this.retirementAge);
            this.inputContainer.Controls.Add(this.initialDeposit);
            this.inputContainer.Location = new System.Drawing.Point(16, 15);
            this.inputContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputContainer.Name = "inputContainer";
            this.inputContainer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputContainer.Size = new System.Drawing.Size(480, 250);
            this.inputContainer.TabIndex = 0;
            this.inputContainer.TabStop = false;
            this.inputContainer.Text = "Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Retirement Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Age when Account Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rate of Interest per annum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deposit Every 30 Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Initial Deposit";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(520, 58);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(112, 25);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(520, 190);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 25);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // printDataBox
            // 
            this.printDataBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.printDataBox.Location = new System.Drawing.Point(16, 281);
            this.printDataBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printDataBox.Multiline = true;
            this.printDataBox.Name = "printDataBox";
            this.printDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.printDataBox.Size = new System.Drawing.Size(633, 344);
            this.printDataBox.TabIndex = 6;
            this.printDataBox.TextChanged += new System.EventHandler(this.printDataBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 656);
            this.Controls.Add(this.printDataBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.inputContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Future Value of Periodic Investment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputContainer.ResumeLayout(false);
            this.inputContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox initialDeposit;
        private System.Windows.Forms.TextBox retirementAge;
        private System.Windows.Forms.TextBox ageWhen;
        private System.Windows.Forms.TextBox rateOf;
        private System.Windows.Forms.TextBox depositEvery;
        public System.Windows.Forms.GroupBox inputContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox printDataBox;
    }
}

