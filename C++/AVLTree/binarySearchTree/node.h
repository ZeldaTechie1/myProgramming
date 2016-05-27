#pragma once

//CLASS NODE

class node
{
public:
	node *left;
	node *right;
	int data;
	int height = 1;

	node(int x)
	{
		data = x;
		left = NULL;
		right = NULL;
	}

};