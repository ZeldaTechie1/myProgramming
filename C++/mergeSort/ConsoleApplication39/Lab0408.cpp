//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
//
// Name: <Put your name here>
// Date: April 8, 2015
// Class: 2380.02
// Semester: Spring 2015
//
// Program Name: 04.08 lab
// File Name: lab0408.cpp
// Program Description: <Fill out>
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
 

#include "LinkedList0408.h"

int main()
{
	//initialize our pointer to NULL
	LinkedList LL;
	int input;

	do{

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
			//if they're positive, add them to the linked list
			if (input > 0)
				LL.Add(input);
		} while (input > 0);


		cout << "The numbers you entered are:" << endl;
		//this just prints them in order
		LL.PrintList();

		cout << "The numbers sorted:" << endl;
		//sort the list
		LL.Sort();
		//print the sorted list
		LL.PrintList();
		LL.~LinkedList();

	} while (input != -1);

	system("pause");

	return 0;
}
