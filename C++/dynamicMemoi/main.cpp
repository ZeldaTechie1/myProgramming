#include <iostream>
#include <vector>
using namespace std;

vector<vector <int>> memoi;

void testPrint(int d[], int s, int e, int size)
{
	for (int r = 0; r < size; r++)
	{
		cout << " | ";
		for (int c = 0;c < size; c++)
		{
			cout << memoi[r][c] << " | ";
		}
		cout << endl;
	}
}

int recursiveHelper(int d[], int s, int e)
{
	if (s == e)
		return 0;
	else
	{
		if (memoi[s][e] != -1) //check if I have already calculated that in my 2d array
			return (memoi[s][e]);
		else
		{
			int min = ((d[s - 1] * d[s] * d[e]) + recursiveHelper(d, (s + 1), e)); //chop here (matrix 1) CHOP (other matrices)

			//wont run if there are only 2 matrices in total within range
			for (int i = (s + 1); i < e; i++) //start at second way of chopping, moves on too last
				min = fmin(min, (recursiveHelper(d, s, i) + (d[s - 1] * d[i] * d[e])) + recursiveHelper(d, (i + 1), e)); //in 0 you find the other call
			
			memoi[s][e] = min;
			return min;
		}
	}
}

int chainMult(int d[], int s, int e)
{
	//create an 2d vector of the correct dimmensions
	int size = (e + 2) - s;
	memoi.clear();
	vector<int> row(size, -1); //size ammount of -1

	//fill 2d array with -1 s
	for (int i = 0; i < size; i++)
		memoi.push_back(row);

	//call the recursive helper
	int x = recursiveHelper(d, s, e);

	//testPrint
	//testPrint(d, s, e, size);

	return x;
}

int main()
{

	//This array denotes the dimensions for a sequence of matrices A1,A2,....  In this case:
	//A1 is a 40x20, A2 is a 20x30, A3 is a 30x10, etc.
	int dimensions[] = { 40,20,30,10,30,8,4,2,5,7,3,83,5,10,3,5,8,24,5,6,9,3,12,4,3,26,9,4,12,3,5,16,2,12,5,14,3,12,53,8,2,59,42,11,10,20 };
	
	//compute the optimal cost of multiplying the given subchain of the matrices.  For example, chainMult(dimensions,1,3) should return the
	//optimal number of operations needed to compute A1*A2*A3.  Verify by hand that 14000 is the correct answer in this case, then implement your algorithm.
	cout << chainMult(dimensions, 1, 3) << endl; //14000
	cout << chainMult(dimensions, 1, 4) << endl; //26000
	cout << chainMult(dimensions, 1, 15) << endl; //6521
	cout << chainMult(dimensions, 1, 25) << endl; //????
	cout << chainMult(dimensions, 1, 35) << endl; //????
	cout << chainMult(dimensions, 1, 45) << endl; //????
	

	system("pause");

	return 0;
}