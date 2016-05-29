using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Drawing.Printing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
PROGRAMMERS NAME: Bryan Cancel
STUDENT ID: 20266067
CLASS: CSCI3228 ASSIGNMENT #: 10
DATE DUE: 12/7/2015 DATE TURNED IN: 12/7/2015
*/

namespace Assignment10
{
    //strudent struct
    struct student
    {
        private string firstName;
        private string lastName;
        private string telephone;
        private double gpa;
        private int originalPos;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public int OriginalPos
        {
            get { return originalPos; }
            set { originalPos = value; }
        }

        public string flPrint()
        {
            return firstName + " " + lastName +" " + telephone + " " + gpa;
        }

        public string lfPrint()
        {
            return lastName + "," + firstName + " " + telephone + " " + gpa;
        }
    }

    public partial class Form1 : Form
    {
        string filePath;
        List<student> studentList= new List<student>();

        public Form1()
        {
            InitializeComponent();
        }

        //UNUSED

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void mainTab_Enter(object sender, EventArgs e)
        {

        }

        private void mainTab_Click(object sender, EventArgs e)
        {

        }

        private void dataEntryTab_Click(object sender, EventArgs e)
        {

        }

        private void editTab_Click(object sender, EventArgs e)
        {

        }

        private void displayTab_Click(object sender, EventArgs e)
        {

        }

        //INDIVIDUAL TAB ENTERING

        private void dataEntryTab_Enter(object sender, EventArgs e)
        {
            deFirstNameTB.Text = "";
            deLastNameTB.Text = "";
            deTelephoneNumberTB.Text = "";
            deGPATB.Text = "";
            deNumOfItemsInListTB.Text = "";
        }

        private void editTab_Enter(object sender, EventArgs e)
        {
            ePreviousButton.Enabled = false;
            eNextButton.Enabled = false;
            eFirstNameTB.Text = "";
            eLastNameTB.Text = "";
            eTelephoneNumberTB.Text = "";
            eGPATB.Text = "";
            eSaveChangesButton.Visible = false;
            changesMade = false;
            currChangesMade = false;
            editTabList.Clear();
            editTabCount = 0;
        }

        private void displayTab_Enter(object sender, EventArgs e)
        {
            //print out the array of structs
            dDisplayAreaTextBox.Text = "";
            foreach (student s in studentList)//SPACE OUT
                dDisplayAreaTextBox.AppendText(s.flPrint() + "\n");
        }

        //MAIN TAB

        private void mOpenFile_Click(object sender, EventArgs e)
        {
            //opens the file browser and reads in the filepath
            OpenFileDialog FBD = new OpenFileDialog();
            FBD.ShowDialog();
            filePath = FBD.FileName;

            mReadFileTextBox.Text = filePath;
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mReadFileButton_Click(object sender, EventArgs e)//FINISH
        {
            studentList.Clear();
            if (mReadFileTextBox.Text == "") //if a file hasnt been selected
            {
                MessageBox.Show("Please Select your File");
                /*
                //since Im using a "default" file name
                if (true)//the file with the file path I want already exsist then
                    ;//erase everything w/.Flush();
                else
                    ;//create the file
                */
            }
            else //read in the data
            {
                //open the file and read into a list of structs
                System.IO.StreamReader fileRead = new System.IO.StreamReader(filePath);
                string line;
                while ((line = fileRead.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    student s = new student();
                    s.FirstName = words[0];
                    s.LastName = words[1];
                    s.Telephone = words[2];
                    s.Gpa = Convert.ToDouble(words[3]);
                    s.OriginalPos = studentList.Count;
                    studentList.Add(s);
                }
                fileRead.Close();
            }

            //ACTIVATE CONTROLS
            //main
            mSaveFileButton.Enabled = true;
            //data entry
            deFirstNameTB.Enabled = true;
            deLastNameTB.Enabled = true;
            deTelephoneNumberTB.Enabled = true;
            deGPATB.Enabled = true;
            deAddToListButton.Enabled = true;
            //edit
            eDisplayAllButton.Enabled = true;
            eDisplaySortedButton.Enabled = true;
            eSearchLastNameButton.Enabled = true;
            eBinarySearchTeleButton.Enabled = true;
            eSaveChangesButton.Enabled = true;//NOT SURE
            eFirstNameTB.Enabled = true;
            eLastNameTB.Enabled = true;
            eTelephoneNumberTB.Enabled = true;
            eGPATB.Enabled = true;
            //display
            dShowSortedByLastNameButton.Enabled = true;
            dPrintButton.Enabled = true;
            dShowAllAboveGPATextBox.Enabled = true;
            dShowAllAboveGPAButton.Enabled = true;
        }

        private void mSaveFileButton_Click(object sender, EventArgs e)
        {
            //use the array of structs to first erase whats currently in the file and the write the new information
            System.IO.StreamWriter fileWrite = new System.IO.StreamWriter(filePath);
            fileWrite.Flush();
            foreach (student s in studentList)
                fileWrite.WriteLine(s.flPrint());
            fileWrite.Close();
        }

        //DATA ENTRY TAB

        private void deAddToListButton_Click(object sender, EventArgs e)
        {
            //make sure all data fields are filled out
            if (deFirstNameTB.Text != "" && deLastNameTB.Text != "" && deTelephoneNumberTB.Text != "" && deGPATB.Text != "")
            {
                //grab info and place it into an array of the structs
                student s = new student();
                s.FirstName = deFirstNameTB.Text;
                s.LastName = deLastNameTB.Text;
                s.Telephone = deTelephoneNumberTB.Text;
                s.Gpa = Convert.ToDouble(deGPATB.Text);
                s.OriginalPos = studentList.Count;
                studentList.Add(s);

                deNumOfItemsInListTB.Text = Convert.ToString(studentList.Count);
            }
            else
                MessageBox.Show("Finish filling out the Info for the student before adding the student");
        }

        //EDIT TAB (Everytime this starts up it should show nothing in the text boxes and no list should be selected)
        
        int editTabCount = 0;
        List<student> editTabList = new List<student>();
        Boolean changesMade = false;
        Boolean currChangesMade = false;

        //detects changes in the text to make save changes button appear

        private void eFirstNameTB_TextChanged(object sender, EventArgs e)
        {
            eSaveChangesButton.Visible = true;
            currChangesMade = true;
        }

        private void eLastNameTB_TextChanged(object sender, EventArgs e)
        {
            eSaveChangesButton.Visible = true;
            currChangesMade = true;
        }

        private void eTelephoneNumberTB_TextChanged(object sender, EventArgs e)
        {
            eSaveChangesButton.Visible = true;
            currChangesMade = true;
        }

        private void eGPATB_TextChanged(object sender, EventArgs e)
        {
            eSaveChangesButton.Visible = true;
            currChangesMade = true;
        }

        //my own function used by various buttons

        private void setInfoAt(int n)
        {
            eFirstNameTB.Text = editTabList.ElementAt(n).FirstName;
            eLastNameTB.Text = editTabList.ElementAt(n).LastName;
            eTelephoneNumberTB.Text = editTabList.ElementAt(n).Telephone;
            eGPATB.Text = Convert.ToString(editTabList.ElementAt(n).Gpa);

            currChangesMade = false;
        }

        private void saveCurrChanges()
        {
            student newStudent = new student();
            newStudent.FirstName = eFirstNameTB.Text;
            newStudent.LastName = eLastNameTB.Text;
            newStudent.Telephone = eTelephoneNumberTB.Text;
            newStudent.Gpa = Convert.ToDouble(eGPATB.Text);
            newStudent.OriginalPos = editTabList.ElementAt(editTabCount).OriginalPos;

            editTabList.RemoveAt(editTabCount);
            editTabList.Insert(editTabCount, newStudent);

            changesMade = true;
            currChangesMade = false;
        }

        private void globalSave()
        {
            saveCurrChanges();

            //update the local List using the originalPos
            updateLocalList();

            //save changes from whatever temp into our actual list
            studentList.Clear();
            studentList = editTabList;

            eSaveChangesButton.Visible = false;
            changesMade = false;
        }

        private void updateLocalList()
        {
            var update = from student in editTabList
                         orderby student.OriginalPos
                         select student;
            editTabList = update.ToList<student>();
        }

        private void specialSaveCurrChanges()
        {
            student newStudent = new student();
            newStudent.FirstName = eFirstNameTB.Text;
            newStudent.LastName = eLastNameTB.Text;
            newStudent.Telephone = eTelephoneNumberTB.Text;
            newStudent.Gpa = Convert.ToDouble(eGPATB.Text);
            newStudent.OriginalPos = editTabList.ElementAt(editTabCount).OriginalPos;

            editTabList.RemoveAt(newStudent.OriginalPos);
            editTabList.Insert(newStudent.OriginalPos, newStudent);

            changesMade = false;
            currChangesMade = false;

            globalSave();
        }

        //buttons clicks in the tab

        private void eDisplayAllButton_Click(object sender, EventArgs e)
        {
            ePreviousButton.Enabled = false;

            if (editTabList.Count == 0)
                editTabList = studentList;

            //save if changes exsist
            if ((eFirstNameTB.Text != "" && eLastNameTB.Text != "" && eTelephoneNumberTB.Text != "" && eGPATB.Text != "") && currChangesMade == true)
                saveCurrChanges();
            editTabList = studentList;

            //update the local List using the originalPos
            updateLocalList();

            //sort
            var sorted = from student in editTabList
                         select student;
            editTabList = sorted.ToList<student>();

            //"display" all the items in the list in order so that prev goes to the previous item if it exsist and same applies for next (with temp)
            editTabCount = 0;
            setInfoAt(editTabCount);

            eNextButton.Enabled = true;
            if (changesMade == false)
                eSaveChangesButton.Visible = false;
        }

        private void eDisplaySortedButton_Click(object sender, EventArgs e)
        {

            ePreviousButton.Enabled = false;

            if (editTabList.Count == 0)
                editTabList = studentList;

            //save if changes exsist
            if ((eFirstNameTB.Text != "" && eLastNameTB.Text != "" && eTelephoneNumberTB.Text != "" && eGPATB.Text != "") && currChangesMade == true)
                saveCurrChanges();
            editTabList = studentList;

            //update the local List using the originalPos
            updateLocalList();

            //sort
            var sorted = from student in editTabList
                         orderby student.LastName
                         select student;
            editTabList = sorted.ToList<student>();

            //"display" all the items in the list in order so that prev goes to the previous item if it exsist and same applies for next (with temp)
            editTabCount = 0;
            setInfoAt(editTabCount);

            eNextButton.Enabled = true;
            if(changesMade==false)
                eSaveChangesButton.Visible = false;
        }

        private void ePreviousButton_Click(object sender, EventArgs e)
        {
            if(currChangesMade==true)
                saveCurrChanges();

            //go to the previous item on the current list
            editTabCount--;
            setInfoAt(editTabCount);

            if (editTabCount == 0)
                ePreviousButton.Enabled = false;
            else
                ePreviousButton.Enabled = true;

            eNextButton.Enabled = true;

            if (changesMade == false)
                eSaveChangesButton.Visible = false;
        }

        private void eNextButton_Click(object sender, EventArgs e)
        {
            if (currChangesMade == true)
                saveCurrChanges();

            //go to the next item on the current list
            editTabCount++;
            setInfoAt(editTabCount);

            if (editTabCount+1 == editTabList.Count)
                eNextButton.Enabled = false;
            else
                eNextButton.Enabled = true;

            ePreviousButton.Enabled = true;

            if (changesMade == false)
                eSaveChangesButton.Visible = false;
        }

        //At the moment: All local changes save automatically, you must click save only to save permanently or globaly(global list is used in all other tabs)
        private void eSaveChangesButton_Click(object sender, EventArgs e)//NOT SPECIFIED WHEHTER SHOULD SAVE "local" CHANGES OR "global" changes
        {
            globalSave();
        }

        private void eSearchLastNameButton_Click(object sender, EventArgs e)//-EXCEPTION NEEDS TAKING CARE OFF
        {
            //clear all fields
            eFirstNameTB.Text = "";
            eLastNameTB.Text = "";
            eTelephoneNumberTB.Text = "";
            eGPATB.Text = "";

            ePreviousButton.Enabled = false;

            editTabList = studentList;

            //update the local List using the originalPos
            updateLocalList();

            //sort-only those with matching last names (GRAB is more appropriate than sort here)
            var sorted = from student in editTabList
                         where student.LastName == searchLastNameTB.Text
                         select student;

            editTabList = sorted.ToList<student>();

            if (changesMade == false)
                eSaveChangesButton.Visible = false;

            MessageBox.Show("Exit this popup and click 'next' to see the next student with that last name if more than one exist!");

            //"display" all the items in the list in order so that prev goes to the previous item if it exsist and same applies for next (with temp)
            editTabCount = 0;
            if (editTabList.Count != 0)
                setInfoAt(editTabCount);
            else
                MessageBox.Show("No Student Found with that LastName");


            if(editTabCount<=1)
                eNextButton.Enabled = false;
            else
                eNextButton.Enabled = true;
        }

        private void eBinarySearchTeleButton_Click(object sender, EventArgs e)//assumes no two people have the same phone number
        {
            MessageBox.Show("Ran out of Time");
            /*
            ePreviousButton.Enabled = false;

            editTabList = studentList;

            //update the local List using the originalPos
            updateLocalList();

            //sort-only those with matching last names
            var sorted = from student in editTabList
                         where student.Telephone == eTelephoneNumberTB.Text
                         select student;
            editTabList = sorted.ToList<student>();
            eNextButton.Enabled = false;

            //"display" all the items in the list in order so that prev goes to the previous item if it exsist and same applies for next (with temp)
            editTabCount = 0;
            if (editTabList.Count != 0)
                setInfoAt(editTabCount);
            else
                MessageBox.Show("No Student Found with that Number");

            if (changesMade == false)
                eSaveChangesButton.Visible = false;
            */
        }

        //DISPLAY TAB

        private void dShowSortedByLastNameButton_Click(object sender, EventArgs e)
        {
            var sorted = from student in studentList
                         orderby student.LastName
                         select student;

            //only show those above the certain GPA
            sorted.ToList<student>();

            dDisplayAreaTextBox.Text = "";
            foreach (student s in sorted)//SPACE OUT
                dDisplayAreaTextBox.AppendText(s.lfPrint() + "\n");
        }

        //Print start

        private void dPrintButton_Click(object sender, EventArgs e)//HOW OR WHAT TO PRINT NOT SPECIFIED
        {
            //currently prints what is in the dDisplayAreaTextBox (seems to only dispaly in .xps format) (I only get .xps and .oxps), *.Oxps shows in the thumbnail but not the reader I have(likely it doesnt show in .oxps because of the reader)
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170); // all sizes are converted from mm to inches & then multiplied by 100.
                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while printing", ex.ToString());
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
                ev.Graphics.DrawString(dDisplayAreaTextBox.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 12, 0);
        }

        //Print stop

        private void dShowAllAboveGPAButton_Click(object sender, EventArgs e)
        {
            try
            {
                var sorted = from student in studentList
                             where student.Gpa >= Convert.ToDouble(dShowAllAboveGPATextBox.Text)
                             select student;
                //only show those above the certain GPA
                sorted.ToList<student>();

                dDisplayAreaTextBox.Text = "";
                foreach (student s in sorted)//SPACE OUT
                    dDisplayAreaTextBox.AppendText(s.flPrint() + "\n");
            }
            catch
            {
                MessageBox.Show("Type in valid input for GPA");
            }
                
            
        }

        private void searchLastNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void binarySearchTelephoneTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
