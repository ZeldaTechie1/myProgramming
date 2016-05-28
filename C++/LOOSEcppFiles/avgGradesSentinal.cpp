/////////////////////////////////////////////////////////////////////
//
// Name: Bryan Cancel
// Date: 9/27/14
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// Use a sentinal controlled loop to find the average of grades
// entered by the user. The sentinal value is -1.
//
//////////////////////////////////////////////////////////////////////

#include<iostream>
using namespace std;

int main()
{
	int grade= 0; // The grade entered by the user
	int sum =0; // Sum of the grades
	int count =0; // Number of grades entered
	double avg =0; // Average of the grades


	////////////////////////////////
	// Start of your code

	while (grade != -1)
	{
		cout << "Enter a grade, or -1 to stop: ";
		cin >> grade;

		if (grade != -1)
		{
			count = count++;
			sum = sum + grade;
			cout << endl;
		}
		else
		{
			avg = sum / static_cast<double>(count);
			cout << endl << "The average is: " << avg << endl << endl;
		}

	}
	
	// Loop until the user enters -1
	// Each time through the loop, add the number input by the user
	// to the sum. Make sure not to include the sentinal value in the
	// sum or count!





	// Find the average of the grades entered by the user
	// and print the result




	// End of your code
	////////////////////////////////

	system("pause");

	return 0;
}