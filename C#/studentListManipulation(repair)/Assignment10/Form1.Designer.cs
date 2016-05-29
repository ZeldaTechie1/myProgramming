namespace Assignment10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.mSaveFileButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mReadFileTextBox = new System.Windows.Forms.TextBox();
            this.mReadFileButton = new System.Windows.Forms.Button();
            this.mToolStrip = new System.Windows.Forms.ToolStrip();
            this.mOpenFile = new System.Windows.Forms.ToolStripLabel();
            this.mExit = new System.Windows.Forms.ToolStripLabel();
            this.dataEntryTab = new System.Windows.Forms.TabPage();
            this.deAddToListButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.deNumOfItemsInListTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deGPATB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deTelephoneNumberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deLastNameTB = new System.Windows.Forms.TextBox();
            this.deFirstNameTB = new System.Windows.Forms.TextBox();
            this.editTab = new System.Windows.Forms.TabPage();
            this.eBinarySearchTeleButton = new System.Windows.Forms.Button();
            this.eSearchLastNameButton = new System.Windows.Forms.Button();
            this.eSaveChangesButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.eGPATB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.eTelephoneNumberTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.eLastNameTB = new System.Windows.Forms.TextBox();
            this.eFirstNameTB = new System.Windows.Forms.TextBox();
            this.ePreviousButton = new System.Windows.Forms.Button();
            this.eNextButton = new System.Windows.Forms.Button();
            this.eDisplaySortedButton = new System.Windows.Forms.Button();
            this.eDisplayAllButton = new System.Windows.Forms.Button();
            this.displayTab = new System.Windows.Forms.TabPage();
            this.dDisplayAreaTextBox = new System.Windows.Forms.TextBox();
            this.dShowAllAboveGPATextBox = new System.Windows.Forms.TextBox();
            this.dShowAllAboveGPAButton = new System.Windows.Forms.Button();
            this.dPrintButton = new System.Windows.Forms.Button();
            this.dShowSortedByLastNameButton = new System.Windows.Forms.Button();
            this.binarySearchTelephoneTB = new System.Windows.Forms.TextBox();
            this.searchLastNameTB = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mToolStrip.SuspendLayout();
            this.dataEntryTab.SuspendLayout();
            this.editTab.SuspendLayout();
            this.displayTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.dataEntryTab);
            this.tabControl1.Controls.Add(this.editTab);
            this.tabControl1.Controls.Add(this.displayTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 402);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.mSaveFileButton);
            this.mainTab.Controls.Add(this.pictureBox1);
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Controls.Add(this.mReadFileTextBox);
            this.mainTab.Controls.Add(this.mReadFileButton);
            this.mainTab.Controls.Add(this.mToolStrip);
            this.mainTab.Location = new System.Drawing.Point(4, 25);
            this.mainTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainTab.Size = new System.Drawing.Size(612, 373);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            this.mainTab.Click += new System.EventHandler(this.mainTab_Click);
            this.mainTab.Enter += new System.EventHandler(this.mainTab_Enter);
            // 
            // mSaveFileButton
            // 
            this.mSaveFileButton.Enabled = false;
            this.mSaveFileButton.Location = new System.Drawing.Point(256, 335);
            this.mSaveFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mSaveFileButton.Name = "mSaveFileButton";
            this.mSaveFileButton.Size = new System.Drawing.Size(99, 28);
            this.mSaveFileButton.TabIndex = 3;
            this.mSaveFileButton.Text = "Save File";
            this.mSaveFileButton.UseVisualStyleBackColor = true;
            this.mSaveFileButton.Click += new System.EventHandler(this.mSaveFileButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(143, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 180);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press Button to Read or Write Data File";
            // 
            // mReadFileTextBox
            // 
            this.mReadFileTextBox.Enabled = false;
            this.mReadFileTextBox.Location = new System.Drawing.Point(100, 52);
            this.mReadFileTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mReadFileTextBox.Name = "mReadFileTextBox";
            this.mReadFileTextBox.ReadOnly = true;
            this.mReadFileTextBox.Size = new System.Drawing.Size(504, 22);
            this.mReadFileTextBox.TabIndex = 2;
            this.mReadFileTextBox.TabStop = false;
            // 
            // mReadFileButton
            // 
            this.mReadFileButton.Location = new System.Drawing.Point(8, 49);
            this.mReadFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mReadFileButton.Name = "mReadFileButton";
            this.mReadFileButton.Size = new System.Drawing.Size(84, 28);
            this.mReadFileButton.TabIndex = 1;
            this.mReadFileButton.Text = "Read File";
            this.mReadFileButton.UseVisualStyleBackColor = true;
            this.mReadFileButton.Click += new System.EventHandler(this.mReadFileButton_Click);
            // 
            // mToolStrip
            // 
            this.mToolStrip.BackColor = System.Drawing.Color.LightGray;
            this.mToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpenFile,
            this.mExit});
            this.mToolStrip.Location = new System.Drawing.Point(4, 4);
            this.mToolStrip.Name = "mToolStrip";
            this.mToolStrip.Size = new System.Drawing.Size(604, 25);
            this.mToolStrip.TabIndex = 0;
            this.mToolStrip.Text = "toolStrip1";
            // 
            // mOpenFile
            // 
            this.mOpenFile.Name = "mOpenFile";
            this.mOpenFile.Size = new System.Drawing.Size(57, 22);
            this.mOpenFile.Text = "Open File";
            this.mOpenFile.Click += new System.EventHandler(this.mOpenFile_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(25, 22);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // dataEntryTab
            // 
            this.dataEntryTab.Controls.Add(this.deAddToListButton);
            this.dataEntryTab.Controls.Add(this.label6);
            this.dataEntryTab.Controls.Add(this.deNumOfItemsInListTB);
            this.dataEntryTab.Controls.Add(this.label5);
            this.dataEntryTab.Controls.Add(this.deGPATB);
            this.dataEntryTab.Controls.Add(this.label4);
            this.dataEntryTab.Controls.Add(this.deTelephoneNumberTB);
            this.dataEntryTab.Controls.Add(this.label3);
            this.dataEntryTab.Controls.Add(this.label2);
            this.dataEntryTab.Controls.Add(this.deLastNameTB);
            this.dataEntryTab.Controls.Add(this.deFirstNameTB);
            this.dataEntryTab.Location = new System.Drawing.Point(4, 25);
            this.dataEntryTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataEntryTab.Name = "dataEntryTab";
            this.dataEntryTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataEntryTab.Size = new System.Drawing.Size(612, 373);
            this.dataEntryTab.TabIndex = 1;
            this.dataEntryTab.Text = "Data Entry";
            this.dataEntryTab.UseVisualStyleBackColor = true;
            this.dataEntryTab.Click += new System.EventHandler(this.dataEntryTab_Click);
            this.dataEntryTab.Enter += new System.EventHandler(this.dataEntryTab_Enter);
            // 
            // deAddToListButton
            // 
            this.deAddToListButton.Enabled = false;
            this.deAddToListButton.Location = new System.Drawing.Point(283, 154);
            this.deAddToListButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deAddToListButton.Name = "deAddToListButton";
            this.deAddToListButton.Size = new System.Drawing.Size(91, 25);
            this.deAddToListButton.TabIndex = 4;
            this.deAddToListButton.Text = "Add to List";
            this.deAddToListButton.UseVisualStyleBackColor = true;
            this.deAddToListButton.Click += new System.EventHandler(this.deAddToListButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Number of Items in List";
            // 
            // deNumOfItemsInListTB
            // 
            this.deNumOfItemsInListTB.Enabled = false;
            this.deNumOfItemsInListTB.Location = new System.Drawing.Point(8, 154);
            this.deNumOfItemsInListTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deNumOfItemsInListTB.Name = "deNumOfItemsInListTB";
            this.deNumOfItemsInListTB.Size = new System.Drawing.Size(73, 22);
            this.deNumOfItemsInListTB.TabIndex = 8;
            this.deNumOfItemsInListTB.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "GPA";
            // 
            // deGPATB
            // 
            this.deGPATB.Enabled = false;
            this.deGPATB.Location = new System.Drawing.Point(283, 68);
            this.deGPATB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deGPATB.Name = "deGPATB";
            this.deGPATB.Size = new System.Drawing.Size(72, 22);
            this.deGPATB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telephone Number";
            // 
            // deTelephoneNumberTB
            // 
            this.deTelephoneNumberTB.Enabled = false;
            this.deTelephoneNumberTB.Location = new System.Drawing.Point(8, 68);
            this.deTelephoneNumberTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deTelephoneNumberTB.Name = "deTelephoneNumberTB";
            this.deTelephoneNumberTB.Size = new System.Drawing.Size(239, 22);
            this.deTelephoneNumberTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student First Name";
            // 
            // deLastNameTB
            // 
            this.deLastNameTB.Enabled = false;
            this.deLastNameTB.Location = new System.Drawing.Point(283, 7);
            this.deLastNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deLastNameTB.Name = "deLastNameTB";
            this.deLastNameTB.Size = new System.Drawing.Size(239, 22);
            this.deLastNameTB.TabIndex = 1;
            // 
            // deFirstNameTB
            // 
            this.deFirstNameTB.Enabled = false;
            this.deFirstNameTB.Location = new System.Drawing.Point(8, 7);
            this.deFirstNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deFirstNameTB.Name = "deFirstNameTB";
            this.deFirstNameTB.Size = new System.Drawing.Size(239, 22);
            this.deFirstNameTB.TabIndex = 0;
            // 
            // editTab
            // 
            this.editTab.Controls.Add(this.searchLastNameTB);
            this.editTab.Controls.Add(this.binarySearchTelephoneTB);
            this.editTab.Controls.Add(this.eBinarySearchTeleButton);
            this.editTab.Controls.Add(this.eSearchLastNameButton);
            this.editTab.Controls.Add(this.eSaveChangesButton);
            this.editTab.Controls.Add(this.label7);
            this.editTab.Controls.Add(this.eGPATB);
            this.editTab.Controls.Add(this.label8);
            this.editTab.Controls.Add(this.eTelephoneNumberTB);
            this.editTab.Controls.Add(this.label9);
            this.editTab.Controls.Add(this.label10);
            this.editTab.Controls.Add(this.eLastNameTB);
            this.editTab.Controls.Add(this.eFirstNameTB);
            this.editTab.Controls.Add(this.ePreviousButton);
            this.editTab.Controls.Add(this.eNextButton);
            this.editTab.Controls.Add(this.eDisplaySortedButton);
            this.editTab.Controls.Add(this.eDisplayAllButton);
            this.editTab.Location = new System.Drawing.Point(4, 25);
            this.editTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editTab.Size = new System.Drawing.Size(612, 373);
            this.editTab.TabIndex = 2;
            this.editTab.Text = "Edit";
            this.editTab.UseVisualStyleBackColor = true;
            this.editTab.Click += new System.EventHandler(this.editTab_Click);
            this.editTab.Enter += new System.EventHandler(this.editTab_Enter);
            // 
            // eBinarySearchTeleButton
            // 
            this.eBinarySearchTeleButton.Enabled = false;
            this.eBinarySearchTeleButton.Location = new System.Drawing.Point(295, 222);
            this.eBinarySearchTeleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eBinarySearchTeleButton.Name = "eBinarySearchTeleButton";
            this.eBinarySearchTeleButton.Size = new System.Drawing.Size(181, 25);
            this.eBinarySearchTeleButton.TabIndex = 18;
            this.eBinarySearchTeleButton.Text = "Binary Search Telephone";
            this.eBinarySearchTeleButton.UseVisualStyleBackColor = true;
            this.eBinarySearchTeleButton.Visible = false;
            this.eBinarySearchTeleButton.Click += new System.EventHandler(this.eBinarySearchTeleButton_Click);
            // 
            // eSearchLastNameButton
            // 
            this.eSearchLastNameButton.Enabled = false;
            this.eSearchLastNameButton.Location = new System.Drawing.Point(20, 222);
            this.eSearchLastNameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eSearchLastNameButton.Name = "eSearchLastNameButton";
            this.eSearchLastNameButton.Size = new System.Drawing.Size(155, 25);
            this.eSearchLastNameButton.TabIndex = 17;
            this.eSearchLastNameButton.Text = "Search Last Name";
            this.eSearchLastNameButton.UseVisualStyleBackColor = true;
            this.eSearchLastNameButton.Visible = false;
            this.eSearchLastNameButton.Click += new System.EventHandler(this.eSearchLastNameButton_Click);
            // 
            // eSaveChangesButton
            // 
            this.eSaveChangesButton.BackColor = System.Drawing.Color.Lime;
            this.eSaveChangesButton.Enabled = false;
            this.eSaveChangesButton.Location = new System.Drawing.Point(435, 128);
            this.eSaveChangesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eSaveChangesButton.Name = "eSaveChangesButton";
            this.eSaveChangesButton.Size = new System.Drawing.Size(155, 25);
            this.eSaveChangesButton.TabIndex = 16;
            this.eSaveChangesButton.Text = "Save Changes";
            this.eSaveChangesButton.UseVisualStyleBackColor = false;
            this.eSaveChangesButton.Visible = false;
            this.eSaveChangesButton.Click += new System.EventHandler(this.eSaveChangesButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "GPA";
            // 
            // eGPATB
            // 
            this.eGPATB.Enabled = false;
            this.eGPATB.Location = new System.Drawing.Point(295, 128);
            this.eGPATB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eGPATB.Name = "eGPATB";
            this.eGPATB.Size = new System.Drawing.Size(72, 22);
            this.eGPATB.TabIndex = 3;
            this.eGPATB.TextChanged += new System.EventHandler(this.eGPATB_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Telephone Number";
            // 
            // eTelephoneNumberTB
            // 
            this.eTelephoneNumberTB.Enabled = false;
            this.eTelephoneNumberTB.Location = new System.Drawing.Point(20, 128);
            this.eTelephoneNumberTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eTelephoneNumberTB.Name = "eTelephoneNumberTB";
            this.eTelephoneNumberTB.Size = new System.Drawing.Size(239, 22);
            this.eTelephoneNumberTB.TabIndex = 2;
            this.eTelephoneNumberTB.TextChanged += new System.EventHandler(this.eTelephoneNumberTB_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Student First Name";
            // 
            // eLastNameTB
            // 
            this.eLastNameTB.Enabled = false;
            this.eLastNameTB.Location = new System.Drawing.Point(295, 68);
            this.eLastNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eLastNameTB.Name = "eLastNameTB";
            this.eLastNameTB.Size = new System.Drawing.Size(239, 22);
            this.eLastNameTB.TabIndex = 1;
            this.eLastNameTB.TextChanged += new System.EventHandler(this.eLastNameTB_TextChanged);
            // 
            // eFirstNameTB
            // 
            this.eFirstNameTB.Enabled = false;
            this.eFirstNameTB.Location = new System.Drawing.Point(20, 68);
            this.eFirstNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eFirstNameTB.Name = "eFirstNameTB";
            this.eFirstNameTB.Size = new System.Drawing.Size(239, 22);
            this.eFirstNameTB.TabIndex = 0;
            this.eFirstNameTB.TextChanged += new System.EventHandler(this.eFirstNameTB_TextChanged);
            // 
            // ePreviousButton
            // 
            this.ePreviousButton.Enabled = false;
            this.ePreviousButton.Location = new System.Drawing.Point(387, 16);
            this.ePreviousButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ePreviousButton.Name = "ePreviousButton";
            this.ePreviousButton.Size = new System.Drawing.Size(89, 26);
            this.ePreviousButton.TabIndex = 3;
            this.ePreviousButton.Text = "Previous";
            this.ePreviousButton.UseVisualStyleBackColor = true;
            this.ePreviousButton.Click += new System.EventHandler(this.ePreviousButton_Click);
            // 
            // eNextButton
            // 
            this.eNextButton.Enabled = false;
            this.eNextButton.Location = new System.Drawing.Point(500, 16);
            this.eNextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eNextButton.Name = "eNextButton";
            this.eNextButton.Size = new System.Drawing.Size(89, 26);
            this.eNextButton.TabIndex = 2;
            this.eNextButton.Text = "Next";
            this.eNextButton.UseVisualStyleBackColor = true;
            this.eNextButton.Click += new System.EventHandler(this.eNextButton_Click);
            // 
            // eDisplaySortedButton
            // 
            this.eDisplaySortedButton.Enabled = false;
            this.eDisplaySortedButton.Location = new System.Drawing.Point(117, 16);
            this.eDisplaySortedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eDisplaySortedButton.Name = "eDisplaySortedButton";
            this.eDisplaySortedButton.Size = new System.Drawing.Size(142, 26);
            this.eDisplaySortedButton.TabIndex = 1;
            this.eDisplaySortedButton.Text = "Display All Sorted";
            this.eDisplaySortedButton.UseVisualStyleBackColor = true;
            this.eDisplaySortedButton.Click += new System.EventHandler(this.eDisplaySortedButton_Click);
            // 
            // eDisplayAllButton
            // 
            this.eDisplayAllButton.Enabled = false;
            this.eDisplayAllButton.Location = new System.Drawing.Point(20, 16);
            this.eDisplayAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eDisplayAllButton.Name = "eDisplayAllButton";
            this.eDisplayAllButton.Size = new System.Drawing.Size(89, 26);
            this.eDisplayAllButton.TabIndex = 0;
            this.eDisplayAllButton.Text = "Display All";
            this.eDisplayAllButton.UseVisualStyleBackColor = true;
            this.eDisplayAllButton.Click += new System.EventHandler(this.eDisplayAllButton_Click);
            // 
            // displayTab
            // 
            this.displayTab.Controls.Add(this.dDisplayAreaTextBox);
            this.displayTab.Controls.Add(this.dShowAllAboveGPATextBox);
            this.displayTab.Controls.Add(this.dShowAllAboveGPAButton);
            this.displayTab.Controls.Add(this.dPrintButton);
            this.displayTab.Controls.Add(this.dShowSortedByLastNameButton);
            this.displayTab.Location = new System.Drawing.Point(4, 25);
            this.displayTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayTab.Name = "displayTab";
            this.displayTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayTab.Size = new System.Drawing.Size(612, 373);
            this.displayTab.TabIndex = 3;
            this.displayTab.Text = "Display";
            this.displayTab.UseVisualStyleBackColor = true;
            this.displayTab.Click += new System.EventHandler(this.displayTab_Click);
            this.displayTab.Enter += new System.EventHandler(this.displayTab_Enter);
            // 
            // dDisplayAreaTextBox
            // 
            this.dDisplayAreaTextBox.Location = new System.Drawing.Point(12, 52);
            this.dDisplayAreaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dDisplayAreaTextBox.Multiline = true;
            this.dDisplayAreaTextBox.Name = "dDisplayAreaTextBox";
            this.dDisplayAreaTextBox.Size = new System.Drawing.Size(588, 307);
            this.dDisplayAreaTextBox.TabIndex = 4;
            // 
            // dShowAllAboveGPATextBox
            // 
            this.dShowAllAboveGPATextBox.Enabled = false;
            this.dShowAllAboveGPATextBox.Location = new System.Drawing.Point(532, 17);
            this.dShowAllAboveGPATextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dShowAllAboveGPATextBox.Name = "dShowAllAboveGPATextBox";
            this.dShowAllAboveGPATextBox.Size = new System.Drawing.Size(68, 22);
            this.dShowAllAboveGPATextBox.TabIndex = 3;
            // 
            // dShowAllAboveGPAButton
            // 
            this.dShowAllAboveGPAButton.Enabled = false;
            this.dShowAllAboveGPAButton.Location = new System.Drawing.Point(353, 12);
            this.dShowAllAboveGPAButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dShowAllAboveGPAButton.Name = "dShowAllAboveGPAButton";
            this.dShowAllAboveGPAButton.Size = new System.Drawing.Size(171, 32);
            this.dShowAllAboveGPAButton.TabIndex = 2;
            this.dShowAllAboveGPAButton.Text = "Show all above GPA of: ";
            this.dShowAllAboveGPAButton.UseVisualStyleBackColor = true;
            this.dShowAllAboveGPAButton.Click += new System.EventHandler(this.dShowAllAboveGPAButton_Click);
            // 
            // dPrintButton
            // 
            this.dPrintButton.Enabled = false;
            this.dPrintButton.Location = new System.Drawing.Point(233, 12);
            this.dPrintButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dPrintButton.Name = "dPrintButton";
            this.dPrintButton.Size = new System.Drawing.Size(112, 32);
            this.dPrintButton.TabIndex = 1;
            this.dPrintButton.Text = "Print";
            this.dPrintButton.UseVisualStyleBackColor = true;
            this.dPrintButton.Click += new System.EventHandler(this.dPrintButton_Click);
            // 
            // dShowSortedByLastNameButton
            // 
            this.dShowSortedByLastNameButton.Enabled = false;
            this.dShowSortedByLastNameButton.Location = new System.Drawing.Point(12, 12);
            this.dShowSortedByLastNameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dShowSortedByLastNameButton.Name = "dShowSortedByLastNameButton";
            this.dShowSortedByLastNameButton.Size = new System.Drawing.Size(213, 32);
            this.dShowSortedByLastNameButton.TabIndex = 0;
            this.dShowSortedByLastNameButton.Text = "Show All Sorted by Last Name";
            this.dShowSortedByLastNameButton.UseVisualStyleBackColor = true;
            this.dShowSortedByLastNameButton.Click += new System.EventHandler(this.dShowSortedByLastNameButton_Click);
            // 
            // binarySearchTelephoneTB
            // 
            this.binarySearchTelephoneTB.Location = new System.Drawing.Point(295, 263);
            this.binarySearchTelephoneTB.Name = "binarySearchTelephoneTB";
            this.binarySearchTelephoneTB.Size = new System.Drawing.Size(181, 22);
            this.binarySearchTelephoneTB.TabIndex = 19;
            this.binarySearchTelephoneTB.Visible = false;
            this.binarySearchTelephoneTB.TextChanged += new System.EventHandler(this.binarySearchTelephoneTB_TextChanged);
            // 
            // searchLastNameTB
            // 
            this.searchLastNameTB.Location = new System.Drawing.Point(20, 263);
            this.searchLastNameTB.Name = "searchLastNameTB";
            this.searchLastNameTB.Size = new System.Drawing.Size(155, 22);
            this.searchLastNameTB.TabIndex = 20;
            this.searchLastNameTB.Visible = false;
            this.searchLastNameTB.TextChanged += new System.EventHandler(this.searchLastNameTB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 417);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "LINQ Tabs";
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mToolStrip.ResumeLayout(false);
            this.mToolStrip.PerformLayout();
            this.dataEntryTab.ResumeLayout(false);
            this.dataEntryTab.PerformLayout();
            this.editTab.ResumeLayout(false);
            this.editTab.PerformLayout();
            this.displayTab.ResumeLayout(false);
            this.displayTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage dataEntryTab;
        private System.Windows.Forms.TabPage editTab;
        private System.Windows.Forms.TabPage displayTab;
        private System.Windows.Forms.Button mSaveFileButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mReadFileTextBox;
        private System.Windows.Forms.Button mReadFileButton;
        private System.Windows.Forms.ToolStrip mToolStrip;
        private System.Windows.Forms.ToolStripLabel mOpenFile;
        private System.Windows.Forms.ToolStripLabel mExit;
        private System.Windows.Forms.Button deAddToListButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deNumOfItemsInListTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deGPATB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deTelephoneNumberTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deLastNameTB;
        private System.Windows.Forms.TextBox deFirstNameTB;
        private System.Windows.Forms.Button eBinarySearchTeleButton;
        private System.Windows.Forms.Button eSearchLastNameButton;
        private System.Windows.Forms.Button eSaveChangesButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox eGPATB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox eTelephoneNumberTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox eLastNameTB;
        private System.Windows.Forms.TextBox eFirstNameTB;
        private System.Windows.Forms.Button ePreviousButton;
        private System.Windows.Forms.Button eNextButton;
        private System.Windows.Forms.Button eDisplaySortedButton;
        private System.Windows.Forms.Button eDisplayAllButton;
        private System.Windows.Forms.TextBox dDisplayAreaTextBox;
        private System.Windows.Forms.TextBox dShowAllAboveGPATextBox;
        private System.Windows.Forms.Button dShowAllAboveGPAButton;
        private System.Windows.Forms.Button dPrintButton;
        private System.Windows.Forms.Button dShowSortedByLastNameButton;
        private System.Windows.Forms.TextBox searchLastNameTB;
        private System.Windows.Forms.TextBox binarySearchTelephoneTB;
    }
}

