using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
PROGRAMMERS NAME:Bryan Cancel
STUDENT ID:20266067
CLASS:CSCI 33228-01 ASSIGNMENT #:4
DATE DUE:10/12/15 DATE TURNED IN:10/3/15
*/

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //make variables from all the data in the text feild to make life easier
            double initial = Convert.ToDouble(initialDeposit.Text);
            double deposit = Convert.ToDouble(depositEvery.Text);
            double interest = (Convert.ToDouble(rateOf.Text)/100);
            int initialAge = Convert.ToInt32(ageWhen.Text);
            int retireAge = Convert.ToInt32(retirementAge.Text);
            
            //FOR TESTING PURPOSES... PLEASE IGNORE (I dont like pluging in numbers over and over again)
            /*double initial = 3000.00;
            double deposit = 250.00;
            double interest = .085;
            int initialAge = 26;
            int retireAge = 65;*/

            //Vars used int he loop
            double endBal=0;
            double begBal;
            double yearlyInterest;

            //EQUATION: inital(1+(interest/12))^(12*years)

            //loop that keeps going until
            for (int currAge = initialAge; currAge<=retireAge; currAge++)
            {
                //loop to check if we are in a "multiple" of the initialAge+10 where you would print the lines bellow
                for (int c = initialAge; c <= retireAge; c+=10 )
                {
                    if(c==currAge)//if its a multiple print the lines below
                    {
                        printDataBox.AppendText(string.Format("{0}\n","===================================================================="));
                        printDataBox.AppendText(string.Format("{0,0}{1,25}{2,25}{3,25}{4,25}\n", "Age", "Beg Balance", "Yearly Int", "Yearly Dep", "Ending Bal"));
                        printDataBox.AppendText(string.Format("{0}\n","===================================================================="));
                    }
                }

                //SET VARS THAT WILL BE USED IN THE PRINT
                double yearlyDepo = (deposit * 12); //var dependant on whether or not its the 6th year, 12*deposit is its regular value
                for (int c = initialAge-1; c <= retireAge; c += 6)//loop to check if we are in a "multiple" of the initialAge+6
                {
                    if (c==currAge && currAge!=initialAge)//deposit 13 times instead of 12 every 6th day EXCLUDE the first day
                        yearlyDepo = (deposit * 13);//we deposit for an extra months for reasons unknown
                }

                if (endBal == 0)
                    begBal = initial;
                else
                    begBal = endBal;

                yearlyInterest = (initial * Math.Pow((1 + (interest / 12)), (12 * (currAge - initialAge + 1))))-initial;
                endBal = yearlyInterest + begBal + yearlyDepo;
                printDataBox.AppendText(string.Format("{0,0:00}{1,25:0,000,000.00}{2,25:00,000.00}{3,25:0,000.00}{4,25:0,000,000.00}\n", currAge, begBal, yearlyInterest, yearlyDepo, endBal));//print all the desired info
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printDataBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
