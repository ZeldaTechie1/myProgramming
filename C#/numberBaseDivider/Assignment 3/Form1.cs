using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
PROGRAMMERS NAME: Bryan Cancel
STUDENT ID: 20266067
CLASS: 3328-01 ASSIGNMENT #: 3
DATE DUE: 9/28/15 DATE TURNED IN: 9/18/15
*/

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        string input;
        char ones;
        char tens;
        char hundreds;
        string thousands;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //input text box
        {

        }

        private void button1_Click(object sender, EventArgs e) //break up button
        {
            //SPLIT THE INPUT GIVEN BY THE USER
            input = textBox2.Text;
            int size = input.Length; //provide stop value for for loop that splits up input

            //get the char at the correct location for the first 3 and first assign to vars so then can be used later to print to file
            if (size >= 1)
                ones = input[size-1];
            if (size >= 2)
                tens = input[size - 2];
            if (size >= 3)
                hundreds = input[size - 3];
            if (size >= 4)//for the last one get the remain characters and those form the thousands for example (23,444) has 23 thousands
                thousands = input.Substring(0, size - 3);

            //actually print the info to the textboxes
            textBox6.Text= Convert.ToString(ones);
            textBox4.Text = Convert.ToString(tens);
            textBox8.Text = Convert.ToString(hundreds);
            textBox10.Text = Convert.ToString(thousands);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox10_TextChanged(object sender, EventArgs e) //thousands section
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e) //hundreds section
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) //tens section
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) //ones section
        {

        }

        private void button3_Click(object sender, EventArgs e) //save button
        {
            //create a string array with each line that we are printing
            string[] lines = { "Number Entered: "+input, "Thousands: "+thousands, "Hundreds: "+hundreds, "Tens: "+tens, "Ones: "+ones};
            
            //print the lines in our txt file
            System.IO.File.WriteAllLines(@"lab1.txt", lines); //THE FILE IS SET TO APPEAR IN THE DIRECTORY BELOW (relative to where you unzipped the folder ofcourse)
            //Assignment 3/Assignment 3/Assignment 3/bin/Debug/lab1.txt
        }
    }
}
