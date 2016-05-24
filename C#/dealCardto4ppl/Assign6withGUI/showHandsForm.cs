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
PROGRAMMERS NAME:Bryan Cancel
STUDENT ID:20266067
CLASS:CSCI 3228 ASSIGNMENT #:6
DATE DUE:11/2/15 DATE TURNED IN:11/2/15*/

namespace Assignment6CSharp
{
    public partial class showHandsForm : Form
    {
        mainForm main;

        public showHandsForm(mainForm m)//constructor that allows us to retreive data from the anther from
        {
            InitializeComponent();
            main = m;

            //print the info onto the p#Deck areas
            for (int i = 0; i < main.allCardsArr.Length; i += 4)
            {
                if((i+4) != main.allCardsArr.Length)
                {
                    p1Deck.AppendText(main.allCardsArr[i] + " ");
                    p2Deck.AppendText(main.allCardsArr[i + 1] + " ");
                    p3Deck.AppendText(main.allCardsArr[i + 2] + " ");
                    p4Deck.AppendText(main.allCardsArr[i + 3] + " ");
                }
                else
                {
                    p1Deck.AppendText(main.allCardsArr[i]);
                    p2Deck.AppendText(main.allCardsArr[i + 1]);
                    p3Deck.AppendText(main.allCardsArr[i + 2]);
                    p4Deck.AppendText(main.allCardsArr[i + 3]);
                }

            }
        }

        private void showHandsForm_Load(object sender, EventArgs e)
        {

        }
        int iteration=0;

        private string[] mergeSort(string[] p)//recursive merge sort, iterative is quicker but I dont have time and rather do the bonus
        {
            if (p.Length == 1)//base case
                return p;
            else
            {
                //create two new arrays that will be passed into merge sort
                string[] p1 = new string[p.Length/2];
                string[] p2;

                //change the size of the second array depending on wether the length of the array currently passed is odd or even (remember truncation)
                if (p.Length % 2 == 0)
                    p2 = new string[(p.Length/2)];//if length is even
                else
                    p2 = new string[(p.Length/2)+1];//if length is odd

                //copy values over from array passed to respective array
                for (int i = 0, j = 0 ; i < p.Length; i++)
                {
                    if (i < (p.Length / 2))
                        p1[i] = p[i];
                    else
                    {
                        p2[j] = p[i];
                        j++;
                    }
                }

                //sort both arrays
                p1=mergeSort(p1);
                p2=mergeSort(p2);

                //organize the 2 smaller arrays values by placing them in order into the larger array
                for (int i=0; i<p.Length; i++)//going for length of p because it a guarantee that the two smaller arrays will fill up the big one
                {
                    char[] temp1;
                    char[] temp2;

                    if (p1.Length!=0 && p2.Length!=0)//if the indexes for each halve still are smaller than their perspectives length then we still have to compare values from the two
                    {
                        //create temp char arrays for the specific card to so we can access the face value and the acutal value from the cards independantly in order to do accurate comparisons
                        temp1 = (p1[0]).ToCharArray();
                        temp2 = (p2[0]).ToCharArray();

                        if (temp1[0] < temp2[0]) //if the letter in temp1 is smaller than that should go first
                        {
                            p[i] = p1[0];
                            p1 = p1.Where(w => w != p1[0]).ToArray();//remove the value that was just used
                        }
                        else if (temp1[0] > temp2[0]) //if the letter in temp2 is smaller than that should go first
                        {
                            p[i] = p2[0];
                            p2 = p2.Where(w => w != p2[0]).ToArray();//remove the value that was just used
                        }
                        else //we need to check the value of the card because its face values are the same
                        {
                            //conver exception of chars that arent really in ascii value order in reality by "mapping"
                            //map A to 0, 10 to :, K to R

                            //values I need to create for comparison due to exceptions
                            char comp1;
                            char comp2;

                            //cover exceptions for temp1
                            if (temp1[1] == 'A')
                                comp1 = '0';
                            else if (temp1[1] == '1')
                                comp1 = ':';
                            else if (temp1[1] == 'K')
                                comp1 = 'R';
                            else
                                comp1 = temp1[1];

                            if (temp2[1] == 'A')
                                comp2 = '0';
                            else if (temp2[1] == '1')
                                comp2 = ':';
                            else if (temp2[1] == 'K')
                                comp2 = 'R';
                            else
                                comp2 = temp2[1];

                            if (comp1 <= comp2)
                            {
                                p[i]=p1[0];
                                p1 = p1.Where(w => w != p1[0]).ToArray();//remove the value that was just used
                            }
                            else
                            {
                                p[i] = p2[0];
                                p2 = p2.Where(w => w != p2[0]).ToArray();//remove the value that was just used
                            }
                        }
                    }
                    else
                    {
                        if (p1.Length != 0)
                        {
                            p[i] = p1[0];
                            p1 = p1.Where(w => w != p1[0]).ToArray();//remove the value that was just used
                        }
                        else
                        {
                            p[i] = p2[0];
                            p2 = p2.Where(w => w != p2[0]).ToArray();//remove the value that was just used
                        }
                    }
                }
                return p;
            }
        }

        private void arrangeCardsButton_Click(object sender, EventArgs e)
        {
            //sorts each of the arrays
            string[] p1 = mergeSort((p1Deck.Text).Split(' ').ToArray());
            string[] p2 = mergeSort((p2Deck.Text).Split(' ').ToArray());
            string[] p3 = mergeSort((p3Deck.Text).Split(' ').ToArray());
            string[] p4 = mergeSort((p4Deck.Text).Split(' ').ToArray());

            //reset all the values so you can do a clean print
            p1Deck.Text = "";
            p2Deck.Text = "";
            p3Deck.Text = "";
            p4Deck.Text = "";

            //prints out the sorted values
            foreach (string x in p1)
                p1Deck.AppendText(x+" ");
            foreach (string x in p2)
                p2Deck.AppendText(x + " ");
            foreach (string x in p3)
                p3Deck.AppendText(x + " ");
            foreach (string x in p4)
                p4Deck.AppendText(x + " ");

            //once sorted you dont need to sort twice so elim this option
            arrangeCardsButton.Enabled = false;
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            //goes back to previous form and resets all value so a new "game" can start
            main.fullReset();
            this.Close();
        }
    }
}
