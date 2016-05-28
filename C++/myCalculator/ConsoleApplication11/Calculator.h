//Bryan Cancel
//Comp Sci 2
//Assignment 4
//Calculator.h (holds class declarations)

//class declaraions
class Calculator
{
//all public functions
	public:
		//constructors
		Calculator();//constructor with one var
		Calculator(double num);//constructor with two vars
		//functions
		void clear();//clear out the number by calling the default constructor
		void add(double num);//adds to the number
		void subtract(double num);//subtracts to the number
		void multiply(double num);//multiply the number, num times
		void divide(double num);//divide the number by num
		double display();//display the number
		//Overiding the operator 
		Calculator operator+(Calculator& other);
	private:
		//declares the number var
		double number;
};