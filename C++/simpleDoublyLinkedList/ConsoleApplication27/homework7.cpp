#include <iostream>
#include <string>

#include"homework7.h"

using namespace std;

int main()
{
	LinkedList<int> LL1;
	int userInput;
	int num; // for add at a location

	cout <<endl<< "-------------------- List 1 --------------------"<<endl;

	do
	{

		cout << endl << "choose an option" << endl;

		//Print all the options
		cout << "1 Add Front" << endl;
		cout << "2 Add Back" << endl;
		cout << "3 Add at Location" << endl;
		cout << "4 Remove Front" << endl;
		cout << "5 Remove Back" << endl;
		cout << "6 Get Front" << endl;
		cout << "7 Get Back" << endl;
		cout << "8 Get Length" << endl;
		cout << "9 Print" << endl;
		cout << "10 Sort" << endl;

		cout << "USER: ";
		cin >> userInput;
		cout << endl;

		//Go to the apropiate case
		switch (userInput)
		{
		case 1:
			//add x to front of list
			cout << "Add Front: ";
			cin >> LL1.input;
			cout << endl;
			LL1.addFront(LL1.input);
			break;
		case 2:
			cout << "Add Back: ";
			cin >> LL1.input;
			cout << endl;
			//add x to back of list
			LL1.addBack(LL1.input);
			break;
		case 3:
			//add x as the ith thing in the list
			//if there are less than i things, add it to the back
			cout << "What to Add at Loc: ";
			cin >> LL1.input;
			cout << endl;
			cout << "What Loc: ";
			cin >> num;
			cout << endl;
			LL1.add(LL1.input, num);
			break;
		case 4:
			//remove and return front item from list
			cout << LL1.removeFront() << " was removed from the front" << endl;
			break;
		case 5:
			//remove and return back item from list
			cout << LL1.removeBack() << " was removed from the back" << endl;
			break;
		case 6:
			//return value of back item (but don't remove it)
			cout << "Front: " << LL1.getFront() << endl;
			break;
		case 7:
			//return value of front item (but don't remove it)
			cout << "Back: " << LL1.getBack() << endl;
			break;
		case 8:
			//return how many items are in the list
			cout << "Length: " << LL1.length() << endl;
			break;
		case 9:
			//print all elements in the linked list
			cout << "List: "; LL1.print(); cout << endl;
			break;
		case 10:
			LL1.sort(); cout << endl << "Your list has been sorted" << endl;
		default:
			break;
		}

	} while (userInput != 0);

	/*
	
	cout <<endl<< "-------------------- List 2 --------------------"<<endl;

	LinkedList<int> LL2;

	do
	{

		cout << endl << "choose an option" << endl;

		//Print all the options
		cout << "1 Add Front" << endl;
		cout << "2 Add Back" << endl;
		cout << "3 Add at Location" << endl;
		cout << "4 Remove Front" << endl;
		cout << "5 Remove Back" << endl;
		cout << "6 Get Front" << endl;
		cout << "7 Get Back" << endl;
		cout << "8 Get Length" << endl;
		cout << "9 Print" << endl;

		cout << "USER: ";
		cin >> userInput;
		cout << endl;

		//Go to the apropiate case
		switch (userInput)
		{
		case 1:
			//add x to front of list
			cout << "Add Front: ";
			cin >> LL2.input;
			cout << endl;
			LL2.addFront(LL2.input);
			break;
		case 2:
			cout << "Add Back: ";
			cin >> LL2.input;
			cout << endl;
			//add x to back of list
			LL2.addBack(LL2.input);
			break;
		case 3:
			//add x as the ith thing in the list
			//if there are less than i things, add it to the back
			cout << "What to Add at Loc: ";
			cin >> LL1.input;
			cout << endl;
			cout << "What Loc: ";
			cin >> num;
			cout << endl;
			LL2.add(LL2.input, num);
			break;
		case 4:
			//remove and return front item from list
			cout << LL2.removeFront() << " was removed from the front" << endl;
			break;
		case 5:
			//remove and return back item from list
			cout << LL2.removeBack() << " was removed from the back" << endl;
			break;
		case 6:
			//return value of back item (but don't remove it)
			cout << "Front: " << LL2.getFront() << endl;
			break;
		case 7:
			//return value of front item (but don't remove it)
			cout << "Back: " << LL2.getBack() << endl;
			break;
		case 8:
			//return how many items are in the list
			cout << "Length: " << LL2.length() << endl;
			break;
		case 9:
			//print all elements in the linked list
			cout << "List: "; LL2.print(); cout << endl;
			break;
		default:
			break;
		}

	} while (userInput != 0);

	
	cout <<endl << "-------------------- Comparing List --------------------"<<endl;

	cout << "Should be T: ";
	if (LL1 == LL2)
		cout << "true";
	else
		cout << "false";
	
	cout << endl;

	cout << " Should be F: ";
	if (LL1 != LL2)
		cout << "false";
	else
		cout << "true";
	*/

	system("pause");
	return 0;
}