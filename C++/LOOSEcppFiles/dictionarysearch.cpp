/////////////////////////////////////////////////////////////////////
//
// Name: Bryan Cancel
// Date: 9/27/14
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// Search a dictionary file for the word input by the user.
//
/////////////////////////////////////////////////////////////////////

#include<iostream>
#include<string>
#include<fstream>

using namespace std;

int main()
{
	string word; // The word entered by the user
	string result; // The word read from the file
	int counter = 0; // Counts the number of lines read from the file
	bool found = false; // If the user's word has been found
	ifstream inFile; // The input file


	///////////////////////////////////
	// Start of your code

	//open the dictionary file.

	inFile.open("dictionary.txt");

	if (!inFile)
	{
		cout << "Couldn't open input file" << endl;

		// When you return in the middle of a program, the program execution
		// stops at the point of the return statement. By convention,
		// returning the value -1 indicates that an error occurred. 
		return -1; 
		
	}

	//ask the user to input the word they want to search for.
	cout << "Enter a word to search in dictionary: ";
	cin >> word;
	cout << endl;



	// Use a while loop to loop through the file.
	while (!inFile.eof())
	{
		inFile >> result;
		counter++;
		if (word==result)
		{
			found = true;
			break;
		}
	}
	// Use break to stop the loop if the word is found

	if (found == true)
	{
		cout << "word found in line " << counter << endl;
	}
	else
	{
		cout << "The word was not found" << endl;
	}


	// If the word is not found display a message.




	// End of your code
	///////////////////////////////////


	system("pause");
	return 0;
}