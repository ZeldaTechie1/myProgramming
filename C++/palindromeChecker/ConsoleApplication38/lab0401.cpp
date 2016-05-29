//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
//
// Name: Bryan Cancel
// Date: April 1, 2015
// Class: 2380.02
// Semester: Spring 2015
//
// Program Name: 04.01 lab
// Program Description: <Fill out>
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\


//input/output to the console
#include<iostream>
//the string class
#include<string> 
using namespace std;

/*
In this lab I use the ternary operator several times
It is a shorthand for an if/else statement that works like this
(condition) ? (if_true) : (if_false)
*/




/*
For a palindrome we want to consider only the first and last characters
at any given step.  Thus, we will only check if they match, and then
recursively check the smaller string without the first and last characters.

To do this we use the substr function.  The two arguments are:
pos - Start position of the character of the current word (0 based)
n - Length of the substring starting from the start position pos.

So for the string a = "hello", the call
a = a.substr(1,3) would set a to "ell"

*/


bool IsPalindrome(string str)
{
	int n = str.length() - 1; //last location on that the string str

	//check both the first location and last location
	for (int i = 0; i < 2; i++)
	{
		//adjust for checking the first value and the last value
		int index;
		if (i == 0)
			index = 0;
		else
			index = n;

		//check for lower case
		if (islower(str[index]) == false)
		{
			//if upper case make lower case
			if (isupper(str[index])==true)
			{
				str[index] = tolower(str[index]);
			}
			else //if its not a number ignore the value and return a substring without that value
			{
				if (str.length() > 1) //make sure the length is bigger than one becuase you dont want to return an empty substring
				{
					if (index == 0)
					{
						return IsPalindrome(str.substr(1, n));
					}
					else
					{
						return IsPalindrome(str.substr(0, n));
					}
				}
				else //if the length is 1 then return true becase it doesnt matter or count for the palindrome since it isnt a letter
					return true;
			}
		}
	}

	if (str.length() <= 1) //if the length is less that or equal to one return true since it doesnt matter what the middle letter is in a palindrome with odd characters
		return true;
	else if (str[0] != str[n]) //if the values dont match up its an automatic false
		return false;
	else if (str[0] == str[n]) // if the values do match up go here
	{
		if (str.length() == 2) // if the length is 2 for a palindrome with even valid characters check the last two values take out one and return so i can go into the base case
		{
			if (str[0] == str[n])
				return IsPalindrome(str.substr(1, n));
			else // if the last two value dont match up return false because it isnt a palindrome
				return false;
		}
		else // if the length is bigger than two then simply return a subring without the first and last value
			return IsPalindrome(str.substr(1, n - 1));
	}
}



/*
We now want to modify the above function to ignore white space and punctuation.
This can be done simply by ignoring any character that is not a valid
letter.  We also want to make it lower case if it is an upper case letter.
We must ignore both at the front and back of the string.

The valid ranges for lower case letters are 97 - 122
Upper case characters are 65 - 90

- set the front and back character to their tolower representations
- if the front character isn't valid, recursively call and ignore it
- if the back character isn't valid, recursively call and ignore it
- base case for matching
- check the base case for length
- recursive call with substring


Try: A nut for a jar of tuna
*/

char tolower(char c)
{
	return (c >= 'A' && c <= 'Z') ? (char)((int)c + 32) : c;
}

bool islower(char c)
{
	return (c >= 'a' && c <= 'z') ? true : false;
}

bool isupper(char c) // own function to check for uppercase
{
	return (c >= 'A' && c <= 'Z') ? true : false;
}


bool IsPalindromeWS(string str)
{
	//uses the previous function to check if its a palindrome first
	if (IsPalindrome(str) == true)
	{
		//substring creation for ease of use later
		string sub = str.substr(1, (str.length() - 1));

		//base case when the length of the substring is one or smaller there is no longer anything to compare
		if (str.length() <= 1)
		{
			//check the final character just in case
			if ((str[0] >= 'A' && str[0] <= 'Z') || (str[0] >= 'a' && str[0] <= 'z'))
				return true;
			else
				return false;
		}
		else
		{
			//check if the any spot in the string has anything else but a letter, if the string is all letters do this if not...
			if ((str[0] >= 'A' && str[0] <= 'Z') || (str[0] >= 'a' && str[0] <= 'z'))
				return IsPalindromeWS(sub);
			//it will end up here
			else
				return false;
		}
	}
	//if it isnt well... that it cant be a palindrome with only letters
	else
		return false;
}


int main()
{
	//get the input string
	string input_string;

	cout << endl << "Please enter a string:";
	getline(cin, input_string);
	cout << endl;

	do{
		cout << "The input " << (IsPalindrome(input_string) ? "is" : "is not") << " a palindrome" << endl;

		cout << "The input " << (IsPalindromeWS(input_string) ? "is" : "is not") << " a palindrome with only letters" << endl;

		cout << endl << "Please enter a string:";
		getline(cin, input_string);
		cout << endl;

	} while (input_string != "no");

	system("pause");
	return 0;
}