/////////////////////////////////////////////////////////////////////
//
// Name: Bryan Cancel
// Date: 9/26/14
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// Generate a random number and ask the user to guess the number.
// Only allow the user to guess 5 times.
//
/////////////////////////////////////////////////////////////////////

#include<iostream>
#include<string>
#include<cstdlib>
#include<time.h>


using namespace std;

int main()
{
	int number; // The correct number
	int guess;  // The user's guess
	bool correct = false; // If the user has correctly guessed the number
	int numGuesses = 0; // The number of times the user has guessed

	// Seed the random generator.
	srand(static_cast<int> (time(NULL)));

	// Generate a random number between 1 and 100.
	number = (rand() % 100) + 1;


	//////////////////////////////////////////////
	// Start modifying program here

	// This is the loop from the original program, where the user is allowed
	// an unlimited number of guesses.
	// Change this while loop to only allow 5 guesses.
	while (!correct && (numGuesses < 5 ))
	{
		cout << "guess the number the computer randomly picked between 1 - 100: ";
		cin >> guess;

		// Check if the user has guessed the correct number.
		// If not, tell him if his guess is too low or too high
		if (number > guess)
		{
			cout << "sorry, your guess is too low" << endl;
		}
		else if (number < guess)
		{
			cout << "sorry, your guess is too high" << endl;
		}
		else
		{
			cout << "you guessed right, you win!" << endl;

			// Update the looping condition so the program will exit the loop
			correct = true;
		}

		numGuesses = numGuesses + 1;

		if (numGuesses == 5)
		{
			cout << "YOU LOSE" << endl;
		}
	}

	// End of program modifications
	//////////////////////////////////////////////

	system("pause");

	return 0;
}