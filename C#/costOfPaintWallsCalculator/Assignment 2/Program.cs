using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//FOR DATE AND TIME
using System.Globalization;

/*
PROGRAMMERS NAME: Bryan Cancel
STUDENT ID: 20266067
CLASS: CSCI 3328-01 ASSIGNMENT #:2
DATE DUE: 9/21/15 DATE TURNED IN: 9/17/15
*/

//NOTE
/*
-one gal of paint for 450 sqfeet of wall space.
-Labor cost is a constant of 0.60 cents per sqft.
-Sales tax is .0825
*/

namespace Assignment_2
{
    //CLASS TO RECEIVE INPUT FROM USER
    public class Input
    {
        //Private Vars
        private string name;
        private string number;
        private double pricePerGallon;
        private int totalSQFT;
        private int walls;

        //Public SETS and GETS for all VARS         CHECK FOR VALID INPUT!
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public double PricePerGallon
        {
            get { return pricePerGallon; }
            set { pricePerGallon = value; }
        }
        public int TotalSQFT
        {
            get { return totalSQFT; }
            set { totalSQFT = value; }
        }
        public int Walls
        {
            get { return walls; }
            set { walls = value; }
        }

        //getInput Function
        public void getInput()
        {
            //Intro Print
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", "This Program will Calculate Cost of Painting inside walls of a house.", "You need to Enter the cost of a gallon of paint,", "  and length and height of each wall.", "The program will calculate number of gallons of paint needed using", "  one gal of paint for 450 sqfeet of wall space.", "Labor cost is a constant of 0.60 cents per sqft.");

            //Ask for and record
            Console.Write("Enter Name of the Customer: ");
            Name = Console.ReadLine();
            Console.Write("Enter Telephone Number of the Customer: ");
            Number = Console.ReadLine();
            Console.Write("Enter Price of the Paint per Gallon: ");
            PricePerGallon = Convert.ToDouble(Console.ReadLine());

            //for loop that keep going until the user no longer wants to add walls to the painting services order
            for (int i = 1, height = 0, length = 0; i != 0; i++)
            {
                //goes here only after the first time, its implied the first time its the 1st wall
                if (i > 1)
                    Console.WriteLine("{0}{1}", "Enter Length and Height for Wall #: ", i);
                if (i == 1)//if the 1st time dont allow the user to quit because its implied that he is for sure going to make an order
                    Console.Write("Enter Length of the Wall: ");
                else//ask the user for the length of the wall and explain that if he/she wants to quit he/she can type 0 to quit
                    Console.Write("Enter Length of the Wall <0 to quit>: ");

                //read in length and save into var
                length = Convert.ToInt32(Console.ReadLine());

                //goes into here if the user said they want to keep adding wall
                if (length != 0)
                {
                    Console.Write("Enter the Height of the Wall: ");

                    //read in height and save into var
                    height = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("{0}\n", "====================");
                    //add the new wall to the total and make the var walls go up by one since one wall was added
                    TotalSQFT = TotalSQFT + (height * length);
                    Walls = i;
                }
                else //if the user typed 0 they want to leave so exit the loop
                    i = -1;
            }
        }
    }

    //CLASS USED TO CALCULATE COST FROM INPUT
    public class Calculate
    {
        //Private Vars
        private int paintNeeded;
        private double paintCost;
        private double laborCost;
        private double subTotal;
        private double salesTax;
        private double grandTotal;
        private string date;

        //Public SETS and GETS for all VARS         CHECK FOR VALID INPUT!
        public int PaintNeeded
        {
            get { return paintNeeded; }
            set { paintNeeded = value; }
        }
        public double PaintCost
        {
            get { return paintCost; }
            set { paintCost = value; }
        }
        public double LaborCost
        {
            get { return laborCost; }
            set { laborCost = value; }
        }
        public double SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        public double SalesTax
        {
            get { return salesTax; }
            set { salesTax = value; }
        }
        public double GrandTotal
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        //Calc function, take in object I (Input) and calculates everything it needs to for the Receipt
        public void calc(Input I)
        {
            if (I.TotalSQFT % 450 == 0)
                paintNeeded = (I.TotalSQFT / 450);
            else //It will truncate the decimal if the modulus isnt 0 which will give is the wrong number (too litte paint). Also, due to the fact that you cant buy parts of a unit of paint you add 1 instead of a fraction or decimal value
                paintNeeded = (I.TotalSQFT / 450)+1; 
            paintCost = paintNeeded * I.PricePerGallon;
            laborCost = I.TotalSQFT * .6;
            subTotal = paintCost + laborCost;
            salesTax = subTotal * .0825;
            grandTotal = subTotal * 1.0825;
            date = DateTime.Now.ToString(new CultureInfo("en-US"));
        }
    }

    //CLASS USED TO DISPLAY RECEIT
    public class Display
    {
        public void printReceit(Input I, Calculate C)
        {
            //part 1
            Console.WriteLine("\n\n\n{0}\n{1}\n{2}\n\n{3}", "CSharp Painting Company", "UTRGV CSCI 3328", "Edinburg, TX 78539", "====================");
            //part 2
            Console.WriteLine("\n\n{0}{1}\n{2}{3}\n{4}{5}\n{6}", "Date of this Quote  : ", C.Date, "Name of the Customer: ", I.Name, "Customer Telephone  : ", I.Number, "====================");

            //part 3
            //formating into a currency form without the $ sign also occurs here
            Console.WriteLine("\n\n{0}{1}\n{2}{3}\n{4}{5}\n{6}{7,9}\n{8}{9,9}\n{10}{11,9}\n{12}{13,9}\n{14}{15,9}\n{16,48}\n{17}{18,9}\n{19,48}\n", "Number of Walls----------------------> ", I.Walls, "Total Sqft---------------------------> ", I.TotalSQFT, "Number of Galons of Paint Needed-----> ", C.PaintNeeded, "Price of Paint Per Galon-------------> ", I.PricePerGallon.ToString("C", CultureInfo.CurrentCulture).Trim('$'), "Cost of Paint------------------------> ", C.PaintCost.ToString("C", CultureInfo.CurrentCulture).Trim('$'), "Cost of Labor------------------------> ", C.LaborCost.ToString("C", CultureInfo.CurrentCulture).Trim('$'), "Sub Total----------------------------> ", C.SubTotal.ToString("C", CultureInfo.CurrentCulture).Trim('$'), "Sales Tax----------------------------> ", C.SalesTax.ToString("C", CultureInfo.CurrentCulture).Trim('$'), "------------", "Grand Total--------------------------> ", C.GrandTotal.ToString("C", CultureInfo.CurrentCulture).Trim('$'), "============");
        }
    }
    
    //MAIN PROGRAM THAT CALLS ALL OTHER CLASSES
    class Program
    {
        static void Main(string[] args)
        {
            //GET INPUT FROM USER
            Input I = new Input();
            I.getInput();

            //CALCULATE EVERYTHING FROM INPUT
            Calculate C = new Calculate();
            C.calc(I);

            //DISPLAY THE RECEIT
            Display D = new Display();
            D.printReceit(I, C);

            //ReadLine to Wait for users comand to close console
            Console.ReadLine();
        }
    }
}
