#include "DList.h"

//should initialize any needed variables
DList::DList()
{
	item_list = new string[1];
	item_amounts = new int[1];
	number_items = 0;
}

//delete any dynamically allocated memory
DList::~DList()
{
	delete[] item_list;
	delete[] item_amounts;
	item_list = new string[number_items];
	item_amounts = new int[number_items];
}

//adds item to back of item_list and the number to back of item_amounts
void DList::Add(string word, int num)
{
	number_items++;

	//create temp arrays
	string* tempS = new string[number_items];
	int* tempI = new int[number_items];

	//copy arrays to temp arrays
	for (int r = 0; r < (number_items-1); r++)
	{
		tempS[r] = item_list[r];
		tempI[r] = item_amounts[r];
	}

	//delete arrays and create new ones with the right size
	DList::~DList();

	//copy temp arrays to arrays
	for (int r = 0; r < (number_items - 1); r++)
	{
		item_list[r] = tempS[r];
		item_amounts[r] = tempI[r];
	}

	//add new item to the end of each array

	item_list[number_items-1]=word;
	item_amounts[number_items-1]=num;

	//delete temp arrays
	delete[] tempS;
	delete[] tempI;
}

//prints the order
// #  Item
void DList::PrintOrder()
{
	//for loop and print what is in the index of that location for both arrays
	for (int r = 0; r < number_items;r++)
		cout<<item_list[r]<<" "<<item_amounts[r]<<endl;
}

//returns the number of items
int DList::GetNumberItems()
{
	int total = 0;
	//loop through item_amounts, add all the values to total
	for (int r = 0; r < number_items; r++)
	{
		total = total + (item_amounts[r]);
	}
	return total;
}
