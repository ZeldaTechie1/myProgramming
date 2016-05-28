//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
// Program: Lab 0422
// File: lab0422.cpp
// Author:
// Course: CSCI/CMPE 2380
// Description: 
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\ 

#include "Tree.h"


//*******************************************************************************
//Main, just gets numbers and inserts in tree.  Then it prints
//*******************************************************************************
int main()
{
	int input;
	Tree tree;

	do{
		cout << "New Binary Tree" << endl;

		cout << "Please input some numbers." << endl;
		//get positive numbers
		do
		{
			cout << "#";
			cin >> input;
			while (!cin)
			{
				cin.clear();
				cin.ignore(2000, '\n');
				cout << "Not a legal integer" << endl;
				cout << "#: ";
				cin >> input;
			}
			//if they're positive, add them to the tree
			if (input > 0)
				tree.Insert(input);
		} while (input > 0);

		cout << "The numbers you entered are:" << endl;
		//this just prints them in order
		tree.PrintTree();

	} while (input != -1);

	system("pause");
	return 0;
}
