//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
// Program: Lab 0128
// Author: Bryan Cancel
// Course: CSCI/CMPE 2380
// Description: This program will prompt the user for both an input and an
//  output file name.  Afterwards, it will prompt for a target word.  
//  The program opens the file and reads all the words in the file and keeps 
//  track of how many times that word appears.  It writes (appends) the word 
//  and the number to the output file.  It continues this until the user
//  types "exit".
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\


#include<iostream>
#include<fstream>
#include<string>

using namespace std;


//This function opens the output file to append the word and count on a new line
bool WriteWordToFile(string outputFile, string searchWord, int wordCount)
{
	ofstream outFile;
	outFile.open(outputFile + ".txt", ios::out | ios::app);
	
	outFile << searchWord << " " << wordCount<<endl;

	outFile.close();
	return false;
}




//This function opens the inputfile and searches for the word.  It returns
//the number of times the word appears.  It assumes that it is case sensitive
//and that there is no punctuation.  Thus, the simple insertion operator can
//be used.
int SearchFile(string inputFile, string searchWord)
{
	int counter=0;
	string word;
	ifstream inFile;
	inFile.open(inputFile + ".txt");

	if (inFile.is_open())
	{
		inFile >> word;
		while (!inFile.eof())
		{
			if (word == searchWord) 
				counter++;
			inFile >> word;
		}
		if (word == searchWord)
			counter++;
		
	}
	return counter;
}




int main()
{
	string inputFile;
	string outputFile;
	string searchWord;
	int wordCount;

	//get input file name
	cout << "Give me an input file name: ";
	cin >> inputFile;
	//get output file name
	cout << endl << "Give me an output file name: ";
	cin >> outputFile;
	//get word to search
	cout << endl << "What word do you want to search? (type exit if you want to stop searching): ";
	cin >> searchWord;

	do
	{
		//search for word and get count
		wordCount = SearchFile(inputFile, searchWord);

		//record the word and count
		WriteWordToFile(outputFile, searchWord, wordCount);

		//get word to search
		cout << endl << "What word do you want to search? (type exit if you want to stop searching): ";
		cin >> searchWord;

	} while (searchWord != "exit");


	return 0;
}
