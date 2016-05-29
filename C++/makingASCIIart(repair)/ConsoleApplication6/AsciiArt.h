//Bryan Cancel
//Assignment 3 | AsciiArt.h
//2/4/15

#include<iostream>
#include<string>
#include<fstream>

using namespace std;

//function prototypes so I can use the function in other function with no errors
string outputArt(string fileName);
string createInstructions(string fileName);
string plottingInstructions(string fileName);

//this function converts an _art file or a _instr file to plotting instructions
string plottingInstructions(string fileName)
{
	//check if its _art or _instr
	char AorI = fileName.at(fileName.length() - 1);
	//if its an _instr convert it to _art
	if (AorI == 'r')
		fileName = outputArt(fileName);

	//creating the output file name with the added _art.
	string outputFileName = fileName + "_char_instr";

	//opening the input and output files
	ifstream in;
	in.open(fileName + ".txt");
	ofstream out;
	out.open(outputFileName + ".txt");

	
	char a;//char I am going to use to equal whatever is retrieved from in.get
	//2D array that will store all the values inputed
	char arr[100][100]; //LIMITATION: can only read in instructions or art that is a max of 100 by 100 chars

	//input from file to a
	in.get(a);
	//continue till the end of file is reached
	while (!in.eof())
	{
		//go to rows
		for (int r = 0; r < 100; r++)
		{
			//go to columns
			for (int c = 0; c < 100; c++)
			{
				//if a equals a new line character that it should break and go to a different row, I know you dont like the use of break but it just made my life way easier in this situation, I hope you dont mind
				if (a == '\n')
					break;
				//set whatever char I got from the file that is now in a to a slot on the 2D array
				arr[r][c] = a;
				//input from file to a
				in.get(a);
			}
			//input from file to a
			in.get(a);
		}
	}

	//this will be the number that will indicate what char we are checking for
	int charnum = 0;//LIMITATION: the loop bellow will only work for regular ascii table, not extended
	int charCounter;//this keeps track of how many of the char we are looking for have been found

	//loops throught the whole 2D array 128 times checking for each type of char
	while (charnum <= 127)
	{
		//char Counter is set to 0 since we move on to a new char
		charCounter = 0;
		//loops through rows
		for (int r = 0; r < 100; r++)
		{
			//loops through columns
			for (int c = 0; c < 100; c++)
			{
				//if whatever is in the array spot is a char (did this to avoid random memory location prints) and the char equals the char we are looking for then enter
				if ((arr[r][c] >= 0 && arr[r][c] <= 127) && arr[r][c] == charnum)
				{
					//now that we know what is at this position matches what we are looking for we can add to the counter
					charCounter++;
					//if charCounter == 1 then we print the type of char, this only works the first time you are going through for this specific char; if the char never appears then nothing for that char gets printed
					if (charCounter == 1)
					{
						//taking care of space expection
						if (charnum == 32)
							out << "sp ";
						else//printing the char that we just found for the first time
							out << (char)charnum << " ";
					}
					//print the row and column of the char we just found
					out << r << "x" << c << " ";
				}
			}
		}
		//print endl as long as we found atleast one char of the one we where looking for, (avoid seemingly random spaces, that are actually chars that we where checking for that where never found)
		if (charCounter>0)
			out << endl;
		//charnum increases so we can now check a different char
		charnum++;
	}

	//close both files
	in.close();
	out.close();

	//return the name of the file we outputted to for use in main
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
	out << endl;

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
