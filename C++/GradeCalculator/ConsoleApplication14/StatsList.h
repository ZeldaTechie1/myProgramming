#include<iostream>
#include<string>

const unsigned int MAXCELLS = 6; //MAXSIZE changed to MAXCELLS *Educated Assumption
typedef double ListType;
class StatsList
{
public:
	StatsList();
	//ListType At(int num);	//I never found thisbeing used to I excluded it
	int Length();
	double Mean();
	double MeanNoHighLow();
	void PrintGradeCount();
	ListType GetHigh();
	ListType GetLow();
	bool NewGrade(ListType);
private:
	int GradeCountRange(double, double);
	ListType List[MAXCELLS];
	int Counter;
};