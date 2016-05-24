namespace Assignment6CSharp
{
    partial class showHandsForm
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
            this.p4Deck = new System.Windows.Forms.TextBox();
            this.p3Deck = new System.Windows.Forms.TextBox();
            this.p2Deck = new System.Windows.Forms.TextBox();
            this.p1Deck = new System.Windows.Forms.TextBox();
            this.p4Name = new System.Windows.Forms.TextBox();
            this.p3Name = new System.Windows.Forms.TextBox();
            this.p2Name = new System.Windows.Forms.TextBox();
            this.p1Name = new System.Windows.Forms.TextBox();
            this.arrangeCardsButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p4Deck
            // 
            this.p4Deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4Deck.Location = new System.Drawing.Point(99, 158);
            this.p4Deck.Name = "p4Deck";
            this.p4Deck.ReadOnly = true;
            this.p4Deck.Size = new System.Drawing.Size(460, 29);
            this.p4Deck.TabIndex = 22;
            this.p4Deck.TabStop = false;
            // 
            // p3Deck
            // 
            this.p3Deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3Deck.Location = new System.Drawing.Point(100, 123);
            this.p3Deck.Name = "p3Deck";
            this.p3Deck.ReadOnly = true;
            this.p3Deck.Size = new System.Drawing.Size(460, 29);
            this.p3Deck.TabIndex = 21;
            this.p3Deck.TabStop = false;
            // 
            // p2Deck
            // 
            this.p2Deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Deck.Location = new System.Drawing.Point(99, 88);
            this.p2Deck.Name = "p2Deck";
            this.p2Deck.ReadOnly = true;
            this.p2Deck.Size = new System.Drawing.Size(460, 29);
            this.p2Deck.TabIndex = 20;
            this.p2Deck.TabStop = false;
            // 
            // p1Deck
            // 
            this.p1Deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Deck.Location = new System.Drawing.Point(99, 53);
            this.p1Deck.Name = "p1Deck";
            this.p1Deck.ReadOnly = true;
            this.p1Deck.Size = new System.Drawing.Size(460, 29);
            this.p1Deck.TabIndex = 19;
            this.p1Deck.TabStop = false;
            // 
            // p4Name
            // 
            this.p4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4Name.Location = new System.Drawing.Point(12, 158);
            this.p4Name.Name = "p4Name";
            this.p4Name.ReadOnly = true;
            this.p4Name.Size = new System.Drawing.Size(81, 29);
            this.p4Name.TabIndex = 18;
            this.p4Name.TabStop = false;
            this.p4Name.Text = "Player 4";
            // 
            // p3Name
            // 
            this.p3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3Name.Location = new System.Drawing.Point(12, 123);
            this.p3Name.Name = "p3Name";
            this.p3Name.ReadOnly = true;
            this.p3Name.Size = new System.Drawing.Size(81, 29);
            this.p3Name.TabIndex = 17;
            this.p3Name.TabStop = false;
            this.p3Name.Text = "Player 3";
            // 
            // p2Name
            // 
            this.p2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Name.Location = new System.Drawing.Point(12, 88);
            this.p2Name.Name = "p2Name";
            this.p2Name.ReadOnly = true;
            this.p2Name.Size = new System.Drawing.Size(81, 29);
            this.p2Name.TabIndex = 16;
            this.p2Name.TabStop = false;
            this.p2Name.Text = "Player 2";
            // 
            // p1Name
            // 
            this.p1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Name.Location = new System.Drawing.Point(12, 53);
            this.p1Name.Name = "p1Name";
            this.p1Name.ReadOnly = true;
            this.p1Name.Size = new System.Drawing.Size(81, 29);
            this.p1Name.TabIndex = 15;
            this.p1Name.TabStop = false;
            this.p1Name.Text = "Player 1";
            // 
            // arrangeCardsButton
            // 
            this.arrangeCardsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrangeCardsButton.Location = new System.Drawing.Point(223, 12);
            this.arrangeCardsButton.Name = "arrangeCardsButton";
            this.arrangeCardsButton.Size = new System.Drawing.Size(126, 31);
            this.arrangeCardsButton.TabIndex = 0;
            this.arrangeCardsButton.Text = "Arrange Cards";
            this.arrangeCardsButton.UseVisualStyleBackColor = true;
            this.arrangeCardsButton.Click += new System.EventHandler(this.arrangeCardsButton_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.Location = new System.Drawing.Point(223, 202);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(126, 31);
            this.playAgainButton.TabIndex = 1;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // showHandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 236);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.arrangeCardsButton);
            this.Controls.Add(this.p4Deck);
            this.Controls.Add(this.p3Deck);
            this.Controls.Add(this.p2Deck);
            this.Controls.Add(this.p1Deck);
            this.Controls.Add(this.p4Name);
            this.Controls.Add(this.p3Name);
            this.Controls.Add(this.p2Name);
            this.Controls.Add(this.p1Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "showHandsForm";
            this.Text = "Show Hands";
            this.Load += new System.EventHandler(this.showHandsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p4Deck;
        private System.Windows.Forms.TextBox p3Deck;
        private System.Windows.Forms.TextBox p2Deck;
        private System.Windows.Forms.TextBox p1Deck;
        private System.Windows.Forms.TextBox p4Name;
        private System.Windows.Forms.TextBox p3Name;
        private System.Windows.Forms.TextBox p2Name;
        private System.Windows.Forms.TextBox p1Name;
        private System.Windows.Forms.Button arrangeCardsButton;
        private System.Windows.Forms.Button playAgainButton;
    }
}