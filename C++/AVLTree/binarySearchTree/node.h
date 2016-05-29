#pragma once

//CLASS NODE

class node
{
public:
	node *left;
	node *right;
	int data; //has to be positive numbers, -1 is used to indicate that nodes non exsistance
	int height = 1; //a height of 1 if the node is a leaf

	node(int x)
	{
		data = x;
		left = NULL;
		right = NULL;
	}

};