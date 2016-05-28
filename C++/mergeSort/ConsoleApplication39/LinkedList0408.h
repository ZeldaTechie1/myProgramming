//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
// Name: <Put your name here>
// Date: April 8, 2015
// Class: 2380.02
// Semester: Spring 2015
//
// Program Name: 04.08 lab
// File Name: LinkedList0408.h
// Program Description: <Fill out>
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
 

#include<iostream>
using namespace std;


//a basic node for a single linked list with data
struct Node
{
	int data;
	Node *next;
};

//a linked list class we will use
class LinkedList
{
public:
	LinkedList();
	~LinkedList();
	void Add(int);
	void PrintList();
	void Sort();
private:
	void DeleteList();
	void MergeSort(Node*&);
	Node* Head;
};
