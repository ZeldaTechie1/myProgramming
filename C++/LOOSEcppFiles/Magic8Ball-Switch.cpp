/////////////////////////////////////////////////////////////////////
//
// Name: Bryan Cancel
// Date: 9/26/2014
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// Program Name: Magic 8 Ball
// Program Description: Simulate a Magic 8 Ball
//
/////////////////////////////////////////////////////////////////////

#include<iostream>
#include<cstdlib>
#include<string>
#include<time.h>

// This is the prototype for the getRandomNum function that was
// written by the instructor.
int getRandomNum(int lowRange, int highRange);

using namespace std;

int main()
{
	int number; // The random number

	// Seed the random number generator
	srand(static_cast<int> (time(NULL))); 

	
	////////////////////
	// Start of your code

	//prompt the user to enter a question
	cout << "Ask the Magic 8 Ball a question : ";
	cin.ignore(200,'\n');
	cout << "Answer :";
	
	
	
	// We don't need to save the question so we can ignore the user input

	
	
	
	
	
	//call the function randomGenerator(int num) to generate a random number.

	
	number = getRandomNum(1,5);
	
	
	
	//with a switch structure, use the random number to select an answer.

	switch (number)
	{
		case 1:
			cout << " Yes" << endl;
			break;
		case 2:
			cout << " Mabye" << endl;
			break;
		case 3:
			cout << " No" << endl;
			break;
		case 4:
			cout << " Ask again later" << endl;
			break;
		case 5:
			cout << " I don't know" << endl;
			break;
	}

	
	// End of your code
	////////////////////
	
	system("pause");
	return 0;

}

//
// Returns a random number in the range of the lowRange and
// highRange parameters (inclusive)
//
int getRandomNum(int lowRange, int highRange)
{
	int randNum;
	
	randNum =  ( rand() % (highRange - lowRange + 1) ) + lowRange;
	
	return randNum;
}	
