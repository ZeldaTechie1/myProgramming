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
CLASS:CSCI 3228 ASSIGNMENT #:7
DATE DUE:11/2/15 DATE TURNED IN:11/2/15
*/

namespace Assignment6CSharp
{
    public partial class showHandsForm : Form
    {
        mainForm main;

        public showHandsForm(mainForm m)//constructor that allows us to retreive data from the anther from
        {
            InitializeComponent();
            main = m;

            PictureBox[] pB = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40, pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50, pictureBox51, pictureBox52 };
            for (int i = 0, j=0; i < 13; i++, j+=4)
            {
                pB[i].Image = Image.FromFile(Environment.CurrentDirectory + "\\cardImages\\" + main.allCardsArr[j] + ".png");
                pB[i+(13*1)].Image = Image.FromFile(Environment.CurrentDirectory + "\\cardImages\\" + main.allCardsArr[j+1] + ".png");
                pB[i+(13*2)].Image = Image.FromFile(Environment.CurrentDirectory + "\\cardImages\\" + main.allCardsArr[j+2] + ".png");
                pB[i+(13*3)].Image = Image.FromFile(Environment.CurrentDirectory + "\\cardImages\\" + main.allCardsArr[j+3] + ".png");
            }

            if(main.arrange==true)
            {
                main.p1 = mergeSort(main.p1);
                main.p2 = mergeSort(main.p2);
                main.p3 = mergeSort(main.p3);
                main.p4 = mergeSort(main.p4);


                //stick all the data from the individual hands of the players and put it together in order to be able to print it easily
                string[][] allP = new string[][] { main.p1, main.p2, main.p3, main.p4 };
                string[] allSorted = new string[52];
                for (int i = 0, j = 0, k = 0; i < allSorted.Length; i++, k++)
                {
                    if (i == 13 || i == 26 || i == 39)
                    {
                        j++;
                        k = 0;
                    }
                    allSorted[i] = allP[j][k];
                }

                PictureBox[] pB2 = new PictureBox[] { pictureBox104, pictureBox103, pictureBox102, pictureBox101, pictureBox100, pictureBox99, pictureBox98, pictureBox97, pictureBox96, pictureBox95, pictureBox94, pictureBox93, pictureBox92, pictureBox91, pictureBox90, pictureBox89, pictureBox88, pictureBox87, pictureBox86, pictureBox85, pictureBox84, pictureBox83, pictureBox82, pictureBox81, pictureBox80, pictureBox79, pictureBox78, pictureBox77, pictureBox76, pictureBox75, pictureBox74, pictureBox73, pictureBox72, pictureBox71, pictureBox70, pictureBox69, pictureBox68, pictureBox67, pictureBox66, pictureBox65, pictureBox64, pictureBox63, pictureBox62, pictureBox61, pictureBox60, pictureBox59, pictureBox58, pictureBox57, pictureBox56, pictureBox55, pictureBox54, pictureBox53 };
                for (int i = 0; i < allSorted.Length; i++)
                    pB2[i].Image = Image.FromFile(Environment.CurrentDirectory + "\\cardImages\\" + allSorted[i] + ".png");
            }

        }

        private void showHandsForm_Load(object sender, EventArgs e)
        {

        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
