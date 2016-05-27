#pragma once
#include <iostream>
#include <vector>

using namespace std;

template <class T> class minHeap //Assume spot 0 on the vector is ignored
{
	int parent(int i)
	{
		return i / 2; //should truncate
	}

	int lChild(int i)
	{
		return i * 2;
	}

	int rChild(int i)
	{
		return (i * 2) + 1;
	}	

	void bubbleUp(int i)
	{
		if (arr[i] != arr[0]) //if we are equivalent to the root node we can assume that all the nodes in bellow us are good are good (NOT SUPER SURE ABOUT THIS)
		{
			int par = parent(i);
			if (arr[i] < arr[par])
			{
				flip(i, par);
				bubbleUp(parent(i));
			}		
		}
	}

	void bubbleDown(int i)
	{
		//check largest of two children
		int small = getSmallest(lChild(i), rChild(i));

		//compare that one to the current spot, if it smaller than that at i then flip and reheapify
		if (small!= i && arr[small] < arr[i])
		{
			flip(i, small);
			bubbleDown(small);
		}
	}

	void flip(int a, int b)
	{
		T temp = arr[a];
		arr[a] = arr[b];
		arr[b] = temp;
	}

	int getSmallest(int a, int b)
	{
		int temp = arr.size();

		if (a >= temp && b >= temp)
			return parent(a);
		else if (a >= temp)
			return b;
		else if (b >= temp)
			return a;
		else if (fmin(arr[a], arr[b]) == arr[a])
			return a;
		return b;
	}

public:

	vector<T> arr;

	minHeap()
	{
	}

	bool empty()
	{
		if (arr.size() <= 1)
			return true;
		return false;
	}

	void print()
	{
		for (T temp : arr)
			cout << temp << endl;
	}

	void insert(T newVal)
	{
		if (arr.empty())
			arr.push_back(NULL);
		arr.push_back(newVal);
		bubbleUp(arr.size()-1);
	}

	T extractMin() 
	{
		return removeItem(1); //removing item at position one becasue position 0 is empty and when extracting min it should alwasy bet at pos 1
	}

	T removeItem(int i) //pass item that will be removed
	{
		T temp = arr[i];

		arr[i] = arr.back(); //last element in vector now become element in deleted slot
		arr.pop_back(); //delete last element in vector

		bubbleDown(i); //repair the heap starting with the position that we just deleted and then moving down

		return temp;
	}

	void changeValueAt(int i, T newValue)
	{
		arr[i] = newValue;
		if (newValue < parent(i))
			bubbleUp(i);
		if (newValue > lChild(i) && newValue > rChild(i))
			bubbleDown(i);
	}
};
