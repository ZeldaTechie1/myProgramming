//POSSIBLE IMPROVEMENTS
/*
-use templates so I can have various types (requires multiple hashing techniques depending on var type)
-use arrays instead of vectors because they are faster... duh... (requires funcs:  clear, resize, size) for array
*/

//By: Bryan Cancel

#pragma once

#include <iostream>
#include <string>
#include <vector>
#include <cmath>

using namespace std;

//has the template option but only works for ints for now
class quadraticHashTable
{

	//this allows you to take advantage of the full storage capabilities of int
	struct item {
		int data; //irelevant until active or deleted flags go to true
		char flag = 'e'; //'d' for deleted (contains KEEPS searching, insert CAN), 'e' (contains STOPS searching, insert CAN), 'f' (contains KEEPS searching, insert CAN'T)
	};

	int totalNumItems = 0;
	vector<item> hashList;

public:
	//constructor
	quadraticHashTable()
	{
		hashList.resize(11); //start size at 11 for simplicity's sake
	}

	quadraticHashTable(int s)
	{
		hashList.resize(s);
	}

	//destructor
	~quadraticHashTable()
	{
		hashList.clear();
	}

	//insert with quadtratic probing
	void insert(int num)
	{
		totalNumItems++;

		int originalHashLoc = num % (hashList.size()); //only for ints
		int hashLoc = originalHashLoc;
		
		for (int i = 1; hashList[hashLoc].flag == 'f'; i++)//DOESNT insert in filled locations 
		{
			hashLoc = (originalHashLoc + (int)pow(i, 2));//I base myself off of the original hashlocation
			hashLoc = hashLoc % hashList.size();
		}
		
		hashList[hashLoc].data = num;
		hashList[hashLoc].flag = 'f'; //filled

		if ((hashList.size() / 2) < (totalNumItems + 1))//resizes b4 it really needs to (if 11 slots, and you have 4 filled, you add one, then you will have 5 and it will resize because next time you will have to resize)
			resize();
	}

	//lazy delete
	void remove(int num) //its only going to remove if the value is found, other wise it will just try to find it - will only delete first instance
	{
		int originalHashLoc = num % (hashList.size());
		int hashLoc = originalHashLoc;

		for (int i = 1; hashList[hashLoc].flag!='e'; i++) //assumes that we will eventually find an empty slot (because our hash size is a prime and at any time is at most less than half full
		{

			if (num == hashList[hashLoc].data)
			{
				hashList[hashLoc].flag = 'd';
				totalNumItems--;
				break;
			}

			hashLoc = (originalHashLoc + (int)pow(i, 2));
			hashLoc = hashLoc % hashList.size();
		}

	}

	bool contains(int num)
	{
		int originalHashLoc = num % (hashList.size()); 
		int hashLoc = originalHashLoc;

		for (int i = 1; hashList[hashLoc].flag!='e'; i++) //assumes that we will eventually find an empty slot (because our hash size is a prime and at any time is at most less than half full
		{
			if (num == hashList[hashLoc].data)
				return true;

			hashLoc = (originalHashLoc + (int)pow(i, 2));
			hashLoc = hashLoc % hashList.size();
		}
		return false;
	}

	void testDisplay()
	{
		cout << "start of HashList" << endl;
		cout << "total items in HashList: " << totalNumItems << endl;
		for (int i = 0; i < hashList.size(); i++)
			if (hashList[i].flag=='f')//only prints filled
				cout << "index: " << i << " " << hashList[i].data << endl;
			else
				cout << "index: " << i << " " << "-" << endl;
		cout << "end of HashList" << endl << endl;
	}

private:

	void resize()
	{
		totalNumItems = 0;
		vector<item> oldHashList=hashList; //create copy of old hashList so I can retreive data from it
		hashList.clear();
		hashList.resize(nextPrime(oldHashList.size())); //resize my hashlist to the next prime that is atleast twice the size of my old size

		for (int i = 0; i < oldHashList.size(); i++)
			if (oldHashList[i].flag == 'f') //make sure that location is filled
				insert(oldHashList[i].data); //insert the item into our new hash list
	}

	//requires prime
	int nextPrime(int oldPrime)
	{
		int newPrime = (oldPrime * 2) + 1; //new prime must be atleast double the size of the old one - start at an odd number to calc next prime
		for (int i = 3; i <= (int)sqrt(newPrime); i += 2) //going to check if the number is divisible by odds until the square root of the num im checking
		{
			if (newPrime%i == 0) //if it is divisble by one of these then its isnt a prime
			{
				newPrime += 2; //if it isnt a prime, go to the next odd number and check that one
				i = 1; //reset to start checking all nums again for ournew number
			}
		}
		return newPrime;
	}

};