/////////////////////////////////////////////////////////////////////
//
// Name: Bryan Cancel
// Date: 10/3/14
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// Generate a random number and ask the user to guess the number.
// Use a for loop to only allow the user to guess 5 times.
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
    int numGuesses; // The number of times the user has guessed

    // Seed the random generator.
    srand(static_cast<int> (time(NULL)));
	
    // Generate a random number between 1 and 100.
	number = (rand() % 100) + 1;
    
    //////////////////////////////////////////////
    // Start modifying program here

    // This is the loop from the original program, where the user 
    // is allowed an unlimited number of guesses.
    // Change this to a for loop that only allows 5 guesses


    // Add any additional variables you need to the variable list
    // at the top of the program. You can also delete variables
    // that are not needed with the for loop.
    for(numGuesses =0; numGuesses < 5 && !correct; numGuesses++)
    {
        cout << "guess the number the computer randomly picked between 1 - 100: ";
        cin >> guess;

		if(number > guess)
		{
			cout << "sorry, your guess is too low" << endl << endl;
		}
		else if(number < guess)
		{
			cout << "sorry, your guess is too high" << endl << endl;
		}
		else
		{
			cout << endl << "you guessed right, you win!" << endl << endl;
			            
			// Update the looping condition so the program will exit the loop
			correct = true;
		}
    }
	if(numGuesses>=5)
	{
	cout << endl << "Sorry, you lost. The number is: " << number << endl;
	}
    // End of program modifications
    //////////////////////////////////////////////

    system("pause");
	
    return 0;
}
