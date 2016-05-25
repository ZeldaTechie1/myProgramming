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
CLASS: CSCI 3228 ASSIGNMENT #: 8
DATE DUE: 11/23/15 DATE TURNED IN: 11/18/15
*/

namespace Assignment8
{

    public partial class mainForm : Form
    { 
        public mainForm()
        {
            InitializeComponent();
        }

        List<TextBox> stackItems = new List<TextBox>();

        private void calculateButton_Click(object sender, EventArgs e)
        {
            myStack postfixStack = new myStack();
            //read in the string fully from the inputString and parse
            string[] postfixArr = inputString.Text.Split(' ');

            int yPos = 457;

            if (postfixArr.Length<2) 
                MessageBox.Show("Please write in some more values into the textbox");
            else//loop through the array
            {
                for (int opC = 0; opC < postfixArr.Length; opC++)
                {
                    //if opcode
                    char temp = Convert.ToChar(postfixArr[opC][0]);
                    if (temp == '+' || temp == '-' || temp == '*' || temp == '/' || temp == '%')
                    {
                        //if nothing to apply that opcode too give error message
                        if (postfixStack.Count < 2) //FIX SOMETHING HERE
                        {
                            MessageBox.Show("You dont have enough values in the stack to apply this operator, please modify your input and try again");
                            consoleText.Text = "";
                            break;
                        }
                        else
                        {
                            consoleText.AppendText("Performing Operation " + temp + "\n"); //"console" output what is being done
                            MessageBox.Show("OpCode found, will pop two number from the Stack and perform Operation!");

                            double c, a = (double)postfixStack.Pop(); //pop the top two values to use them
                            consoleText.AppendText("Popped: " + a + "\n");
                            MessageBox.Show("Popped: " + a);
                            stackItems.ElementAt(postfixStack.Count).Hide();
                            stackItems.RemoveAt(postfixStack.Count);
                            yPos += 20;//also kickback the yPos by 20 so it still keeps looking like what it is a stack
                            
                            double b = (double)postfixStack.Pop();
                            consoleText.AppendText("Popped: " + b + "\n");
                            MessageBox.Show("Popped: " + b);
                            stackItems.ElementAt(postfixStack.Count).Hide();
                            stackItems.RemoveAt(postfixStack.Count);
                            yPos += 20;

                            //calculate the new number
                            if (temp == '+')
                                c = b + a;
                            else if (temp == '-')
                                c = b - a;
                            else if (temp == '*')
                                c = b * a;
                            else if (temp == '/')
                                c = b / a;
                            else
                                c = b % a;
                            //push the new number
                            consoleText.AppendText("Pushed: " + c + "\n"); //"console" output the number you just pushed (aka result)
                            MessageBox.Show("Pushed: " + c);
                            postfixStack.Push(c);

                            //also create and display a empty text box and fill it with the number being pushed (need to use a standard x value and width and height, the y value must adjust depending on the size of the stack
                            TextBox tb = new TextBox();
                            tb.Location = new Point(291, yPos);
                            yPos = yPos - 20;
                            tb.Height = 20;
                            tb.Width = 150;
                            tb.Text = Convert.ToString(c);
                            tb.ReadOnly = true;
                            this.Controls.Add(tb);
                            stackItems.Add(tb);
                        }
                    }
                    else
                    {
                        consoleText.AppendText("Pushed: " + postfixArr[opC] + "\n"); //"console" output the number you just pushed
                        MessageBox.Show("Pushed: " + postfixArr[opC]);
                        postfixStack.Push(Convert.ToDouble(postfixArr[opC]));

                        //also create and display a empty text box and fill it with the number being pushed (need to use a standard x value and width and height, the y value must adjust depending on the size of the stack                        
                        TextBox tb = new TextBox();
                        tb.Location = new Point(291, yPos);
                        yPos = yPos - 20;
                        tb.Height = 20;
                        tb.Width = 150;
                        tb.Text = postfixArr[opC];
                        tb.ReadOnly = true;
                        this.Controls.Add(tb);
                        stackItems.Add(tb);   
                    }
                }
                answerText.Text = Convert.ToString(postfixStack.Peek());
                consoleText.AppendText("Popped: Answer!\n");
                MessageBox.Show("Popped: Answer!");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anotherProblemButton_Click(object sender, EventArgs e)
        {
            inputString.Text = "";
            answerText.Text = "";
            consoleText.Text = "";
            stackItems.ElementAt(0).Hide();
            stackItems.RemoveAt(0);
        }
    }

    //MY OWN IMPLEMENTATION OF THE STACK - array based
    public class myStack
    {
        private int count = 0;
        private object[] stack;
        public int Count
        {
            get { return count; }
            set {; }
        }

        public object Pop()
        {
            object[] temp = new object[count - 1];
            for (int i = 0; i < count - 1; i++)
                temp[i] = stack[i];
            object temp2 = stack[count - 1];
            stack = temp;
            count--;
            return temp2;
        }

        public void Push(object obj)
        {
            object[] temp = new object[count + 1];
            for (int i = 0; i < count; i++)
                temp[i] = stack[i];
            temp[count] = obj;
            stack = temp;
            count++;
        }

        public object Peek()
        {
            return stack[count - 1];
        }
    }
}
