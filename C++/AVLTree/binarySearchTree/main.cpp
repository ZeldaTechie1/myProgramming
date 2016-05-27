#include <iostream>
#include <cmath>
using namespace std;
#include "AVLTree.h"
#include "node.h"

//MAIN

int main()
{
	AVLTree tree;

	tree.insert(5);
	tree.insert(21);
	tree.insert(17);
	tree.insert(10);
	tree.insert(7);
	tree.insert(12);
	tree.insert(400);
	tree.insert(22);
	tree.insert(36);
	tree.insert(50);

	tree.display();
	cout << "Tree height: " << tree.height() << endl;

	AVLTree tree2;
	int size = 100000;
	for (int i = 0; i < size; i++)
	{
		tree2.insert(rand());
	}
	cout << "Tree height: " << tree2.height() << endl;

	AVLTree tree3;
	size = 100000;
	for (int i = 0; i < size; i++)
	{
		tree3.insert(i);
	}
	cout << "Tree height: " << tree3.height() << endl;


	//now implement a sorting routine using your AVLTree.
	//What is the worst case big-Oh run time of your sort? 
	int * numbers = new int[size];
	for (int i = 0; i < size; i++)
		numbers[i] = rand();

	AVLTree tree4;
	tree4.sort(numbers, 0, size - 1);

	system("pause");

	return 0;
}