#include<iostream>
#include<string>
#include<fstream>

using namespace std;

void InstrAscii();

int main()
{
	ifstream inFile;
	ofstream outFile;
	string inputFile;
	string outputFile;
	int num;

	cout << "Please choose:" << endl << "(1) Create ascii art" << endl;
	cout << "(2) Create instructions" << endl << ">";
	cin >> num;

	inFile.open(inputFile);

	if (num == 1)
	{
		cout << "Filename: ";
		cin >> inputFile;
		cout << "Output: ";
		cin >> outputFile;
		InstrAscii();
	}
	else if (num == 2)
	{
		cout << "Filename: ";
		cin >> inputFile;
		cout << "Output: ";
		cin >> outputFile;
		//instruction creator function that I do not know how to do...
	}
	else
	{
		cin.ignore;
		cin.clear(2000, '/n');
		"Please choose 1 or 2: ";
		cin >> num;
	}


	system("pause");
	return 0;
}

void InstrAscii() //reads instructions and creates ascii art
{
	string chars;
	int num_times;

	fin >> num_times;
	fin >> chars;

	while(fin >> num_times && fin >> chars) //reads number of times a char is supposed to be printed
	{
		if(chars == "sp,")
		{
			chars = " ,";
		}
		else if (chars == "sp")
		{
			chars = " ";
		}
		for (int i=0; i < num_times; i++)
		{
			fout << chars[0];
		}
		if (chars[1] != ',')
		{
			fout << endl;
			fin >> num_times;
			fin >> chars;
		}
	}
}