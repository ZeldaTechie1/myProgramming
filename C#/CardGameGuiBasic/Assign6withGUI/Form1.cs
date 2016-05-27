using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assign6withGUI;

/*
PROGRAMMERS NAME:Bryan Cancel
STUDENT ID:20266067
CLASS:CSCI 3228 ASSIGNMENT #:7
DATE DUE:11/2/15 DATE TURNED IN:11/2/15
*/

namespace Assignment6CSharp
{
    public partial class mainForm : Form
    {
        public string[] oAllCardsArr;
        public string[] allCardsArr;
        public bool arrange = false;
        public string[] p1 = new string[13];
        public string[] p2 = new string[13];
        public string[] p3 = new string[13];
        public string[] p4 = new string[13];

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
            picturesShowButton.Enabled = true;
            shuffleButton.Enabled = true;
            //read in from a file and into an array of strings
            oAllCardsArr = (System.IO.File.ReadAllText(@"allCards.txt")).Split(' ').ToArray();
            //loop throught the array and print the values in the proper format onto the getNewDeckText area
            for(int i=0; i<oAllCardsArr.Length; i++)
            {
                getNewDeckText.AppendText(oAllCardsArr[i]+" ");
                if ((i+1)%13==0 && i!=0)
                    getNewDeckText.AppendText("\n");
            }
            allCardsArr = oAllCardsArr;

        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();//rnd number seed
            reset();//reset text that is in the text box
            dealButton.Enabled = true;
            showShowButton.Enabled = true;

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
            arrangeCardsButton.Enabled = true;

            //the shuffled card are now distributed one at a time in a round robin fashion to the four players (4 arrays) and display in their perspective p#DeckText area
            for (int i=0, j=0; i<allCardsArr.Length; i+=4, j++)
            {
                p1[j] = allCardsArr[i];
                p2[j] = allCardsArr[i+1];
                p3[j] = allCardsArr[i+2];
                p4[j] = allCardsArr[i+3];
            }

            //print the array onto the appropiate p#Deck area
            foreach (string s in p1)
                p1Deck.AppendText(s + " ");
            foreach (string s in p2)
                p2Deck.AppendText(s + " ");
            foreach (string s in p3)
                p3Deck.AppendText(s + " ");
            foreach (string s in p4)
                p4Deck.AppendText(s + " ");
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
            arrangeCardsButton.Enabled = false;
            arrange = false;
        }

        public void fullReset()
        {
            getNewDeckText.Text = "";
            shuffleButton.Enabled = false;
            picturesShowButton.Enabled = false;
            showShowButton.Enabled = false;
            reset();
        }

        private void picturesShowButton_Click(object sender, EventArgs e)
        {
            oDeck oD = new oDeck(this);
            oD.Show();
        }

        private void showShowButton_Click(object sender, EventArgs e)
        {
            shuffledDeck sD = new shuffledDeck(this);
            sD.Show();
        }

        private void arrangeCardsButton_Click(object sender, EventArgs e)
        {
            arrange = true;
            showHandsForm sHF = new showHandsForm(this);
            sHF.Show();
        }
    }
}
