/////////////////////////////////////////////////////////////////////
//
// Name: Bryan Cancel
// Date: 9/27/14
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// This program creates a simulated player who takes one turn in the
// Pig dice game. The simulated player keeps rolling the die until
// the total for the turn is 20 or greater, or until a 1 is rolled.
// If a 1 is rolled, the player's score for the turn is 0. Otherwise
// the player's score is the sum of the rolls for the turn.
//
/////////////////////////////////////////////////////////////////////

#include<iostream>
#include<cstdlib>
#include<time.h>
#include<string>

using namespace std;

// This is the prototype for the getRandomNum function that was
// written by the instructor.
int getRandomNum(int lowRange, int highRange);


int main()
{
	int roll = 2; // The value of the die roll
	int total_turn = 0; // Player's score for this turn

	// Seed the random number generator
	srand(static_cast<int> (time(NULL)));


	/////////////////////////////////////////
	// Start of your code


	// Use a while loop to roll the die until the total turn number is 
	// 20 or greater, or until a 1 is rolled. if a 1 is rolled the 
	// player gets a 0 for the turn.

	while (roll > 1 && total_turn <= 20)
	{
		cout << "it's the computer's turn to roll . . . ";
		cin.ignore(2000,'\n');
		roll = getRandomNum(1, 6);

		if (roll > 1)
		{
			total_turn = total_turn + roll;
		}
		cout << "computer rolled a " << roll;
		if (roll <= 1)
		{
			cout << ", its turn is over.";
		}
		
			cout << endl << "current total for the turn = " << total_turn << endl << endl;
		
		
	}
	cout << "computer has completed its turn." << endl << "computer got " << total_turn << " points for the turn." << endl;



	//output the number of points the simulated player got for the turn.




	// End of your code
	/////////////////////////////////////////

	system("pause");
	return 0;

}//close main()

//
// Returns a random number in the range of the lowRange and
// highRange parameters (inclusive)
//
int getRandomNum(int lowRange, int highRange)
{
	int randNum;

	randNum = (rand() % (highRange - lowRange + 1)) + lowRange;

	return randNum;
}