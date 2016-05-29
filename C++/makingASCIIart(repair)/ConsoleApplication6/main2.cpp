//Bryan Cancel
//Assignment 3
//2/3/15

#include<iostream>
#include<string>
#include<fstream>
//#include"AsciiArt.h"

using namespace std;

string outputArt(string fileName);
string createInstructions(string fileName);
string plottingInstructions(string fileName);

int main()
{
	//BASIC ASSIGNMENT 3
	/*
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
	*/

	//BONUS

	string fileName2;
	cout << "File:";
	cin >> fileName2;

	cout << endl << "File name: " << fileName2 << ".txt" << endl;

	string OFN2 = plottingInstructions(fileName2);

	cout << "Output: " << OFN2 << ".txt" << endl << endl;

	system("pause");
	return 0;
}

//FUNCTIONS

string plottingInstructions(string fileName)
{
	string outputFileName = fileName + "_char_instr";

	//stuff

	return outputFileName;
}

string outputArt(string fileName)
{
	//creating the output file name with the added _art.
	string outputFileName = fileName + "_art";

	//opening the input and output files
	ifstream in;
	in.open(fileName + ".txt");
	ofstream out;
	out.open(outputFileName + ".txt");

	//input vars
	int num;
	string character;
	//output vars
	char val;
	int multi;

	//take in the first number and char which will be ignored but needed for correct coding
	in >> num;
	in >> character;

	//read in till eof
	do{
		//input a num and a character
		in >> num;
		in >> character;

		//if the character that was taken in is a dash then that means that we have to new line because in the insructions a dash indicates a new line
		if (character.at(0) == '-')
		{
			//for the sake of having one while loop for output just set the multiplier to 0 so nothing is printed in the while loop bellow
			val = ' ';
			multi = 0;
			//an endline is put in
			out << endl;
		}
		//takes care of sp exception since its the only character represented by a string with the characters
		else if (character.substr(0, 2) == "sp")
		{
			val = ' ';
			multi = num;
		}
		//this set the char used in the while loop to the first character in the string we took in therefore ignoring the comma
		else
		{
			val = character.at(0);
			multi = num;
		}

		//Printing is seperate
		for (int i = 0; i < multi; i++)
		{
			out << val;
		}
	} while (!in.eof());

	//closes both files
	in.close();
	out.close();

	//return the outfilename so we can use it to indicate what file we printed too
	return outputFileName;
}

string createInstructions(string fileName)
{

	//creating the output file name with the added _instr
	string outputFileName = fileName + "_instr";

	//opening the input and output files
	ifstream in;
	in.open(fileName + ".txt");
	ofstream out;
	out.open(outputFileName + ".txt");

	int row = 0;//row counter
	int charCount;//counter of a specific char
	char curr;//current char
	char prev;//prev char

	//input first char for sake of being correct
	in.get(curr);
	//read in till eof
	while (!in.eof())
	{
		//add to row so it can print the right row bellow
		row++;
		//prev is set to null because if you are starting a new line you only have the current char you are working with
		prev = '\0';
		//sets the charCount to 0 becase after every row your charCount has to start over again
		charCount = 0;
		//print the insturction of what row we are on
		out << row << " -";
		//read by rows
		do{
			//if the current and previous chars match it mean they are the same and you should add to the charCount, BUT if prev is null then you are still working with your first character so your charCount doesnt increase
			if (curr == prev || prev == '\0')
			{
				charCount++;
			}
			//if current and previous chars dont match that means we can print the instruction for the previous chars
			else if (curr != prev)
			{
				//output the char count
				out << " " << charCount << " ";
				//take care of the sp exception 
				if (prev == ' ')
					out << "sp,";
				//print the previous char we where on
				else
					out << prev << ",";
				//make the charCount 1 because eventhough we printed the previous chars info we are working with the current char and it is the first of its set
				charCount = 1;
			}
			//previous = current so we can compare the previous and current char
			prev = curr;
			//get another character and set curr to it
			in.get(curr);
		} while (prev != '\n');
		//output and enline when an endline character shows up... duh
		out << endl;
	}

	//closes both files
	in.close();
	out.close();

	//return the outfilename so we can use it to indicate what file we printed too
	return outputFileName;
}

