//Bryan Cancel
//Comp Sci 2
//Assignment 4
//CalculatorClass.cpp (holds class implementations)

//Include the file where the funcitons are declared
#include"Calculator.h"

//default constructor
Calculator::Calculator()
{
	number = 0;
}

//constructor with one var input
Calculator::Calculator(double num)
{
	number = num;
}

//clear out by calling default constructor
void Calculator::clear()
{
	Calculator();
}

//add the num to the number
void Calculator::add(double num)
{
	number += num;
}

//subtracts the num from the number
void Calculator::subtract(double num)
{
	number -= num;
}

//multiplies the number by num
void Calculator::multiply(double num)
{
	number *= num;
}

//divides the number by num
void Calculator::divide(double num)
{
	number /= num;
}

//display what the number currently is
double Calculator::display()
{
	return number;
}

//overloads + constructor; It takes in the ohter calculator and since its currently working with the current calculator you can work with that one too
Calculator Calculator::operator+(Calculator& other)
{
	//creates a double that is a combo of the number of the calculator we are currently working with and then the calculator that we were working with
	double number12 = number + other.number;
	//returns the number to the constructor so the number is the new Calculator equals the var that was a combo of the other two Calculators
	return Calculator(number12);
}
