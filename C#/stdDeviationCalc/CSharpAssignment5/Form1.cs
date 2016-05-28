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
CLASS: CSCI 3228 ASSIGNMENT #: 5
DATE DUE: 10/19/2015 DATE TURNED IN: 10/17/15
*/

namespace CSharpAssignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToArray_Click(object sender, EventArgs e)
        {
            //read in all the values from the input line and stick them into an array of type int
            int[] scores = Array.ConvertAll(scoresInputBox.Text.Split(' '), element => Convert.ToInt32(element)) ;

            //resets
            int sumV = 0;
            double avg = 0;
            double sumD = 0;
            scoresOutput.Text = "";

            //print out all data retreived and gets the sum of all values in the scores array
            for (int i=0; i<scores.Length;i++)
            {
                scoresOutput.AppendText(scores[i] + "\n");
                sumV += scores[i];
            }  

            //prints number of scores
            noOfScores.Text = Convert.ToString(scores.Length);

            //print the sum of the scores
            sum.Text = Convert.ToString(sumV);

            //prints the average
            avg = (double)sumV / scores.Length;
            average.Text = String.Format("{0:N}", avg );

            //prints sum of Dev Sq [for all x in array((x - avg)^2)= sumD]
            for(int i=0; i<scores.Length;i++)
                sumD += Math.Pow((scores[i]-(avg)), 2);
            sumOfDevSq.Text = String.Format("{0:N}", sumD );

            //prints Std Dev [((sumD)/amount of scores-1)^(1/2)]
            stdDev.Text = String.Format( "{0:N}",  (Math.Pow((sumD/(scores.Length-1)),(.5))) );
        }

        private void average_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
