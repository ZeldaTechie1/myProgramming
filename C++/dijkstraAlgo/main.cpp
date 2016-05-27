#include <string>
#include <iostream>
#include <fstream>
#include "weightedDirectedGraph.h"

using namespace std;

int main()
{
	ifstream myFile;
	myFile.open("inputFile.txt");
	graph G;

	//make sure file is open
	if (!myFile.is_open()) 
	{
		cout << "Error - Can't Find File" << endl;
		system("pause");
	}

	//read in the two sizes first to determine the "stops" for the other loops
	string temp;
	getline(myFile, temp);
	int vertexListSize = stoi(temp);
	getline(myFile, temp);
	int edgeListSize = stoi(temp);

	cout << "vertices: " << vertexListSize << " edges: " << edgeListSize << endl;

	//add all vertices to the graph
	for (int i = 0; i < vertexListSize; i++)
		G.addVertex(i);

	int v1, v2, w, i=0; //vars we will use when reading edges

	for (i; i < (edgeListSize) || i < 530000; i++) //add edges to the graph (the or was switch to an and, and used to debug)
	{
		myFile >> temp;
		v1 = stoi(temp);
		myFile >> temp;
		v2 = stoi(temp);
		myFile >> temp;
		w = stoi(temp);

		G.addEdge(v1, v2, w);
	}

	myFile.close();

	cout << "vertices: " << G.vertexList.size() << " edges: " << i << endl;
	system("pause");

	cout << "Find Shortest Path From: " << 42615 << " to " << 264340 << endl;
	cout << G.shortestPath(42615, 264340) << endl;

	system("pause");
	return 0;
}