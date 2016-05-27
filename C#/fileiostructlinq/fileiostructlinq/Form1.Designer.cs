namespace fileiostructlinq
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.chooseFile = new System.Windows.Forms.ToolStripLabel();
            this.openRead = new System.Windows.Forms.ToolStripLabel();
            this.saveFile = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fNTB = new System.Windows.Forms.TextBox();
            this.lNTB = new System.Windows.Forms.TextBox();
            this.teleTB = new System.Windows.Forms.TextBox();
            this.gpaTB = new System.Windows.Forms.TextBox();
            this.addInfoButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.findTeleButton = new System.Windows.Forms.Button();
            this.findGPAButton = new System.Windows.Forms.Button();
            this.findGPATB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.findTeleTB = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFile,
            this.openRead,
            this.saveFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(308, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // chooseFile
            // 
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(68, 22);
            this.chooseFile.Text = "Choose File";
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // openRead
            // 
            this.openRead.Name = "openRead";
            this.openRead.Size = new System.Drawing.Size(65, 22);
            this.openRead.Text = "Open Read";
            this.openRead.Click += new System.EventHandler(this.openRead_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(52, 22);
            this.saveFile.Text = "Save File";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "GPA";
            // 
            // fNTB
            // 
            this.fNTB.Location = new System.Drawing.Point(75, 28);
            this.fNTB.Name = "fNTB";
            this.fNTB.Size = new System.Drawing.Size(125, 20);
            this.fNTB.TabIndex = 5;
            // 
            // lNTB
            // 
            this.lNTB.Location = new System.Drawing.Point(75, 62);
            this.lNTB.Name = "lNTB";
            this.lNTB.Size = new System.Drawing.Size(125, 20);
            this.lNTB.TabIndex = 6;
            // 
            // teleTB
            // 
            this.teleTB.Location = new System.Drawing.Point(75, 96);
            this.teleTB.Name = "teleTB";
            this.teleTB.Size = new System.Drawing.Size(125, 20);
            this.teleTB.TabIndex = 7;
            // 
            // gpaTB
            // 
            this.gpaTB.Location = new System.Drawing.Point(75, 130);
            this.gpaTB.Name = "gpaTB";
            this.gpaTB.Size = new System.Drawing.Size(125, 20);
            this.gpaTB.TabIndex = 8;
            // 
            // addInfoButton
            // 
            this.addInfoButton.Location = new System.Drawing.Point(223, 43);
            this.addInfoButton.Name = "addInfoButton";
            this.addInfoButton.Size = new System.Drawing.Size(71, 25);
            this.addInfoButton.TabIndex = 9;
            this.addInfoButton.Text = "Add Info";
            this.addInfoButton.UseVisualStyleBackColor = true;
            this.addInfoButton.Click += new System.EventHandler(this.addInfoButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(223, 106);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(71, 25);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchGroupBox.Controls.Add(this.findTeleTB);
            this.searchGroupBox.Controls.Add(this.label6);
            this.searchGroupBox.Controls.Add(this.label5);
            this.searchGroupBox.Controls.Add(this.findGPATB);
            this.searchGroupBox.Controls.Add(this.findGPAButton);
            this.searchGroupBox.Controls.Add(this.findTeleButton);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 165);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(281, 75);
            this.searchGroupBox.TabIndex = 11;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // findTeleButton
            // 
            this.findTeleButton.Location = new System.Drawing.Point(9, 18);
            this.findTeleButton.Name = "findTeleButton";
            this.findTeleButton.Size = new System.Drawing.Size(73, 21);
            this.findTeleButton.TabIndex = 0;
            this.findTeleButton.Text = "Find Tele";
            this.findTeleButton.UseVisualStyleBackColor = true;
            this.findTeleButton.Click += new System.EventHandler(this.findTeleButton_Click);
            // 
            // findGPAButton
            // 
            this.findGPAButton.Location = new System.Drawing.Point(9, 45);
            this.findGPAButton.Name = "findGPAButton";
            this.findGPAButton.Size = new System.Drawing.Size(117, 21);
            this.findGPAButton.TabIndex = 1;
            this.findGPAButton.Text = "Find thos w/ GPA >=";
            this.findGPAButton.UseVisualStyleBackColor = true;
            this.findGPAButton.Click += new System.EventHandler(this.findGPAButton_Click);
            // 
            // findGPATB
            // 
            this.findGPATB.Location = new System.Drawing.Point(132, 46);
            this.findGPATB.Name = "findGPATB";
            this.findGPATB.Size = new System.Drawing.Size(79, 20);
            this.findGPATB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Last Name";
            // 
            // findTeleTB
            // 
            this.findTeleTB.Location = new System.Drawing.Point(88, 20);
            this.findTeleTB.Name = "findTeleTB";
            this.findTeleTB.Size = new System.Drawing.Size(123, 20);
            this.findTeleTB.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 248);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.addInfoButton);
            this.Controls.Add(this.gpaTB);
            this.Controls.Add(this.teleTB);
            this.Controls.Add(this.lNTB);
            this.Controls.Add(this.fNTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Name & Telephone & GPA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel chooseFile;
        private System.Windows.Forms.ToolStripLabel openRead;
        private System.Windows.Forms.ToolStripLabel saveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fNTB;
        private System.Windows.Forms.TextBox lNTB;
        private System.Windows.Forms.TextBox teleTB;
        private System.Windows.Forms.TextBox gpaTB;
        private System.Windows.Forms.Button addInfoButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox findTeleTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox findGPATB;
        private System.Windows.Forms.Button findGPAButton;
        private System.Windows.Forms.Button findTeleButton;
    }
}

