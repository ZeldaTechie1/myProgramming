//Bryan Cancel
//Assignment 3 | main.cpp
//2/4/15

#include<iostream>
#include<string>
#include<fstream>
#include"AsciiArt.h"

using namespace std;

//BASIC ASSIGNMENT 3--------------------------------------------------
/*
int main()
{
	//this stores the reply of the user
	int num;
	//this stores the filename the user input
	string fileName;
	//this stores what the function returns so the output file can be printed
	string OFN;

	//ask userfor file and then takes it in
	cout << "File: ";
	cin >> fileName;

	//menu and waits for reply
	cout << endl << "Please choose:" << endl << "(1) Create ascii art" << endl << "(2) Create instructions" << endl<<">";
	cin >> num;

	//prints the file you are inputing from
	cout << endl << "File name: " << fileName << ".txt" << endl;

	//calls the function depending on the users reply
	if (num == 1)
		OFN = outputArt(fileName); 
	else
		OFN = createInstructions(fileName);

	//prints the file you are outputing from
	cout << "Output: " << OFN << ".txt" << endl << endl;
	
	system("pause");
	return 0;
}
*/

//BONUS for 40 points and 20 point put together--------------------------------------------------
//LIMITATION: The file name must have a _art or _instr at the end of it for this to work and ofcourse if it has _art if should be art and if it ahs _instr it should be instructions in their original version, that is how it determine whether or not to convert it to art to format it
int main()
{
	//creat the string that will store the filename, ask user for the file name and input it into the var
	string fileName2;
	cout << "File:";
	cin >> fileName2;

	//show what file is being used to input
	cout << endl << "File name: " << fileName2 << ".txt" << endl;

	//set the string to the last file that was ouputed to as a cousequence of the function
	string OFN2 = plottingInstructions(fileName2);

	//print the file that has the results the user is looking for
	cout << endl << "Output: " << OFN2 << ".txt" << endl << endl;

	system("pause");
	return 0;
}