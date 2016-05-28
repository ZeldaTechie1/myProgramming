//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
// Name: Bryan Cancel
// Date: April 8, 2015
// Class: 2380.02
// Semester: Spring 2015
//
// Program Name: 04.08 lab
// File Name: LinkedList0408.cpp
// Program Description: <Fill out>
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
 

#include "LinkedList0408.h"

//constructor
LinkedList::LinkedList()
{
	//should set head pointer
	Head = NULL;
}


//destructor
LinkedList::~LinkedList()
{
	//should call delete list
	DeleteList();
}

/*
This function adds a new node to the end of the single linked list. If it is the
first node, then head will still be NULL.

head -> [2|] -> [8|] -> [6|X]
*/

void LinkedList::Add(int newdata)
{
	//create a new node to hold the data with a terminal (NULL) next pointer
	Node* temp = new Node;
	temp->data = newdata;
	temp->next = NULL;

	//check whether head has been initialized (is NULL)
	//if not, make the new node head and set prev
	if (Head == NULL)
	{
		Head = temp;
	}
	else
	{
		//if head has been initialized
		//find the end of the chain with a pointer
		Node *cur = Head;
		while (cur->next != NULL)
			cur = cur->next;


		//add the new node on to the last node in the list
		//set pointer
		cur->next = temp;
	}
}


//This function walks through the list and prints the integer for each of the nodes
//We are using a copy of head, so changing it's value does not alter the
//variable in main
void LinkedList::PrintList()
{
	//walk through the list
	Node *cur = Head;
	while (cur != NULL)
	{
		//print the data for the current node
		cout << cur->data << " ";
		cur = cur->next;
	}
	cout << endl;
}



//This function walks through the list and deletes each node
void LinkedList::DeleteList()
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


//Call mergesort passing the entire list
void LinkedList::Sort()
{
	MergeSort(Head);
}

//implement Merge sort for a single linked list implementation
void LinkedList::MergeSort(Node* &Head)
{
	//base case
	if (Head->next == NULL)
		return;
		
	//find the midway point to split in two
	Node* midpoint=Head;
	Node* curr=Head;
	while (curr->next != NULL)
	{
		curr = curr->next;
		midpoint = curr;
		if (curr->next != NULL)
			curr = curr->next;
	}


	//add nullpointer to end of first (split them) (check special cases)
	curr = Head;
	while (curr->next != midpoint)
		curr = curr->next;
	curr->next = NULL;

	//call two sublists - these are now sorted
	MergeSort(Head);
	MergeSort(midpoint);

	//now the two sublists are sorted
	//loop through each and put them in the right order
	Node *newhead; //always points at the front of the new list
	Node *tail;    //always points at the back of the new list

	//set up the first node in the new list
	if (Head->data < midpoint->data)
	{
		newhead = Head;
		Head = Head->next;
	}
	else
	{
		newhead = midpoint;
		midpoint = midpoint->next;
	}
	newhead->next = NULL;
	tail = newhead;


	//while we still have two lists, keep adding the next item to the end
	while (Head!=NULL && midpoint!=NULL)
	{
		//of our new list, move the pointer, and set the tail
		if (Head->data < midpoint->data)
		{
			tail->next = Head;
			Head = Head->next;
		}
		else
		{
			tail->next = midpoint;
			midpoint = midpoint->next;
		}
		tail = tail->next;
		tail->next = NULL;

	}

	//attach the rest of the list that hasn't been processed to our combined list.
	if (Head != NULL)
		tail->next = Head;
	else if (midpoint != NULL)
		tail->next = midpoint;

	//at the end you have a single sorted list
	Head = newhead; 
}

