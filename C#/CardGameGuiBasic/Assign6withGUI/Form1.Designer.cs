﻿namespace Assignment6CSharp
{
    partial class mainForm
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
            this.getNewDeckButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.getNewDeckText = new System.Windows.Forms.TextBox();
            this.shuffleText = new System.Windows.Forms.TextBox();
            this.dealButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.showHandsButton = new System.Windows.Forms.Button();
            this.p1Name = new System.Windows.Forms.TextBox();
            this.p2Name = new System.Windows.Forms.TextBox();
            this.p3Name = new System.Windows.Forms.TextBox();
            this.p4Name = new System.Windows.Forms.TextBox();
            this.p1Deck = new System.Windows.Forms.TextBox();
            this.p2Deck = new System.Windows.Forms.TextBox();
            this.p3Deck = new System.Windows.Forms.TextBox();
            this.p4Deck = new System.Windows.Forms.TextBox();
            this.picturesShowButton = new System.Windows.Forms.Button();
            this.showShowButton = new System.Windows.Forms.Button();
            this.arrangeCardsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getNewDeckButton
            // 
            this.getNewDeckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getNewDeckButton.Location = new System.Drawing.Point(13, 13);
            this.getNewDeckButton.Margin = new System.Windows.Forms.Padding(4);
            this.getNewDeckButton.Name = "getNewDeckButton";
            this.getNewDeckButton.Size = new System.Drawing.Size(124, 36);
            this.getNewDeckButton.TabIndex = 0;
            this.getNewDeckButton.Text = "Get New Deck";
            this.getNewDeckButton.UseVisualStyleBackColor = true;
            this.getNewDeckButton.Click += new System.EventHandler(this.getNewDeckButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleButton.Location = new System.Drawing.Point(13, 152);
            this.shuffleButton.Margin = new System.Windows.Forms.Padding(4);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(124, 36);
            this.shuffleButton.TabIndex = 1;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // getNewDeckText
            // 
            this.getNewDeckText.Enabled = false;
            this.getNewDeckText.Location = new System.Drawing.Point(158, 13);
            this.getNewDeckText.Margin = new System.Windows.Forms.Padding(4);
            this.getNewDeckText.Multiline = true;
            this.getNewDeckText.Name = "getNewDeckText";
            this.getNewDeckText.Size = new System.Drawing.Size(532, 116);
            this.getNewDeckText.TabIndex = 2;
            this.getNewDeckText.TabStop = false;
            // 
            // shuffleText
            // 
            this.shuffleText.Enabled = false;
            this.shuffleText.Location = new System.Drawing.Point(158, 152);
            this.shuffleText.Margin = new System.Windows.Forms.Padding(4);
            this.shuffleText.Multiline = true;
            this.shuffleText.Name = "shuffleText";
            this.shuffleText.Size = new System.Drawing.Size(532, 116);
            this.shuffleText.TabIndex = 3;
            this.shuffleText.TabStop = false;
            // 
            // dealButton
            // 
            this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(158, 290);
            this.dealButton.Margin = new System.Windows.Forms.Padding(4);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(145, 36);
            this.dealButton.TabIndex = 3;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(545, 290);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(145, 36);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // showHandsButton
            // 
            this.showHandsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showHandsButton.Location = new System.Drawing.Point(353, 290);
            this.showHandsButton.Margin = new System.Windows.Forms.Padding(4);
            this.showHandsButton.Name = "showHandsButton";
            this.showHandsButton.Size = new System.Drawing.Size(145, 36);
            this.showHandsButton.TabIndex = 4;
            this.showHandsButton.Text = "Show Hands";
            this.showHandsButton.UseVisualStyleBackColor = true;
            this.showHandsButton.Click += new System.EventHandler(this.showHandsButton_Click);
            // 
            // p1Name
            // 
            this.p1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Name.Location = new System.Drawing.Point(42, 349);
            this.p1Name.Margin = new System.Windows.Forms.Padding(4);
            this.p1Name.Name = "p1Name";
            this.p1Name.ReadOnly = true;
            this.p1Name.Size = new System.Drawing.Size(107, 34);
            this.p1Name.TabIndex = 7;
            this.p1Name.TabStop = false;
            this.p1Name.Text = "Player 1";
            // 
            // p2Name
            // 
            this.p2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Name.Location = new System.Drawing.Point(42, 392);
            this.p2Name.Margin = new System.Windows.Forms.Padding(4);
            this.p2Name.Name = "p2Name";
            this.p2Name.ReadOnly = true;
            this.p2Name.Size = new System.Drawing.Size(107, 34);
            this.p2Name.TabIndex = 8;
            this.p2Name.TabStop = false;
            this.p2Name.Text = "Player 2";
            // 
            // p3Name
            // 
            this.p3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3Name.Location = new System.Drawing.Point(42, 436);
            this.p3Name.Margin = new System.Windows.Forms.Padding(4);
            this.p3Name.Name = "p3Name";
            this.p3Name.ReadOnly = true;
            this.p3Name.Size = new System.Drawing.Size(107, 34);
            this.p3Name.TabIndex = 9;
            this.p3Name.TabStop = false;
            this.p3Name.Text = "Player 3";
            // 
            // p4Name
            // 
            this.p4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4Name.Location = new System.Drawing.Point(42, 479);
            this.p4Name.Margin = new System.Windows.Forms.Padding(4);
            this.p4Name.Name = "p4Name";
            this.p4Name.ReadOnly = true;
            this.p4Name.Size = new System.Drawing.Size(107, 34);
            this.p4Name.TabIndex = 10;
            this.p4Name.TabStop = false;
            this.p4Name.Text = "Player 4";
            // 
            // p1Deck
            // 
            this.p1Deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Deck.Location = new System.Drawing.Point(158, 349);
            this.p1Deck.Margin = new System.Windows.Forms.Padding(4);
            this.p1Deck.Name = "p1Deck";
            this.p1Deck.ReadOnly = true;
            this.p1Deck.Size = new System.Drawing.Size(612, 34);
            this.p1Deck.TabIndex = 11;
            this.p1Deck.TabStop = false;
            // 
            // p2Deck
            // 
            this.p2Deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Deck.Location = new System.Drawing.Point(158, 392);
            this.p2Deck.Margin = new System.Windows.Forms.Padding(4);
            this.p2Deck.Name = "p2Deck";
            this.p2Deck.ReadOnly = true;
            this.p2Deck.Size = new System.Drawing.Size(612, 34);
            this.p2Deck.TabIndex = 12;
            this.p2Deck.TabStop = false;
            // 
            // p3Deck
            // 
            this.p3Deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3Deck.Location = new System.Drawing.Point(160, 436);
            this.p3Deck.Margin = new System.Windows.Forms.Padding(4);
            this.p3Deck.Name = "p3Deck";
            this.p3Deck.ReadOnly = true;
            this.p3Deck.Size = new System.Drawing.Size(612, 34);
            this.p3Deck.TabIndex = 13;
            this.p3Deck.TabStop = false;
            // 
            // p4Deck
            // 
            this.p4Deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4Deck.Location = new System.Drawing.Point(158, 479);
            this.p4Deck.Margin = new System.Windows.Forms.Padding(4);
            this.p4Deck.Name = "p4Deck";
            this.p4Deck.ReadOnly = true;
            this.p4Deck.Size = new System.Drawing.Size(612, 34);
            this.p4Deck.TabIndex = 14;
            this.p4Deck.TabStop = false;
            // 
            // picturesShowButton
            // 
            this.picturesShowButton.Location = new System.Drawing.Point(712, 13);
            this.picturesShowButton.Name = "picturesShowButton";
            this.picturesShowButton.Size = new System.Drawing.Size(124, 34);
            this.picturesShowButton.TabIndex = 15;
            this.picturesShowButton.Text = "Pictures";
            this.picturesShowButton.UseVisualStyleBackColor = true;
            this.picturesShowButton.Click += new System.EventHandler(this.picturesShowButton_Click);
            // 
            // showShowButton
            // 
            this.showShowButton.Location = new System.Drawing.Point(712, 152);
            this.showShowButton.Name = "showShowButton";
            this.showShowButton.Size = new System.Drawing.Size(124, 34);
            this.showShowButton.TabIndex = 16;
            this.showShowButton.Text = "Show";
            this.showShowButton.UseVisualStyleBackColor = true;
            this.showShowButton.Click += new System.EventHandler(this.showShowButton_Click);
            // 
            // arrangeCardsButton
            // 
            this.arrangeCardsButton.Location = new System.Drawing.Point(300, 515);
            this.arrangeCardsButton.Name = "arrangeCardsButton";
            this.arrangeCardsButton.Size = new System.Drawing.Size(248, 31);
            this.arrangeCardsButton.TabIndex = 17;
            this.arrangeCardsButton.Text = "Arrange Cards in Hands";
            this.arrangeCardsButton.UseVisualStyleBackColor = true;
            this.arrangeCardsButton.Click += new System.EventHandler(this.arrangeCardsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 574);
            this.Controls.Add(this.arrangeCardsButton);
            this.Controls.Add(this.showShowButton);
            this.Controls.Add(this.picturesShowButton);
            this.Controls.Add(this.p4Deck);
            this.Controls.Add(this.p3Deck);
            this.Controls.Add(this.p2Deck);
            this.Controls.Add(this.p1Deck);
            this.Controls.Add(this.p4Name);
            this.Controls.Add(this.p3Name);
            this.Controls.Add(this.p2Name);
            this.Controls.Add(this.p1Name);
            this.Controls.Add(this.showHandsButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.shuffleText);
            this.Controls.Add(this.getNewDeckText);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.getNewDeckButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Shuffling Cards";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getNewDeckButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.TextBox getNewDeckText;
        private System.Windows.Forms.TextBox shuffleText;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button showHandsButton;
        private System.Windows.Forms.TextBox p1Name;
        private System.Windows.Forms.TextBox p2Name;
        private System.Windows.Forms.TextBox p3Name;
        private System.Windows.Forms.TextBox p4Name;
        private System.Windows.Forms.TextBox p1Deck;
        private System.Windows.Forms.TextBox p2Deck;
        private System.Windows.Forms.TextBox p3Deck;
        private System.Windows.Forms.TextBox p4Deck;
        private System.Windows.Forms.Button picturesShowButton;
        private System.Windows.Forms.Button showShowButton;
        private System.Windows.Forms.Button arrangeCardsButton;
    }
}

