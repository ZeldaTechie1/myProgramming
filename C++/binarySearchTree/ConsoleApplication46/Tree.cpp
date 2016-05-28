//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
// Program: Lab 0422
// File: Tree.cpp
// Author: Bryan Cancel
// Course: CSCI/CMPE 2380
// Description: 
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\ 


#include "Tree.h"


//constructor
Tree::Tree()
{
	Root = NULL;
}
//destructor
Tree::~Tree()
{
	DeleteTree(Root);
}

//add to the tree
void Tree::Insert(int newdata)
{
	//create a node and store the data
	Node *N = new Node;
	N->Data = newdata;

	//set left/right pointers to null
	N->Right = NULL;
	N->Left = NULL;

	//search tree for insertion point.  keep track of node which will be the parent
	//if root is null, make this root
	if (Root == NULL)
	{
		Root = N;
	}
	else
	{
		//create a cur and parent pointer
		Node *parent = Root;
		Node *curr = Root;

		//while the current pointer isn't null, walk through the tree based on data
		while (curr != NULL)
		{
			//in the first run of the loop parent and current are the same, this fixes that
			if (curr != Root)
				parent = curr;
			
			if (newdata > curr->Data) //if the new data is bigger the data of the node we are on shift the curr to the right
				curr = curr->Right;
			else if (newdata <= curr->Data) //if the new data is smaller the data of the node we are on shift the curr to the left
				curr = curr->Left;
		}

		//attach node to parent based on value
		if (newdata <= parent->Data)
			parent->Left = N;
		else if (newdata > parent->Data)
			parent->Right = N;
	}
}



//This function walks through the tree and prints the integer for each of the nodes
//an in-order traversal LVR
void Tree::PrintTree()
{
	PrintFromNode(Root);
}

//This function walks through the tree and deletes each node
//it should be a post-order traversal LRV
void Tree::DeleteTree(Node* vertex)
{
	//base case
	if (vertex == NULL)
		return;
	DeleteTree(vertex->Left); //first return left side of the tree
	DeleteTree(vertex->Right); //then return right side of the tree
	delete vertex; // after both of the side are deleted from recursion delete the parent node, etc. etc.
}
//This function walks through the tree and prints the integer for each of the nodes
//an in-order traversal LVR
void Tree::PrintFromNode(Node* vertex)
{
	//base
	if (vertex == NULL)
		return;
	PrintFromNode(vertex->Left); //take care of left node
	cout << vertex->Data << " , "; //print the vertex
	PrintFromNode(vertex->Right); //take care of the right nodes
}