/////////////////////////////////////////////////////////////////////
//
// Name: Bryan Cancel
// Date: 11/20/14
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// Contains the movies struct and functions for the lab
//
/////////////////////////////////////////////////////////////////////

#include<iostream>
#include<fstream>
#include<string>
#include<iomanip>
using namespace std;

//
// Stores data about a movie
//
struct Movie
{
	string title;
	int yearReleased;
	int revenue;
};


//
// Reads movie data from a file and stores it in an array of movie structs
//
// YOU MUST COMPLETE THIS FUNCTION
//
void storeMoviesArray(Movie movies[], const int size, char fileName[])
{
	
	// Open the input file and check for failure
	ifstream inFile;
	inFile.open(fileName);
	if (!inFile)
	{
		cout << "(storeGradesArray) Error opening " << fileName << endl;
	}

	// Read from the file into the array


	for (int i = 0; i < size; i++)
	{
		inFile >> movies[i].title;
		inFile >> movies[i].yearReleased;
		inFile >> movies[i].revenue;

	}

	// Close the input file
	inFile.close();


} // End of storeMoviesArray function


//
// Prints an array of Movie structs
//
// YOU MUST COMPLETE THIS FUNCTION
//
void printMoviesArray(Movie movies[], const int size)
{
	for (int i = 0; i < size; i++)
	{
		cout << movies[i].title << setw(5) << movies[i].yearReleased << setw(10)<< movies[i].revenue << endl;
	}
} // end of printMoviesArray function

// 
// Uses bubble sort to sort a list of movie structs by revenue
//
// DO NOT MODIFY THIS FUNCTION
//
void sortMoviesRevenue(Movie movies[], const int size)
{
	Movie temp;
	bool swap;
	int i, j;

	for (i = 0; i < size; i++)
	{
		swap = false;

		for (j = 0; j < size - i - 1; j++)
		{
			if (movies[j].revenue > movies[j + 1].revenue)
			{
				swap = true;

				temp = movies[j];
				movies[j] = movies[j + 1];
				movies[j + 1] = temp;
			}
		}
		if (!swap)
		{
			break;
		}
	}
} // end sortMoviesRevenue function


//
// Uses bubble sort to sort a list of movie structs by title
//
// DO NOT MODIFY THIS FUNCTION
//
void sortMoviesTitle(Movie movies[], const int size)
{
	Movie temp;
	bool swap;
	int i, j;

	for (i = 0; i < size; i++)
	{
		swap = false;

		for (j = 0; j < size - i - 1; j++)
		{
			if (movies[j].title > movies[j + 1].title)
			{
				swap = true;

				temp = movies[j];
				movies[j] = movies[j + 1];
				movies[j + 1] = temp;
			}
		}
		if (!swap)
		{
			break;
		}
	}
} // end sortMoviesTitle function


//
// Uses binary search to searches an array of Movie structs for the given title.
//
// DO NOT MODIFY THIS FUNCTION
//
int findMovieTitle(Movie movies[], const int size, const string target)
{
	int first = 0; // Beginning of the search range
	int last = size - 1; // End of the search range
	int middle; // Middle of the search range
	int pos = -1; // Position of the target, or -1 if not found
	bool found = false; // True if the target has been found

	// Sort the list of movies by title
	sortMoviesTitle(movies, size);

	// Use binary search to find the given title
	while (!found && first <= last)
	{
		// Calculate the middle position
		// Note that integer division gives the desired result in this case
		middle = (first + last) / 2;

		// If the middle element is the target, we are done
		if (movies[middle].title == target)
		{
			pos = middle;
			found = true;
		}

		// If the middle value is greater than the target value,
		// search the lower half of the search space
		else if (movies[middle].title > target)
		{
			last = middle - 1;
		}

		// Otherwise, search the upper half of the search space
		else
		{
			first = middle + 1;
		}
	}

	return pos;

} // end findMovieTitle function