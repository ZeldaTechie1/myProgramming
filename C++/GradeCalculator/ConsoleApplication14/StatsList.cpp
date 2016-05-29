#include"StatsList.h"

//Constructor
StatsList::StatsList()
{
	//set the counter that keeps track of your index back to 0
	Counter=0;
}

//wtf
//ListType StatsList::At(int num);

//return how many grades there are in list OR return Counter
int StatsList::Length()
{
	return Counter;
}

//return mean of all grades
double StatsList::Mean()
{
	double Total = 0;
	//loop through all list and add up grades
	for (int r = 0; r < Counter; r++)
	{
		Total = Total + List[r];
	}
	//then return the total of all the grades divided by the Counter of how many grades there are
	return (Total / Counter);
}

//return the mean of all grades without the highest and lowest grade
double StatsList::MeanNoHighLow()
{
	double Total = 0;
	//loop through all list and add up grades
	for (int r = 0; r < Counter; r++)
	{
		//add to total as long as the number being added isnt the highest or lowest number | use GetHigh() and GetLow()
		if (List[r] != GetHigh() && List[r] != GetLow())
		{
			Total = Total + List[r];
		}
	}
	//then return the total of all the grades divided by the Counter of how many grades there are, minus two since you removed the high and low grades
	return (Total / (Counter-2));
}

//print the number of each grade use the private GradeCountRange function
void StatsList::PrintGradeCount()
{
	//REFERANCE: A=100-90 | B=89-80 | C=79-70 | D=69-60 | F=59-0
	//variable for high low and let wich is the char for the specific letter
	double low=90.0; 
	double high=100.0;
	char let=65;

	//loop that prints out how many of each letter grade there are until it gets to G which isnt a letter grade
	while (let < 71)
	{
		//line that prints everthing nicely
		std::cout << let << ": " << GradeCountRange(low, high) << std::endl;
		//if the you get an a there is a range of 11 number you can get to still get an a, in any other situation its only 10 so this handles the exception
		if (high == 100)
			high = 89.99;
		else //subtract by ten to move on to a lower range of values
			high = high - 10;
		//subtract by ten to move on to a lower range of values
		low = low - 10;
		//if low is lower than 60 or a D then it goes to zero so any grade in that range woud be an F
		if (low < 60)
		{
			low = 0;
		}
		//add to the letter char to move on to the next letter
		let++;
		//take care of E exception
		if (let == 69)
			let++;
	}	
}

//return the highest grade out of the list
ListType StatsList::GetHigh()
{
	ListType high=0;
	//loop through the whole loop to find the highest value
	for (int r = 0; r < Counter; r++)
	{
		if (List[r]>=high)
			high = List[r];
	}
	return high;
}

//return the lowest grade out of the list
ListType StatsList::GetLow()
{
	ListType low=100;
	//loop through the whole loop to find the lowest value
	for (int r = 0; r < Counter; r++)
	{
		if (List[r]<=low)
			low = List[r];
	}
	return low;
}

//add the newgrade to the list IF the list isnt full, returns true for success and false in the case of a full list
bool StatsList::NewGrade(ListType num)
{
	//if list isnt full add the grade to the list
	if (Counter < MAXCELLS)
	{
		List[Counter]=num;
		Counter++;
		return true;
	}
	else // return false so It gives you an error message in the main
		return false;
}

//PRIVATE: loops through the list and find all grades that are withing a certain range of a grade letter EX:(100-90)=A
int StatsList::GradeCountRange(double low, double high)
{
	int count=0;
	//loop through the list and if grade falls within boundries add to count
	for (int r = 0; r < MAXCELLS; r++)
	{
		if (List[r] >= low && List[r] <= high)
			count++;
	}
	return count;
}

//VARS WE WORK WITH
//ListType List[MAXCELLS];
//int Counter=0;