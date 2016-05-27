#include <iostream>
using namespace std;

int* memoi;

int optimalChangeHelper(int c[], int total);

int optimalChange(int c[], int total)
{
	memoi = new int [(total + 1)]; //this is so that you can go straight to that value in the array to see whether its optimal solution has been found
	for (int i = 0; i < (total + 1); i++)
		memoi[i] = 0; //fill everything with 0

	//recursive solution
	return optimalChangeHelper(c, total);
}

int optimalChangeHelper(int c[], int total)
{

	int min = INT32_MAX;

	for (int i = 0; i < sizeof(c) ; i++)
	{

		//get 2 ways to divide it with particular coin
		int leftSide = total - c[i];
		int rightSide = c[i];

		if (leftSide > 0 && leftSide < total)
		{
			int left = memoi[leftSide];
			int right = memoi[rightSide];

			if (left == 0) //if left piece hasnt yet been calculated
				left = (optimalChangeHelper(c, leftSide) + 1);

			if (right == 0) //if right piece hasnt yet been calculated
				right = (optimalChangeHelper(c, rightSide) + 1);

			//update array
			memoi[leftSide] = left;
			memoi[rightSide] = right;

			min = fmin(min, (left + right));
		}
	}
	return min;
}

int main()
{
	int coins[] = { 1,8,9 }; //get 16
	//greedy yields (9,1,1,1,1,1,1,1) - 8 coins
	//optimal yileds (8,8) - 2 coins

	cout << "Optimal Change is: " << optimalChange(coins, 16) << endl;

	system("pause");
	return 0;
}