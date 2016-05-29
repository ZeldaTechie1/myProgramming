#include<iostream>
#include<string>

using namespace std;

class Stack
{
private:
	class Node
	{
	public:
		char data;
		Node*link;
	};
	Node*Top;

public:
	//setup initial conditions
	Stack()
	{
		Top = nullptr;//set the top to null
	}
	//delete all dynamic memory, etc.
	~Stack()
	{
		//if the top is not null then delete begin deleting nodes
		if (Top != nullptr)
		{
			//set a temp node to top 
			Node*temp = Top;
			//while top link isnt null continue deleting the nodes in the stack
			while (Top->link != nullptr)
			{
				Top = Top->link;
				delete temp;
				temp = Top;
			}
			//finally delete temp and set top to null again since its now empty
			delete temp;
			Top = nullptr;
		}
	}
	//add x to top of the stack
	void Push(char x)
	{
		//create a new node and give it data
		Node*N = new Node;
		N->data = x;

		//if top is null or the stack is empty then set the new node to be the top
		if (Top == nullptr)
		{
			Top = N;
			Top->link = nullptr;
		}
		//else just add the new node to the top of the list
		else
		{
			N->link = Top;
			Top = N;
		}
	}
	//remove the top item from the stack and return it
	char Pop()
	{
		//if the top isnt equal to null
		if (Top != nullptr)
		{
			//var to save the char we are popping
			char val;

			//create a temp pointer that points to top and shift top to the node bellow our temp
			Node*temp = Top;
			Top = Top->link;

			//save the data that we are poping and pop it
			val = temp->data;
			delete temp;

			return val; // return the data we just poped
		}
		//your are poping from a list stack that is empty
		else 
			return 'F';
	}
	//return type if the stack is empty, otherwise return false
	bool empty()
	{
		//check if the top is equal to null which woudl indicate its empty
		if (Top == nullptr)
			return true;
		else
			return false;
	}

};
