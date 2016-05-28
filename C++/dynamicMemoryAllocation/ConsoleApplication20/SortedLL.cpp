//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
// Program: Lab 0225
// Author:
// Course: CSCI/CMPE 2380
// Description: This is the implementation file for the linked list class
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\ 

#include "SortedLL.h"

//constructor
SortedLL::SortedLL()
{
	//should set head pointer
	Head = NULL;
}


//destructor
SortedLL::~SortedLL()
{
	//should call delete list
	DeleteList();
}

/*
This function adds a new node to the end of the doubly linked list. If it is the
first node, then head will still be NULL.

Here we are using head directly, so that when we create a new node it stores
it in the variable being used in main.

head <=> [2|] <=> [8|] <=> [6|X]
*/

void SortedLL::Add(int newdata)
{
	//create a new node to hold the data with a terminal (NULL) next pointer
	Node*N = new Node;
	N->data = newdata;
	N->next = NULL;

	//check whether head has been initialized (is NULL)
	if (Head == NULL)
	{
		//if not, make the new node head and set prev
		Head=N;
		Head->prev = NULL;
		Head->next = NULL;
	}
	else//if head has been initialized
	{
		Node*temp = Head;
		//find the end of the chain with a pointer
		while (temp->next != NULL)
		{
			temp = temp->next;
		}

		//add the new node on to the last node in the list
		temp->next=N;

		//set pointers both forward and backwards
		N->prev = temp;
	}
}

/*
This function adds a new node in the list where the
data is sorted from low to high.
*/

void SortedLL::SortedAdd(int newdata)
{
	//create a new node to hold the data with a terminal (NULL) next pointer
	Node*N = new Node;
	N->data = newdata;
	N->next = NULL;

	//check whether head has been initialized (is NULL)
	if (Head == NULL)
	{
		//if it is null, make the new node head and set prev
		Head = N;
		N->prev = NULL;
	}
	else//else head is not null
	{

		//find the spot to insert it
		//check for special cases
		//1. New Data in front 2. New Data in back 3. New data somewhere in between
		if (N < Head)
		{
			Head->prev = N;
			N->next = Head;
			Head = N;
			Head->prev = NULL;
		}
		else
		{
			Node *temp = Head;

			while (N>temp->next)
			{
				temp = temp->next;
			}
			
			N->next = temp->next;
			N->prev = temp;
			Node*Next = temp->next;
			Next->prev = N;
			temp->next = N;
			
			
		}
	}

	

	//check for special cases
}

//This function walks through the list and prints the integer for each of the nodes
//We are using a copy of head, so changing it's value does not alter the
//variable in main
void SortedLL::PrintList()
{
	//walk through the list starting at head
	Node *curr = Head;

	cout << endl << "List: ";
	//print the data for the current node
	while (curr != NULL)
	{
		cout << curr->data <<" ";
		curr = curr->next;
	}
	cout << endl;
}



//This function walks through the list and deletes each node
void SortedLL::DeleteList()
{
	//make sure the list has data
	if (Head != NULL)
	{
		//delete first node
		Node *next = Head->next;
		delete Head;
		//loop through list deleting each node
		while (next != NULL)
		{
			Head = next;
			next = Head->next;
			delete Head;
		}
		//set pointer to null
		Head = NULL;
	}
}