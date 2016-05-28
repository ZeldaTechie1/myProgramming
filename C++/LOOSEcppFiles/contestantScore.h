/////////////////////////////////////////////////////////////////////
// 
// Name: <Put your name here>
// Date: <Today's date>
// Class: <Your class number and section number, like: CSCI 1370.02>
// Semester: <This semester, like: Spring 2012>
// CSCI/CMPE 1370 Instructor: <Your lecture instructor's name>
//
// These functions are used for computing a average of numbers where
// the lowest and highest numbers in the series are dropped.
//
/////////////////////////////////////////////////////////////////////

#include<iostream>
#include<cmath>
#include<string>

using namespace std;

//
// This function gets a double between 0 and 100 from console input
//
// DO NOT MODIFY THIS FUNCTION
//
double getDouble0to10(string message)
{
	double num;

	cout << message;
	cin >> num;

	// Check for valid input
	// We have to be careful when comparing doubles.
	// If the user enters a number just slightly bigger than 10 
	// (such as 10.00000000000000001) the computer will
	// not see that the user input is greater than 10. I can't get the
	// same thing to happen with the low end of the input, probably because
	// I am alwyas entering a negative sign before the number. But I use
	// the floor function just to be safe. We use the floor
	// and ceil functions to ensure we are comparing whole numbers.
	while (!cin || floor(num) < 0 || ceil(num) > 10)
	{
		// Reset the input stream and remove any remaining
		// input
		cin.clear();
		cin.ignore(5000, '\n');

		// Ask for valid input
		cout << "You entered incorrect input" << endl;
		cout << "Enter a double between 0 and 10: ";
		cin >> num;
	}

	// Return the number input by the user
	return num;

} // end getDouble0to100 function


////////////////////////////////
// Start of your code


//
// This function finds the minimum and maximum of a series of 5 numbers
// This function should have a void return type.
// You must use some reference parameters for this function.
//
// Write this function
//
void MinMax(double &score1, double &score2, double &score3, double &score4, double &score5)
{


	if (score1 > score2 && score1 > score3 && score1 > score4 && score1 > score5)
		score1 = 25;
	else if (score2 > score1 && score2 > score3 && score2 > score4 && score2 > score5)
		score2 = 25;
	else if (score3 > score1 && score3 > score2 && score3 > score4 && score3 > score5)
		score3 = 25;
	else if (score4 > score1 && score4 > score2 && score4 > score3 && score4 > score5)
		score4 = 25;
	else
		score5 = 25;

	if (score1 < score2 && score1 < score3 && score1 < score4 && score1 < score5)
		score1 = -25;
	else if (score2 < score1 && score2 < score3 && score2 < score4 && score2 < score5)
		score2 = -25;
	else if (score3 < score1 && score3 < score2 && score3 < score4 && score3 < score5)
		score3 = -25;
	else if (score4 < score1 && score4 < score2 && score4 < score3 && score4 < score5)
		score4 = -25;
	else
		score5 = -25;
}





//
// Find the average of 5 numbers excluding the minimum and maximum
// If there is more than one number with the minimum or maximum value,
// only exclude the number one time. For example, if the numbers are:
// 4.5 6.7 2.3 7.8 2.3, the average is calculated using the numbers:
// 4.5 6.7 2.3.
//
// This function must call the above function that finds the minimum and maximum
// values in a series of 5 numbers.
//
// This function does not use reference parameters
//
// Write this function
//
double avg5MinusMaxMin(double score1, double score2, double score3, double score4, double score5)
{
	double avg = 0;
	MinMax(score1, score2, score3, score4, score5);
	avg = (score1 + score2 + score3 + score4 + score5) / 3;
	return avg;
}





// End of your code
////////////////////////////////