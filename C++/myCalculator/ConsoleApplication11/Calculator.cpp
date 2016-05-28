//Bryan Cancel
//Comp Sci 2
//Assignment 4
//Calculator.cpp (holds main)

#include<iostream>
#include<string>
#include"Calculator.h"

using namespace std;

//Didnt put many comments here since this is all code you gave us so... If I assumed incorrectly let me know
int main()
{

	Calculator mycalc;

	mycalc.clear();
	mycalc.add(4.52);
	mycalc.add(3.789);
	mycalc.divide(2.6);
	mycalc.multiply(3.12);
	mycalc.subtract(2.678);
	cout << mycalc.display() << endl; // prints out "7.2928"
	mycalc.clear();
	mycalc.add(5.0);
	cout << mycalc.display() << endl; // prints out "5"

	//advanced stuff #1: add a constructor
	Calculator calc1;
	cout << calc1.display() << endl; //prints out 0
	//advanced stuff #2: add a parameterized constructor
	Calculator calc2(5);
	cout << calc2.display() << endl; //prints out 5
	
	//advanced stuff #3: Define calculator addition (overload the '+' operator)
	Calculator calc3(7);
	calc1 = calc2 + calc3;
	cout << calc1.display() << endl; //prints out 12
	/*
	//advanced stuff #4 (Bonus 10): Create an 'undo' method for the calculator | SHOULD WORK FOR UP TO 50 UNDOS
	mycalc.undo();
	mycalc.undo();
	cout << "stuff: " << mycalc.display() << endl; //prints out 7.2928
	*/


	system("pause");
	return 0;
}