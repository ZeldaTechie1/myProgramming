#pragma once
#include "node.h"

//CLASS AVLTree

class AVLTree
{
private:
	node *root;

public:
	AVLTree()
	{
		root = NULL;
	}

	int height()
	{
		return root->height;
	}

	void insert(int x)
	{
		insert(x, root);
	}

	void display()
	{
		display(root);
	}

	int height(node *&n)
	{
		if (n == nullptr)
			return 0;
		return n->height;
	}

	int getData(node *&n)
	{
		if (n == nullptr)
			return -1;
		return n->data;
	}

	void sort(int * &arr, int sortStart, int arrLength)
	{
		//place all values into the avl tree
		for (int i = sortStart; i <= arrLength; i++)
			insert(arr[i], root);

		//use the find smallest function that returns the smallest smallest value inside of the binary search tree and place the values in the locations of the array
		for (int i = sortStart; i <= arrLength; i++)
		{
			arr[i] = findSmallest(root);
		}
	}

private:

	int findSmallest(node *&r)
	{
		if (r != NULL)
		{
			if ((r->left) == NULL)
			{
				int tempD = r->data; //grab the data value
				r = r->right;
				if (r == NULL)
					delete r;
				return tempD; //return the data value
			}
			else
				findSmallest(r->left);
		}
	}

	void treeRepair(node *&r)
	{
		if (abs(height(r->left) - height(r->right)) > 1) //if the difference between the two side of the tree are bigger than 1
		{
			node *a = r; //extra pointer to unbalanced node so we can still keep connection to the upper parts of the tree

			if (fmax(height(r->left), height(r->right)) == height(r->right)) //if right side of the tree is the biggest
			{
				node *b = a->right;//set pointer b - subtree of a that has the tallest height

				if (fmax(height(b->left), height(b->right)) == height(b->left)) //RIGHT LEFT
				{
					doubleRotation('l', r, a, b, b->left);
				}
				else //RIGHT RIGHT
				{
					singleRotation('l', r, a, b);
				}

			}
			else //if left side of tree is biggest
			{
				node *b = a->left; //set pointer b - subtree of a that has the tallest height

				if (fmax(height(b->left), height(b->right)) == height(b->right)) //LEFT RIGHT
				{
					doubleRotation('r', r, a, b, b->right);
				}
				else //LEFT LEFT
				{
					singleRotation('r', r, a, b);
				}
			}
		}
	}

	void doubleRotation(char dir, node *&r, node *&a, node *&b, node *c) //can be made up of two single rotations
	{
		node *cL = c->left;
		node *cR = c->right;
		r = c;

		if (dir == 'r')
		{
			c->left = b;
			c->right = a;
			a->left = cR;
			b->right = cL;
		}
		else
		{
			c->left = a;
			c->right = b;
			a->right = cL;
			b->left = cR;
		}

		updateHeight(a);
		updateHeight(b);
		updateHeight(c);
	}

	void singleRotation(char dir, node *&r, node *&a, node *&b)
	{
		r = b;
		if (dir == 'l') //left rotation
		{
			node *bL = b->left;
			b->left = a;
			a->right = bL;

		}
		else //right rotation
		{
			node *bR = b->right;
			b->right = a;
			a->left = bR;
		}
		updateHeight(a);
		updateHeight(b);
	}

	void updateHeight(node *&r)
	{
		r->height = fmax(height(r->left), height(r->right)) + 1;
	}

	void display(node *&r)
	{
		if (r != NULL)
		{
			display(r->left);
			cout << "Left Child : IT | Height : Right Child" << endl;
			cout << getData(r->left) << " : " << r->data << "|" << r->height << " : " << getData(r->right) << endl;
			display(r->right);
		}
	}

	void insert(int x, node *&r)
	{
		if (r == NULL)
			r = new node(x);
		else
		{
			if (x < r->data)
				insert(x, r->left);
			else
				insert(x, r->right);
			updateHeight(r);
			treeRepair(r);
		}
	}
};