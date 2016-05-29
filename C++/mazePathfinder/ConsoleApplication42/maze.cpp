//Bryan Cancel
//Assignment 9 (maze)
//maze.cpp

#include<iostream>
#include<fstream>
#include<string>
#include<stack>

#include"Move.h"

using namespace std;

bool findAWayOut(char **arr, int row, int col, int rpos, int cpos, stack<Move>& x);
void print(char **arr, int row, int col, int i, bool ans);

void test(stack<int>& x);

int main()
{
	//create names for inputing and outputting form files 
	ifstream inFile;
	ofstream outFile;
	//open where we will input and output
	inFile.open("maze.txt");
	outFile.open("maze.out.txt");
	//create our stack of move objects
	stack <Move> x;

	string line; //this is the string that stores the data by rows
	int row; //amount of rows in the maze
	int col; //amount of cols in the maze
	int rpos; //our starting x var in the maze
	int cpos; //our starting y var in the maze
	char** arr; //Dynamically allocated pointer of a pointer 

	//Print Header in File
	outFile << "Solutions for the Maze Assignment" << endl;
	outFile << "Bryan Cancel" << endl;

	//take in the first value that will be a row for sure
	inFile >> row;

	//keep going until eof so you process all of the mazes
	for (int i = 1; !inFile.eof(); i++)
	{
		//Now input column
		inFile >> col;

		//2D dynamically allocated array creation
		arr = new char*[col];
		for (int i = 0; i < col; ++i)
			arr[i] = new char[row];

		//read in the maze into a 2D dynamically allocated array
		for (int r = -1; r < row; r++) //starts at -1 since geline is taking the spare new line character [not idea why] (my way of clearing buffer)
		{
			//get the maze by row
			getline(inFile, line);
			//read is the individual characters of that row into our 2d array
			for (int c = 0; c < line.length(); c++)
				arr[r][c] = line[c];
		}

		//get the location where you will start at X var and Y var
		inFile >> rpos;
		inFile >> cpos;

		//Print out the info by first checking if there is a way out storig that response and handing that and other info to the print function
		bool ans = findAWayOut(arr, row, col, rpos, cpos, x); //check if there is a way out
		print(arr, row, col, i, ans);
		
		//free up memory(2D array) ---------- THIS WAS CRASHING ON ME BUT IT IS SUPPOSED TO WORK...
		/*for (int i = 0; i < col; ++i) {
			delete[] arr[i];
		}
		delete[] arr;*/

		//take in another value which should be the row or eof
		inFile >> row;
	}

	system("pause");
	return 0;
}

//Find the Way Out Funciton (SHOULD WORK RECURSIVELY)
bool findAWayOut(char **arr, int row, int col, int rpos, int cpos, stack<Move>& x)
{
	//create the first object and push to our stack of those objects
	Move a(rpos, cpos);
	x.push(a);

	//keep going until you find the end or your list are empty, which would mean the there is now way out
	for (int count = 0; x.empty() == false; count ++)
	{
		//top the first two values and place them in side of rpos and cpos
		rpos = x.top().row;
		cpos = x.top().col;

		//after the first time check for your location being equal to E (means there is a way out)
		if (arr[rpos][cpos] == 'E' && count != 0)
			return true;

		//add a breadcrumb at the location and pop it off of the stack
		arr[rpos][cpos] = '.';
		x.pop();

		//check all the locations surrounding the current starting point and push them to the stacks by:
			//first making sure that the coordingate given are not our of range
			//secondly by making sure the values taken in are either + or E
		if (rpos != row && ((arr[rpos + 1][cpos] == '+') || (arr[rpos + 1][cpos] == 'E')))
		{
			Move a(rpos + 1, cpos);
			x.push(a);
		}
		if (rpos != 0 && ((arr[rpos - 1][cpos] == '+') || (arr[rpos - 1][cpos] == 'E')))
		{
			Move a(rpos - 1, cpos);
			x.push(a);
		}
		if (cpos != col && ((arr[rpos][cpos + 1] == '+') || (arr[rpos][cpos + 1] == 'E')))
		{
			Move a(rpos, cpos + 1);
			x.push(a);
		}
		if (cpos != 0 && ((arr[rpos][cpos - 1] == '+') || (arr[rpos][cpos - 1] == 'E')))
		{
			Move a(rpos, cpos - 1);
			x.push(a);
		}
	}

	//if it exits the loop and an E isnt found (besides the first) there there is no way out so return false
	return false;	
}

//print the information about each specific list
void print(char **arr, int row, int col, int i, bool ans)
{
	//first opens the file to append to it
	ofstream outFile("maze.out.txt", ios::app);

	//The following will be repeated for each maze in maze.txt
	outFile << endl;
	outFile << "Maze Number: " << i << endl << endl;

	//Print the maze showing your breadcrumbs (.) along the way
	for (int r = 0; r < row; r++)
	{
		for (int c = 0; c < col; c++)
		{
			outFile << arr[r][c];
		}
		outFile << endl;
	}
	outFile << endl;

	//The appropriate message – either “There is a way out!” or “There is not a way out!”
	if (ans == true)
		outFile << "There is a way out!" << endl;
	else
		outFile << "There is not a way out!" << endl;
}
