/////////////////////////////////////////////////////////////////////
// 
// Name: Bryan Cancel
// Date: 10/17/14
// Class: CSCI 1370.01
// Semester: Fall 2014
// CSCI/CMPE 1370 Instructor: Tim Wylie
//
// This program simulates a two player game of Pig. Both players are
// computer simulated, but the user is able to choose the strategy
// for each player.
//
// This program makes use of functions. Because we have two players
// we are repeating certain actions in the game (asking for the 
// players' strategy and performing the actions for a turn of the
// game for each player). Functions allow us to write the code one
// time (in the function), then call the function each time we want
// to use that block of code. We use parameters (values passed to
// the function) to give the function different values to work with.
//
/////////////////////////////////////////////////////////////////////


#include<iostream>
#include<cstdlib>
#include<string>
#include<time.h>

using namespace std;

//int playerRoll(int strat, string name); //							??????????	FIX
//int getStrat(string name);//											??????????	FIX


////////////////////////////////
// Note: It is best to not work on this program in the order that things are
// written in this file. Start by writing pseudocode, then write the function
// prototypes, followed by the functions, and finally write the main function.
////////////////////////////////


////////////////////////////////
// Put the function prototypes here
// You will write three functions: One to get the player's strategy from user
// input, another to simulate a turn of the game, and a third to print the
// game results.

int checkForInt(int num);

int turn(int player, int stop);

void printResults(string p1, int t1, string p2, int t2);

int getRandomNum(int lowRange, int highRange);


// End of function prototypes. Move on to write the block of code in the
// main function
////////////////////////////////


int main()
{
    int total_player1 = 0; // Player 1 score tracker
    int total_player2 = 0; // Player 2 score tracker
    int player1_strat = 0; // Player 1's strategy for each turn 
    int player2_strat = 0; // Player 2's strategy for each turn
	
    // seed the random number generator.
    // Notice that we seed the random number generator in the main function
    // (not in the player roll function), and we make sure not to put the
    // random number generator inside a loop. This is because we only want
    // to seed the random number generator ONCE per program run.
    srand(static_cast<int> (time(NULL)));

    
    ////////////////////////////////
    // Write code from here until the end comment. Use the comments as guidelines.
    
    
    // Get the strategy for each player (use a function).
    // You should write a single function and call it twice (once for
    // each player).

	//Prompt for Player 1
	cout << "Enter Player1's play until strategy: ";
	do{
	player1_strat = checkForInt(player1_strat);
	}while(player1_strat<0);

	//Prompt for Player 2
	cout << "Enter Player2's play until strategy: ";
	do{
	player2_strat = checkForInt(player2_strat);
	}while(player2_strat<0);
	
    
    // Use a loop to have the two players continue to take turns until one of
    // has a total game score of 100 or greater. If the first player wins, make
    // sure that you don't allow the second player to take a turn (quit the loop
    // as soon as one player reaches 100 or greater).
    //
    // Use a function for the player's turn. You should write a single function
    // and call it two times (once for each player's turn).
    
	do{
		int whosTurn = 1;
		int strat = 0;

		if(whosTurn==1)
			strat = player1_strat;
		else
			strat = player2_strat;
		if (whosTurn == 1)
			turn(whosTurn, strat, total_player1);
		else
			turn(whosTurn, strat, total_player2)
		
		if(whosTurn==1)
			whosTurn++;
		else
			whosTurn--;
	}while(total_player1 <= 100 && total_player2 <= 100);
    
    // End of your code block in the main function.
    // Move on to write the three functions below the main function.
    ////////////////////////////////

    // Print the results
    // NOTE - you need to write the printResults function
	



    if(total_player1 > total_player2)
    {
        printResults("Player 1", total_player1, "Player 2", total_player2);
    }
    else if(total_player2 > total_player1)
    {
        printResults("Player 2", total_player2, "Player 1", total_player1);
    }
    else
    {
        // This should never happen because we quit the loop if Player 1
        // wins and don't allow Player 2 to play their last turn.
        // But we'll put this in just for completeness.
        cout << "Draw! ";
        cout << "(Note: if this happens there is something wrong with the code)";
        cout << endl;
    }

	
	
    system("pause");
    return 0;

} // end of main function



//////////////////////////
// Write the following three functions




//
// Function that gets the player's stategy from user input.
// This function should get the strategy for a single player and return
// the "roll until" value.
// This function checks that the user entered an integer, and
// keeps prompting the user to enter an integer until an integer is entered.
//
int checkForInt(int num)
{
cin >> num;
if(!cin)
{
	cin.clear();
    cin.ignore(2000, '\n');
	cout << "A number Please : ";
	return -1;
}
else 
	return num;
}

//
// Function that simulates a single player's turn. This function should return
// the total of the rolls for the turn.
//

//////////////////////////////////////////////////////////////////////////////////////////////////////////
int turn(int player, int stop, int playertotal)
{
	int randomNum=0;
	int total = 0;

	cout<< "Player "<< player <<"'s rolls for this turn are: ";
	while (randomNum != 1 && )
	{
	randomNum = getRandomNum(1,6);
	total = total + randomNum;
	cout << randomNum << ", ";
	}
	if (randomNum == 1)
	{
		cout << endl << "Player1 rolled a " << randomNum << ",its turn is over.";
		total = 0;
	}
	playertotal = playertotal + total;
	cout << "Player " << player << " has completed its turn." << endl << "Player " << player << " received " << total << " points for the turn." << endl << "current score for Player " << player << " is: " << playertotal;

	/*
 Player 1's rolls for this turn are: 2 
 Player 1 rolled a 1, its turn is over. 

 Player 1 has completed its turn. 
 Player 1 received 0 points for the turn. 
 current score for Player 1 is: 0 
	*/
	return 0;
}
/////////////////////////////////////////////////////////////////////////////////////////////////////////

//
// Function that prints the results of the game. See the example program output
// to see how the end of game message should look. 
// This function is already called by the main program so you can look there to
// see what return type and parameters it needs.
//
void printResults(string p1, int t1, string p2, int t2)
{
cout << p1 << " " << t1 << " ---V--- " << t2 << " " << p2 << endl << p1 << " has won with a score of " << t1 << "!!" << endl;
}

//EXTRA
// Returns a random number in the range of the lowRange and
// highRange parameters (inclusive)
//
int getRandomNum(int lowRange, int highRange)
{
	int randNum;
	
	randNum =  ( rand() % (highRange - lowRange + 1) ) + lowRange;
	
	return randNum;
}

// End of your code for this program
//////////////////////////

