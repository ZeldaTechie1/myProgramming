/////////////////////////////////////////////////////////////////////
//
// Name: Bryan Cancel
// Date: 11/20/14
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// Driver for the movies program
//
/////////////////////////////////////////////////////////////////////

#include "movies.h"

const int MOVIES_SIZE = 10;

int main()
{
	char fileName[30]; // Name of the input file
	Movie topMovies2010[MOVIES_SIZE]; // Array of movie structs
	string title; // Title the user wishes to search for
	int pos; // Position of the desired movie in the array

	/////////////////////////////////////////////
	// Start of your code

	// Ask the user for the name of the input file
	cout << "Enter the name of the movies file: ";
	cin >> fileName;
	cout << endl;

	// Read the file 
	// (using the storeMoviesArray function)
	storeMoviesArray(topMovies2010, MOVIES_SIZE, fileName);


	// Sort the movies array by revenue 
	// (using the sortMoviesRevenue function)
	sortMoviesRevenue(topMovies2010, MOVIES_SIZE);


	// Print the movies array as sorted by revenue 
	// (using the printMoviesArray function)
	printMoviesArray(topMovies2010, MOVIES_SIZE);


	// Find the index of the movie that the user chooses
	// Ask the user to input a title
	cout << endl << "Enter a Movie Title: ";
	cin >> title;
	cout << endl;



	// then use the findMovieTitle function to find the index of that title
	pos = findMovieTitle(topMovies2010, MOVIES_SIZE, title);


	// Print the information about the chosen movie
	// If the movie was not found, print a message
	if (pos != -1)
	{
		cout << "title: " << topMovies2010[pos].title << endl << "year: " << topMovies2010[pos].yearReleased << endl << "revenue: " << topMovies2010[pos].revenue<<endl;
	}
	else
		cout << title << " not found" << endl;



	// End of your code
	/////////////////////////////////////////////


	system("pause");

	return 0;
}