#pragma once
#include <string>
#include <queue>
#include <ctime>
#include <windows.h>

double PCFreq = 0.0;
__int64 CounterStart = 0;

void StartCounter()
{
	LARGE_INTEGER li;
	if (!QueryPerformanceFrequency(&li))
		;

	PCFreq = double(li.QuadPart);

	QueryPerformanceCounter(&li);
	CounterStart = li.QuadPart;
}

double GetCounter()
{
	LARGE_INTEGER li;
	QueryPerformanceCounter(&li);
	return double(li.QuadPart - CounterStart) / PCFreq;
}


using namespace std;

class graph
{
	struct edge; //tells vertex struct that and edge will be created


	struct vertex
	{
		int data; //cities or places

		//dependant on the specific path
		vertex* prev;
		int weight; //this will be reset since its what's used to determine whether relax will do anything
		int index;

		vector<edge*> neighbors;

		vertex(int d)
		{
			data = d;
		}

		string printDW() //print vertex data and then the VERTEX weight
		{
			return to_string(data) + "-" + to_string(weight);
		}

		string printD()
		{
			return to_string(data);
		}
	};
	
	struct edge
	{
		vertex* start;
		vertex* end;
		int weight;

		edge(vertex* s, vertex* e, int w)
		{
			start = s;
			end = e;
			weight = w;
		}

	};

	class minHeap //Assume spot 0 on the vector is ignored
	{
		int parent(int i)
		{
			int temp =  i / 2;
			if (temp > 0)
				return temp;
			return i;
		}

		int lChild(int i)
		{
			int temp = i * 2;
			if (temp < arr.size())
				return temp;
			return i;
		}

		int rChild(int i)
		{
			int temp = (i * 2) + 1;
			if (temp < arr.size())
				return temp;
			return i;
		}

		void bubbleUp(int i)
		{

			int par = parent(i); //get parent

			if (arr[i]->weight != arr[par]->weight) //bubbleUp condition
				if (arr[i]->weight < arr[par]->weight)
				{
					flip(i, par);
					bubbleUp(par);
				}
		}

		void bubbleDown(int i)
		{
			int smallC = getSmallest(lChild(i), rChild(i)); //get the smallest of both children (covers out of bounds issues)

			if (arr[smallC]->weight != arr[i]->weight) //bubbleDown condition
				if (arr[smallC]->weight < arr[i]->weight)
				{
					flip(i, smallC);
					bubbleDown(smallC);
				}
		}

		int getSmallest(int a, int b)
		{
			//first cover possiblity where the indexes give are bigger than our current array size (we dont want out of bound errors)
			int temp = arr.size();

			if (a >= temp && b >= temp)
				return parent(a);
			else if (a >= temp)
				return b;
			else if (b >= temp)
				return a;
			else if (fmin(arr[a]->weight, arr[b]->weight) == arr[a]->weight) //If both indexes are withing range then find the smallest of the two
				return a;
			return b;
		}

		void flip(int a, int b) //used for bubbleUp and bubbleDown - updates the location it can be found on the minHeap
		{
			vertex* temp = arr[a];
			arr[a] = arr[b];
			arr[a]->index = a;
			arr[b] = temp;
			arr[b]->index = b;
		}

	public:

		vector<vertex*> arr; //the vector that holds all the vertexes (aka the minheap) (STARTS AT POSITION 1)

		minHeap()
		{
		}

		bool empty()
		{
			if (arr.size() <= 1) //this is because we keep the 1 location on the array empty
				return true;
			return false;
		}

		void insert(vertex* newVal) //include index on vertex
		{
			if (arr.empty())
				arr.push_back(NULL); //arr size is 1 - location empty is 0
			arr.push_back(newVal); //arr size is 2 - at location 1
			newVal->index = (arr.size()-1); //set index like this because it always adds at the back
			bubbleUp(arr.size() - 1); //required to bubble up that 1 start value with a weight of 0
		}

		vertex* extractMin()
		{
			return removeItem(1); //removing item at position one becasue position 0 is empty
		}

		vertex* removeItem(int i) //pass index for item that will be removed
		{
			vertex* temp = arr[i]; //save the item we are removing

			arr[i] = arr.back(); //last element in vector now become element in deleted slot
			arr.pop_back(); //delete last element in vector

			bubbleDown(i); //repair the heap starting with the position that we just deleted and then moving down

			return temp;
		}

		void changeValueAt(int i)
		{
			if (arr[i]->weight < arr[parent(i)]->weight)
				bubbleUp(i);
			else if (arr[i]->weight > arr[lChild(i)]->weight || arr[i]->weight > arr[rChild(i)]->weight) //has to be an or
				bubbleDown(i);
		}

		void testPrint()
		{
			int indexLevel = 0;
			int end = pow(2, indexLevel); //will start at 1
			for (int i = 1; i <= end; i++)
			{
				if (i == arr.size())
				{
					cout << endl;
					break;
				}
				if (i == end)
				{
					indexLevel++;
					end = pow(2, indexLevel);
					cout << endl;
				} 
				cout << " | " << arr[i]->weight << ":" << arr[i]->data << " | ";
			}
		}
	};

public: //ONLY FOR debug sake in main
	vector<vertex*> vertexList; //contains all the vertex es initially (STARTS AT position o)

public:
	
	void addVertex(int v)
	{
		vertexList.push_back(new vertex(v));
	}

	void addEdge(int x, int y, int w)
	{
		vertex* v1 = findVertex(x);
		vertex* v2 = findVertex(y);

		if (v1 == NULL || v2 == NULL) //make sure that both vertices exsist b4 adding an edge that connects them
			return;

		v1->neighbors.push_back(new edge(v1, v2, w));
	}

	void testDisplay()
	{
		for (vertex* v :vertexList)
		{
			cout << (v)->data << ": ";
			for (edge* e: v->neighbors)//loop through neighbors, print neighboor and its weight
				cout << " | " << (e->end)->data << " eWeight " << e->weight;
			cout << endl;
		}
	}

	//assumes that your start and end are NOT the same
	string shortestPath(int s, int e) //AKA DIJKSTRAS
	{
		StartCounter();

		vertex* start = findVertex(s);
		vertex* end = findVertex(e);

		if (start == NULL || end == NULL) //make sure that both vertices exsist in the
			return "Vertices don't exsists";

		resetToInfinity(); //sets all vertex weights to infiniti

		start->weight = 0; //the location where we are starting our searching obviously needs to have a weight of 0 - so we start our search there
		
		//place all the vertices into the priorityqueue AKA "cloud"
		minHeap cloud; //AKA priority queue
		for (vertex* v : vertexList) //should be one value larger that the size of the vertexList since here we start our list at position 1 and not 0
			cloud.insert(v);
		
		//the while loop is GUARANTEED to run atleast once unless its empty in which case a path doesnt exsist because there are no points
		while (!cloud.empty()) //loop until the minHeap is empty which means all shortestest paths form ONE point to ALL others have been calced
		{
			vertex* temp = cloud.extractMin(); //remove smallest item from heap

			if (temp->weight == INT_MAX) //accounts for lose vertices
				break;

			for (edge* ed : temp->neighbors)
					relax(cloud, ed);
		}
		
		cout << "time taken(secs): " << GetCounter() << endl;

		return printPath(start, end);
	}

private:

	void relax(minHeap &h, edge* e)
	{
		vertex* temp = e->end;
		int endVertexWeight = (temp->weight);
		int possiblePath = (((e->start)->weight) + e->weight); //current path to node

		if (possiblePath < endVertexWeight) //check if current path is faster than previous path
		{
			//set new weigth and previous on the vertex we have found a quicker path too
			temp->weight = possiblePath;
			temp->prev = (e->start);

			h.changeValueAt(temp->index); //change the index with the a mh method for automatically readjusting
		}
	}

	void resetToInfinity()
	{
		for (vertex* v: vertexList)
			(v)->weight = INT_MAX;
	}

	string printPath(vertex* start, vertex* end) //recursive help method to print the path
	{
		if (start == end)
			return end->printD();
		else
			return printPath(start, end->prev) + ", " + end->printDW();
	}

	vertex* findVertex(int x) //since our data is the same as its index location we can do this, mucho fast!
	{
		if(x>=vertexList.size()) //this works because out data starts at 0 and our positions on the vector start at 0
			return NULL; //if you cant find the vertex
		else
			return vertexList[x];
	}
};