#pragma once
#include <string>
#include <list>
#include <queue>

using namespace std;

class graph
{
	struct vertex
	{
		string data;
		vertex* prev;
		bool visited = false;

		list<vertex*> neighbors;

		vertex(string x)
		{
			data = x;
		}
	};

	list<vertex*> vertexList;

public:
	//assume that your start and end are NOT the same
	string shortestPath(string s, string e) //no need to catch an exception where a path isnt found between vertices that DO exsist, since it isnt a directed graph
	{

		queue<vertex*> Q;

		vertex* start = findVertex(s);
		vertex* end = findVertex(e);

		if (start == NULL || end == NULL) //take care of exception
			return " ";
		
		//Sets prev value until the desired location is found, since we are doing breadthfirst search, once we find the value we have found a or one the shortest paths
		start->visited = true;
		Q.push(start);//need to push the first value to stack since it doesnt need a previous
		while (!Q.empty())//loops through queue
		{
			vertex* temp = Q.front();

			if (temp->data == end->data)
				break;

			Q.pop();
			for (list<vertex*>::iterator itr2 = (temp->neighbors).begin(); itr2 != ((temp)->neighbors).end(); itr2++)//loop through neighboors
			{
				if ((*itr2)->visited == false)
				{
					(*itr2)->prev = temp;
					(*itr2)->visited = true;
					Q.push(*itr2);
				}
			}
		}

		resetToNotVisited();//this is done so that next time we search our search algo doesnt recycle the prev values that we had before
		return printPath(start, end);
	}

	void addVertex(string v)
	{
		vertexList.push_back(new vertex(v));
	}

	void addEdge(string x, string y)
	{
		vertex* v1 = findVertex(x);
		vertex* v2 = findVertex(y);

		if (v1 == NULL || v2 == NULL)
			return;

		v1->neighbors.push_back(v2);
		v2->neighbors.push_back(v1);
	}

	void testDisplay()
	{
		for (list<vertex*>::iterator itr1 = vertexList.begin(); itr1 != vertexList.end(); itr1++)
		{
			cout << (*itr1)->data << ": ";
			for (list<vertex*>::iterator itr2 = ((*itr1)->neighbors).begin(); itr2 != ((*itr1)->neighbors).end(); itr2++)
			{
				cout << (*itr2)->data << " | ";
			}
			cout << endl;
		}
	}

private:

	void resetToNotVisited()
	{
		for (list<vertex*>::iterator itr1 = vertexList.begin(); itr1 != vertexList.end(); itr1++)
			(*itr1)->visited = false;
	}

	string printPath(vertex* start, vertex* end) //recursive help method to print the path
	{
		if (start == end)
			return end->data;
		return printPath(start, end->prev) + ", " + end->data;	
	}

	vertex* findVertex(string x)
	{
		for (list<vertex*>::iterator itr = vertexList.begin(); itr != vertexList.end(); itr++)
		{
			if ((*itr)->data == x)
				return *itr;
		}
		return NULL;
	}
};