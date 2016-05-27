using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

/*
PROGRAMMERS NAME: Bryan Cancel
STUDENT ID: 20266067
CLASS: CSCI 3328 ASSIGNMENT #: 9
DATE DUE: 12/2/15 DATE TURNED IN: 12/2/15
*/

namespace fileiostructlinq
{
    public partial class Form1 : Form
    {

        //strudent struct
        struct student
        {
            private string firstName;
            private string lastName;
            private string telephone;
            private double gpa;

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

            public string printAll()
            {
                return (firstName + "," + lastName + "," + telephone + "," + gpa);
            }

            public string printOriginal()
            {
                return (firstName + " " + lastName + " " + telephone + " " + gpa);
            }

            public string printName()
            {
                return (firstName + " " + lastName);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string filePath;
        List<student> studentList = new List<student>();

        private void chooseFile_Click(object sender, EventArgs e)
        {
            //opens the fiel browser and reads in the filepath
            OpenFileDialog FBD = new OpenFileDialog();
            FBD.ShowDialog();
            filePath = FBD.FileName;

            //once a file is selected, messageBox the file path using "Path.GetFullPath(fileName)"
            MessageBox.Show(filePath);
        }

        private void openRead_Click(object sender, EventArgs e)
        {
            if (filePath == null)
                MessageBox.Show("Please select a file first");
            else if (studentList.Count == 0)
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
                    if (s.FirstName == null)
                        MessageBox.Show("wtflip");
                    studentList.Add(s);
                }
                fileRead.Close();

                //messagebox of every student individually(using struct print)
                foreach(student s in studentList)
                    MessageBox.Show(s.printAll());
            }
            else
                MessageBox.Show("Already done");
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (filePath == null)
                MessageBox.Show("Please select a file first");
            else
            {
                //use the array of structs to first erase whats currently in the file and the write the new information
                System.IO.StreamWriter fileWrite = new System.IO.StreamWriter(filePath);
                fileWrite.Flush();
                foreach (student s in studentList)
                    fileWrite.WriteLine(s.printOriginal());
                fileWrite.Close();
            }
            
        }

        private void addInfoButton_Click(object sender, EventArgs e)
        {
            if (filePath == null)
                MessageBox.Show("Please select a file first");
            else if (fNTB.Text != "" && lNTB.Text != "" && teleTB.Text != "" && gpaTB.Text != "")
            {
                //grab info and place it into an array of the structs
                student s = new student();
                s.FirstName = fNTB.Text;
                s.LastName = lNTB.Text;
                s.Telephone = teleTB.Text;
                s.Gpa = Convert.ToDouble(gpaTB.Text);
                studentList.Add(s);
            }
            else
                MessageBox.Show("Finish filling out the Info before adding it");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (filePath == null)
                MessageBox.Show("Please select a file first");
            else
            {
                //print out the array of structs and output a dialog box with the name and number (spaced out)
                string all="";
                foreach (student s in studentList)//SPACE OUT
                    all += String.Format("{0,-35} {1,35}\n", (s.printName()), (s.Telephone));
                MessageBox.Show(all);
            }
        }

        private void findTeleButton_Click(object sender, EventArgs e)
        {
            if (filePath == null)
                MessageBox.Show("Please select a file first");
            else
            {
                //find the telephone of the person(s) with this lastname using linq
                var filter = from student in studentList
                             where student.LastName == findTeleTB.Text
                             select student;
                //message box with names and numbers that passed(spaced out)
                string total = "";
                foreach (student s in filter)
                    total = total + string.Format("{0,-35} {1,35}\n",s.printName(),s.Telephone);
                MessageBox.Show(total);
            }
        }

        private void findGPAButton_Click(object sender, EventArgs e)
        {
            if (filePath == null)
                MessageBox.Show("Please select a file first");
            else
            {
                //find those with a GPA >= the person whosse last name was given (this includes the person passed) use linq
                student temp = new student();
                foreach (student s in studentList)
                    if(s.LastName==findGPATB.Text)
                        temp = s;

                var filter = from student in studentList
                             where student.Gpa >= temp.Gpa
                             select student;

                //message box with names and numbers and gpa(spaced out)
                string total = "";
                foreach (student s in filter)
                    total = total + string.Format("{0,-35} {1,35} {2,35}\n",s.printName(), s.Telephone, s.Gpa);
                MessageBox.Show(total);
            }
        }
    }
}
