#include<iomanip>
#include<string>
#include<iostream>

using namespace std;

//	PROBLEM #1
/*
int sum(int num)
{
	int sum = 0;
	while (num > 0)
	{
		sum +=num;
		num--;
	}
	return sum;
}
*/

//PROBLEM #2
/*
int sum(int num)
{
	int sum=0;
	do
	{
		sum +=num;
		num--;
	} while (num > 0);
	return sum;
}
*/

//PROBLEM #3

int sum(int num)
{
	int sum = 0;
	for (num; num > 0; num--)
	{
		sum += num;
	}
	return sum;
}


//PROBLEM #4

float Minimum(float a, float b, float c)
{
	if (a < b && a < c)
		return a;
	else if (b < a && b < c)
		return b;
	else
		return c;
}


//PROBLEM #5

int Multiply(int a, int b)
{
	int temp = b;
	while (a > 1)
	{
		b = b + temp;
		a--;
	}
	return b;
}


//PROBLEM #6

int Divide(int a, int b)
{
	int count=0;
	for (count; a > 0; count++)
	{
		a = a - b;
	}
	return count;
}


//PROBLEM #BONUS

int Modulo(int a, int b)
{
	int count = 0;
	for (count; a > 0; count++)
	{
		a = a - b;
	}
	a = a + b;
	return a;
}


int main()
{
	cout << "Problem 3: " << sum(5) << endl;

	cout << "Problem 4: " << Minimum(24.7, 12.5, 17.9999) << endl;

	cout << "Problem 5: " << Multiply(7, 8) << endl;

	cout << "Problem 6: " << Divide(56, 8) << endl;

	cout << "Problem Bonus: " << Modulo(62, 8) << endl;

	system("pause");

	return 0;
}