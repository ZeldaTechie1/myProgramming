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
DATE DUE:11/2/15 DATE TURNED IN:11/2/15
*/

namespace Assignment6CSharp
{
    public partial class mainForm : Form
    {
        public string[] allCardsArr;

        public mainForm()
        {
            InitializeComponent();
            fullReset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getNewDeckButton_Click(object sender, EventArgs e)
        {
            fullReset();
            shuffleButton.Enabled = true;
            //read in from a file and into an array of strings
            allCardsArr = (System.IO.File.ReadAllText(@"allCards.txt")).Split(' ').ToArray();
            //loop throught the array and print the values in the proper format onto the getNewDeckText area
            for(int i=0; i<allCardsArr.Length; i++)
            {
                getNewDeckText.AppendText(allCardsArr[i]+" ");
                if ((i+1)%13==0 && i!=0)
                    getNewDeckText.AppendText("\n");
            }

        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();//rnd number seed
            reset();//reset text that is in the text box
            dealButton.Enabled = true;

            string[] temp = new string[allCardsArr.Length];//make a temp based of off the size of the length of the array we are mixing
            for (int i=0;  i<52; i++)
            {
                int card = rnd.Next(allCardsArr.Length);// creates a number between 0 and 51
                temp[i] = allCardsArr[card];//grab the value in the random position on the main array and set it to the next location on the temp array or mixed array
                allCardsArr = allCardsArr.Where(w => w != allCardsArr[card]).ToArray();//remove the value that was just used out of our main array
            }
            allCardsArr = temp;//get rid of unmixed array copy info to temp array

            //print the info onto the suffleText area
            for (int i = 0; i < allCardsArr.Length; i++)
            {
                shuffleText.AppendText(allCardsArr[i] + " ");
                if ((i + 1) % 13 == 0 && i != 0)
                    shuffleText.AppendText("\n");
            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            resetDecks();
            showHandsButton.Enabled = true;
            //the shuffled card are now distributed one at a time in a round robin fashion to the four players (4 arrays) and display in their perspective p#DeckText area
            for(int i=0; i<allCardsArr.Length; i+=4)
            {
                p1Deck.AppendText(allCardsArr[i] + " ");
                p2Deck.AppendText(allCardsArr[i+1] + " ");
                p3Deck.AppendText(allCardsArr[i+2] + " ");
                p4Deck.AppendText(allCardsArr[i+3] + " ");
            }
        }

        private void showHandsButton_Click(object sender, EventArgs e)
        {
            //the new form is displayed only showing the players and their perspective decks
            showHandsForm sHF = new showHandsForm(this);
            sHF.Show();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
            //might have to close the old instance of the other form as well
        }

        private void resetDecks()
        {
            p1Deck.Text = "";
            p2Deck.Text = "";
            p3Deck.Text = "";
            p4Deck.Text = "";
        }

        private void reset()
        {
            shuffleText.Text = "";
            resetDecks();
            dealButton.Enabled = false;
            showHandsButton.Enabled = false;
        }

        public void fullReset()
        {
            shuffleButton.Enabled = false;
            reset();
        }
    }
}
