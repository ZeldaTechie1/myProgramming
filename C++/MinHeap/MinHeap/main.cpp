#include <iostream>
#include <string>
#include "minHeap.h"
using namespace std;

template <class T>
void heapSort(T * items, int start, int end) //O(nlogn)
{
	minHeap<T> minH;
	for (start; start <= end; start++)
		minH.insert(items[start]);
	start = 0;
	for (start; start <= end; start++) //a better way to do this(I beleive) would be do pass the pointer by reference and then simply point to the beginig of our vector (after deleting our previous dynamically allocated array) so we avoid the many really unecessary copies
		items[start] = minH.extractMin(); //however since the teach didnt pass it by reference this will have to do
}


int main()
{
	////////////////////////////////////////////////
	//Step 1: Implement a basic min-heap priority queue
	////////////////////////////////////////////////
	minHeap<double> pq;

	pq.insert(53);
	pq.insert(17);
	pq.insert(3);
	pq.insert(178);
	pq.insert(519);
	pq.insert(15);
	pq.insert(42);
	pq.insert(5);

	cout << "Extracting Minium: " << pq.extractMin() << endl; //3
	cout << "Extracting Minium: " << pq.extractMin() << endl; //5
	cout << "Extracting Minium: " << pq.extractMin() << endl; //15
	cout << "Extracting Minium: " << pq.extractMin() << endl; //17

	pq.insert(93);
	pq.insert(2);
	pq.insert(7);
	pq.insert(83);

	cout << endl;
	//2, 7, 42, 53, 83, 93, 178, 519
	while (!pq.empty())
	{
		cout << "Extracting Minium: " << pq.extractMin() << endl;
	}
	cout << endl;

	int size = 30;
	for (int i = 0; i<size; i++)
	{
		pq.insert(rand());
	}

	//items should display in sorted order
	while (!pq.empty())
	{
		cout << "Extracting Minium: " << pq.extractMin() << endl;
	}
	cout << endl;

	//////////////////////////////////////////////////////////////////////
	//Step 2: Now use your min-heap priotiy queue to implement a sorting algorithm:
	//-What is the worst case run time of your sorting algorithm?
	//////////////////////////////////////////////////////////////////////

	double * numbers;
	int max = 100000;
	numbers = new double[max];

	//randomly fill array
	for (int i = 0; i<max; i++)
		numbers[i] = rand();

	//write sorting routine using your min-heap priority queue data type
	heapSort(numbers, 0, max - 1);
	//display items (now in sorted order)
	for (int i = 0; i<max; i++)
		cout << numbers[i] << endl;

	system("pause");

	return 0;
}