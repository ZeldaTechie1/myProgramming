﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment6CSharp;

/*
PROGRAMMERS NAME:Bryan Cancel
STUDENT ID:20266067
CLASS:CSCI 3228 ASSIGNMENT #:7
DATE DUE:11/2/15 DATE TURNED IN:11/2/15
*/

namespace Assign6withGUI
{
    public partial class oDeck : Form
    {
        mainForm main;   
        public oDeck(mainForm m)
        {
            main = m;
            InitializeComponent();
            PictureBox[] pB= new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40, pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50, pictureBox51, pictureBox52 };
            for(int i=0; i<main.oAllCardsArr.Length; i++)
            {
                pB[i].Image = Image.FromFile(Environment.CurrentDirectory + "\\cardImages\\" + main.oAllCardsArr[i] + ".png"); //make relative path
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
