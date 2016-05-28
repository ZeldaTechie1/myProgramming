//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
// Program: Lab 0218 Header
// Author:
// Course: CSCI/CMPE 2380
// Description: This is the DList header file
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\ 

#include <iostream>
#include <string>

using namespace std;



#ifndef DLIST_H
#define DLIST_H


class DList
{
public:
	//should initialize any needed variables
	DList();
	//delete any dynamically allocated memory
	~DList();
	//adds item to back of item_list and the number to back of item_amounts
	void Add(string word, int num);
	//prints the order
	// #  Item
	void PrintOrder();
	//returns the number of items
	int GetNumberItems();
private:
	//the dynamically allocated item list
	string *item_list;
	//the dynamically allocated item amounts
	int *item_amounts;
	//the number of distinct items in the list
	int number_items;
};



#endif