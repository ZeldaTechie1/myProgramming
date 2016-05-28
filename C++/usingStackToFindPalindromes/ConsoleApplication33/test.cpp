#include<iostream>
#include<string>

#include "stack.cpp"
#include<stack>

using namespace std;

//to check for correct input for Problem 3 and 4
void GetLong(long &input);

int main() 
{
	//Problem #1 Test Code
	/*
	Stack S;
	int reply;
	char ch;

	do{
		cout << "What do yo want to do?" << endl;

		cout << "1 Push" << endl;
		cout << "2 Pop" << endl;
		cout << "3 check if empty" << endl;
		cout << "4 clear stack" << endl;

		cout << "Input: ";
		cin >> reply;
		cout << endl;

		switch (reply)
		{
		case 1:
			cout << "What would you like to Push?: ";
			cin >> ch;
			S.Push(ch);
			break;
		case 2: 
			cout<<S.Pop()<<endl;
			break;
		case 3:
			cout<<S.empty()<<endl;
			break;
		case 4:
			S.~Stack();
		default:
			break;
		}
		
	} while (reply != 0);
	*/

	//Problem #2
	/*
	string words;
	do{
		
		//crate your two stacks and a var to place your result
		Stack S1;
		Stack S2;
		string result;

		//ask the user for a word
		cout << "Give me a string an I will check if its a palindrome: ";
		cin >> words;

		//Push the string to one stack
		for (int i = 0; i < words.length(); i++)
		{
			S1.Push(words[i]);
		}

		//Push half of the string from one stack to another
		for (int i = 0; i < ((words.length()) / 2); i++)
		{
			S2.Push(S1.Pop());
		}

		//Parity Issue
		if (words.length() % 2 == 1)
			S1.Pop();

		//pop both stacks simotaneously
		while (S1.empty() != true)
		{
			if (S1.Pop() != S2.Pop())
				result = "Not a Palindrome";
		}

		//output results
		if (result != "Not a Palindrome")
			result = "This is a Palindrom";
		cout << result << endl;
	} while (words != "no");
	*/

	//Problem #3
	/*
	//create a stack of long data, and have a long number that will store the info the user will give us
	stack<long> S;
	long number;

	//ask the user for a long number and check it for validity
	cout<<"Give me a number: ";
	//check that the user put in correct input && take in the long number
	GetLong(number);

	//push the modulus result of the numbers onto the stack, therefore converting to binary
	while (number / 2 != 0)
	{
		S.push(number % 2);
		number = number / 2;
	} 
	S.push(number);
	//pop them from the stack and print them, therefore outputing the number in binary
	while (S.empty() != true)
	{
		cout<<S.top();
		S.pop();
	}
	*/

	//Problem #4
	/*
	//create a stack of long data
	stack<long> S;
	//create a long number, base var, digit var, counter, and a temp for use later
	long number;
	int base;
	int digit;
	int counter=0;
	long temp;

	//ask the user for a number and check it for validity also, copy the number to temp since we are going to change the number
	cout << "Give me a number: ";
	GetLong(number); 
	temp = number;

	//ask the user for a base and a digit and take both in
	cout << endl << "Now give me the base you want to convert to: ";
	cin >> base;
	cout << endl << "Now give me a digit you would like me to locate in that number: ";
	cin >> digit;
	cout << endl;
	

	//push the modulus result of the numbers onto the stack, therefore converting to whatever base the user desires
	while (number / base != 0)
	{
		S.push(number % base);
		number = number / base;
	}
	S.push(number);

	cout << temp << " has ";

	//pop them from the stack, therefore checking for how many parts a digit is found in that specific base
	while (S.empty() != true)
	{
		if (S.top() == digit)
			counter++;
		S.pop();
	}

	cout << counter << " " << digit << "'s in base " << base << endl;

	//EXTRA for the sake of checking correctness
	cout << temp << " in base " << base << " is: ";
	while (temp / base != 0)
	{
		S.push(temp % base);
		temp = temp / base;
	}
	S.push(temp);
	while (S.empty() != true)
	{
		cout << S.top();
		S.pop();
	}
	cout << endl;
	*/

	
	//BONUS----------Problem #2 Modified to ignore space, apostrophes, quotes, commas, periods, etc...
	//take in a word from the user
	string words;
	cout << "Give me a string an I will check if its a palindrome: ";
	getline(cin, words);

	//loop to do the same thing over and over again just cuz
	do{
		//create both stacks, and string var to store the result, and creating a lCounter that keeps track of how many character are actually valid
		Stack S1;
		Stack S2;
		string result;
		int lCounter=0;

		//Push the string to one stack
		for (int i = 0; i < words.length(); i++)
		{
			//only push to the stack if the character is valid, and then add to the counter that keeps track of that
			if(((words[i] >= 97) && (words[i] <= 122)) || ((words[i] >= 65) && (words[i] <= 90))) //A=65, Z=90, a=97, z=122
			{
				S1.Push(words[i]);
				lCounter++;
			}
		}

		//Push half of the string from one stack to another
		for (int i = 0; i < (lCounter / 2); i++)
		{
			S2.Push(S1.Pop());
		}

		//Parity Issue, using the lCounter and not the word length since not all the chars in the word are valid
		if (lCounter % 2 == 1)
			S1.Pop();

		//pop both stacks simotaneously
		while (S1.empty() != true)
		{
			if (S1.Pop() != S2.Pop())
				result = "Not a Palindrome";
		}

		//output results
		if (result != "Not a Palindrome")
			result = "This is a Palindrom";
		cout << result << endl;

		cout << "Give me a string an I will check if its a palindrome: ";
		getline(cin, words);

	} while (words != "no");
	

	system("pause");
	return 0;
}

void GetLong(long &input) //function to check for valid long input
{
	cin >> input;

	//get inputs
	while (!cin || input > 1000000000 || input < 0)
	{
		cin.clear();
		cin.ignore(2000, '\n');
		cout << "Not a legal number" << endl;
		cout << "Again: ";

		cin >> input;
	}
}