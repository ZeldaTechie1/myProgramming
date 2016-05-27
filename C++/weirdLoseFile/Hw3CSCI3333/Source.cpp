#include <iostream>
#include <string>
using namespace std;
#include "node.h"
#include "AVLTree.h"

//Method #1

//Given a string and "base" value between 2 and 10, returns
//the integer represented in base "base" by string s.
int baseReader(string s, int base) //Runs is O(n) where is in the number of character is the s string
{
	int tempL = s.length(); //length of current string

	if (tempL == 1)//if we are at the last digit start the maths
		return ((int)s[0] - 48);
	else
		return  ((baseReader(s.substr(0, tempL - 1), base) * base) + (s[tempL - 1] - 48));
}

//Method #2

//Given an ammount of money, along with an array of coin denominations,
//output the smallest possible number of coins required to perfectly
//add up to (make change for) the given amount.  To make sure it is always possible
//to make the given change amount, assume one of the denomination values is a 1 (a penny).
int optimalChange(int amount, int * denominations, int numDenoms) //Not sure about Running time (It needs to check through array of coins in each recursive call, but the amount of times the methods is called recursively depend on the ammount)
{
	cout << amount << endl;
	if (amount == 0)
		return 0;
	else
	{
		for (int i = 0; i < numDenoms; i++)
		{
			//if denoms are not < than amount then remove from array
			//if you have gone past a total that is bigger to or equal to an solution you already have, stop
		}
	}
}

//Method #3

//Assume A is a sorted array of increasing distinct integers.
//return 'true' if A[i] = i for some i between start and end, 'false' if not.
//Your algorithm should run in O(log n) time, where n = end-start is the
//number of items you are considering.
bool sameIndex(int * A, int start, int end) //Runs in O(log n) time worst case (half of portion of the array we are working on is eliminated each time)
{
	int mid = (end + start) / 2;
	//cout << start << " " << end << " " << A[mid] << "vs" << mid << endl;//For Debuging
	if (start <= end)
	{
		if (A[mid] == mid)
			return true;
		else if (A[mid] > mid)
			return sameIndex(A, 0, mid - 1);
		else if (A[mid] < mid)
			return sameIndex(A, mid + 1, end);
	}
	else
		return false;
}

int main()
{
	//Main Testing Code For Method #1
	
	/*
	cout << "Test For Method 1 (should be 55, 25)" << endl;
	cout << baseReader("2001", 3) << endl;  //Should print 55
	cout << baseReader("31", 8) << endl; //Should print 25 (Joke: why does the cool computer scientist get halloween and christmas confused?)
	*/
	
	cout << "Test for Method 2 (Should be 5,5,4)" << endl;
	int denoms[] = { 1,10,25 };//pennies, dimes, and quarters.
	cout << optimalChange(80, denoms, 3) << endl; //Should display 5 (2 quarters and 3 dimes).  If you get 8, you are doing it wrong.
	
	/*
	//The order of the given denominations should not change the result
	int denoms1[] = { 25,1,10 }; //pennies, dimes, and quarters.
	cout << optimalChange(80, denoms1, 3) << endl; //Should display 5 (2 quarters and 3 dimes).  If you get 8, you are doing it wrong.
	

	//Another example.  The optimal number of coins is 4. (32,25,10,1)
	int denoms2[] = { 1,10,25,32 };
	cout << optimalChange(75, denoms2, 4) << endl;
	*/
	/*
	cout << "Test for Method 3 (Should be true,false)" << endl;
	//should return true since A[5] == 5.
	int A[] = { -50,-10,0,1,3,5,8,10 };
	cout << sameIndex(A, 0, 7) << endl;

	//should return false.
	int B[] = { -50,-10,0,1,3,6,8,10 };
	cout << sameIndex(B, 0, 7) << endl;
	*/

	system("pause");
	return 0;
}