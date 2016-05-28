/////////////////////////////////////////////////////////////////////
//
// Name: Bryan Cancel
// Date: 9/27/14
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// Use looping to ensure that the user inputs a proper value.
//
//////////////////////////////////////////////////////////////////////

#include<iostream>
#include<string>
using namespace std;

int main()
{
	
	char ans; // The user's answer to the question
	int age; // The user's age
	bool correct = false; // The boolean flag



	////////////////////////////////
	// Beginning of your code


	// Ask the user a yes/no question and make sure the response is

	while (!correct)
	{
		cout << "Do you like ice cream? <y / n>: ";
		
		cin >> ans;

		//FIX THIS (ITS PRINTING THE FREAKING THING FOR THE AMMOUNT OF CHARACTERS I TYPE
		/*if (!cin)
		{
			cin.clear();
			cin.ignore(2000, '\n');
			cout << "Please (y/n) only";
		}*/
		
		if (ans == 'y' || ans == 'n')
		{
			correct = true;
			cout << endl;
			
		}
		else
		{
			cout << "Incorrect value" << endl;
		}

	}




	correct = false;


	// Get the user's age
	
	// Make sure the user enters her age as a number

	while(!correct)
	{
		cout << "Enter your age as an integer: ";
		cin >> age;

			if (!cin)
			{
			cin.clear();
			cin.ignore(2000, '\n');
			cout << "You must enter an integer" << endl;
			}
			else
			{
				correct = true;
				cout << endl;
			}

	}





	// End of your code
	////////////////////////////////

	cout << "Thanks for your input!" << endl;


	system("pause");

	return 0;
}