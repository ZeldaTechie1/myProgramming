//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
// Name: Bryan Cancel
// Date: April 15, 2015
// Class: 2380.02
// Semester: Spring 2015
//
// Program Name: 04.15 lab
// File Name: lab0415.cpp
// Program Description: QuickSort (Efficient VS In-Efficient)
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\

#include<iostream>
#include<string>
using namespace std;

//Here we use quicksort to sort the string of characters
//in an inefficient way where we copy each string to sort

string QuickSort(string input)
{
//initial conditions
int smallindex = 0;
int index = 0;
char pivot;

//base case if only one (or no) element
if (input.length()<=1)
	return input;

//cover exception with two elements
if (input.length() == 2)
{
	//if what is at your first location is bigger than what is at your last location
	if (input[0] > input[1])
	{
		// the swap
		char temp = input[0];
		input[0] = input[1];
		input[1] = temp;
	}
	//call quicksort on the first val and second val
	return (QuickSort(input.substr(0, 1)) + QuickSort(input.substr(1, 2)));
}

//choose pivot as middle element
pivot = input[input.length() / 2];

//swap pivot with index
input[input.length() / 2] = input[index];
input[index] = pivot;

//execute quicksort loop
for (index = 1; index <= input.length()-1; index++)
{
	//if what you are checking is smaller than your pivot then it belong to the left of your "wall" or in location of smallindex
	if (input[index] < pivot)
	{
		//increase small index since we found a nem number that is smaller than our pivot
		smallindex++;
		//switch what is at index with what is at smallindex
		char temp = input[index];
		input[index] = input[smallindex];
		input[smallindex] = temp;
	}
}

//swap pivot with smallindex
input[0] = input[smallindex];
input[smallindex] = pivot;

//recursively call each side
return ((QuickSort(input.substr(0, smallindex))) + pivot + (QuickSort(input.substr(smallindex + 1, input.length() - 1))));
}

//Here we use quicksort to sort the string of characters
//we sort the string in place without making any copies, so
//for a call to quicksort we pass in the low and high indices
//we sort to.
void EfficientQuickSort(string &input, int low, int high)
{
	//initial conditions
	int smallindex = low;
	int index = low;
	char pivot;

	//base case if only one element
	if (low == high)
		return;

	//take care of 2 element exception
	if ((low + 1) == high)
	{
		//value it low is bigger than value at high 
		if (input[low] > input[high])
		{
			//then swap
			char temp = input[low];
			input[low] = input[high];
			input[high] = temp;
		}
		//call quicksort on the first val and then the second val
		EfficientQuickSort(input, low, low);
		EfficientQuickSort(input, high, high);
	}

	//choose pivot as middle element
	pivot = input[(high + low) / 2];

	//swap pivot with index
	input[(high + low) / 2] = input[index];
	input[index] = pivot;

	//execute quicksort loop
	//start at low+1 since low occupies our pivot and go through the whole list
	for (index = low + 1; index <= high; index++)
	{
		//if what you are checking is smaller than your pivot then it belong to the left of your "wall" or in location of smallindex
		if (input[index] < pivot)
		{
			//increase small index since we found a nem number that is smaller than our pivot
			smallindex++;
			//switch what is at index with what is at smallindex
			char temp = input[index];
			input[index] = input[smallindex];
			input[smallindex] = temp;
		}
	}

	//swap pivot with smallindex
	input[low] = input[smallindex];
	input[smallindex] = pivot;

	//recursively call each side, FIRST Make sure you low is bigger or equal to your high so your code doesnt attempt some weird inveted array
	if (low <= smallindex - 1)
		EfficientQuickSort(input, low, smallindex - 1);
	if (smallindex + 1 <= high)
		EfficientQuickSort(input, smallindex + 1, high);
}

//in main we just want to take in a string 
int main()
{
	string input;
	cout << "Please input a string:" << endl;
	//get the string
	getline(cin, input);

	do{
		cout << "-----NOT-----" << endl;
		cout << "Efficient: ";
		//sort the list
		string sorted = QuickSort(input);
		//print the output
		cout << sorted << endl;

		cout << "-----YES-----" << endl;
		cout << "Efficient: ";
		//efficiently sort the list
		EfficientQuickSort(input, 0, input.length() - 1);
		//print the output
		cout << input << endl;

		cout << "Please input a string:" << endl;
		//get the string
		getline(cin, input);

	} while (input != "no");

	system("pause");

	return 0;
}

