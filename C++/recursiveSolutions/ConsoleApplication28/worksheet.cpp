#include <iostream>
#include <string>

using namespace std;

//Problem #1
long Sumseries(long N);

//Problem #2
long SumXY(long X, long Y);

//Problem #3
void Outputrev(char s[], int index);

//Problem #4
int Euclid(int P, int Q);

//Problem #5
int Hanoi(int n);

int main()
{
	//Problem #1
	/*
	long number;

	cout << "Give me a number: ";
	cin >> number;
	cout << endl;

	cout << "The sum of those series of numbers is: " << Sumseries(number) <<endl;
	*/

	//Problem #2
	/*
	long num1, num2;

	cout << "Give me a number: ";
	cin >> num1;
	cout << endl << "Give me another number smaller than the first: ";
	cin >> num2;
	cout << endl;

	cout << "The sum of that sequence is: " << SumXY(num1, num2) << endl;
	*/

	//Problem #3
	/*
	const int size = 5;
	char s[size] = {'h', 'e', 'l', 'l', 'o'};

	Outputrev(s, size-1);

	cout << endl;
	*/

	//Problem #4
	/*
	int P, Q;

	cout << "Give me a numbe: ";
	cin >> P;
	cout << endl << "Now give me a number smaller than the previous one: ";
	cin >> Q;
	cout << endl;

	cout<<Euclid(P, Q) << "  is your greatest common factor between "<< P << " and  " << Q << endl;
	*/

	//Problem 5
	/*
	int plates;

	cout << "Give me a number: ";
	cin >> plates;
	cout << endl;

	cout<<Hanoi(plates);
	*/

	system("pause");
	return 0;
}

//Problem #1
long Sumseries(long N)
{
	if (N != 0)
	{
		N= N + Sumseries(N - 1);
	}	
	else
		return N;
	
}

//Problem #2
long SumXY(long X, long Y)
{
	if (X < Y)
	{
		X = X + SumXY(X + 1, Y);
		
	}	
	else
		return X;
}

//Problem #3
void Outputrev(char s[], int index)
{
	if (index > 0)
	{
		cout << s[index];
		Outputrev(s, index - 1);
	}
	else
		cout << s[index];
	
}

//Problem #4
int Euclid(int P, int Q)
{
	if (P%Q == 0)
		return Q;
	else
		Euclid(Q, (P%Q));
}

//Problem #5
int Hanoi(int n)
{
	if (n > 1)
		n = 2 * Hanoi(n-1) + 1;
	return n;
}