/////////////////////////////////////////////////////////////////////

// 

// Name: Bryan Cancel

// Date: 11/3/14

// Class: CSCI 1370.01

// Semester: Fall 2014

// CSCI/CMPE 1370 Instructor: Tim Wylie

//

// This program simulates a tic-tac-toe game. is uses a 2d array to 

// store the values of 'X' or 'O' and displays them on a board in

// the console screen. every turn the program checks for a winner. if 

// there is no winner, the game is tied. the program terminates after 

// one match whether there is a winner or the game is tied.

//

/////////////////////////////////////////////////////////////////////




#include<iostream>

#include<iomanip>




using namespace std;




void drawBoard(char board[][3]);

char checkWinner3by3(char board[][3]);




//

// The main funciton is provided for you.

//

// DO NOT MODIFY THE MAIN FUNCTION

//

int main()

{

	// This array of chars represents the game board, and it holds the content

	// of each space. By default all spaces are set to a blank space.

	char board[3][3] = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };



	// The current player. Because X plays first, initialize to X

	char player = 'X';



	// The winner. either 'X', 'O', or 't' if it's a tie.

	// Or a blank space if the game has not finished.

	char winner = ' ';



	// These variables will hold the number of the row and column selected

	// by the players.

	int row;

	int column;



	// boolean variables used to verify if the move is valid.

	bool is_move;

	bool is_row;

	bool is_column;




	cout << "************ TIC TAC TOE ************\n";




	// The game loops again and again until the game is over

	while (winner == ' ')

	{

		//set the boolean variables back to false for a new turn.

		is_move = false;

		is_row = false;

		is_column = false;



		//draw the board.

		drawBoard(board);



		// If the game is not yet over show who`s the next player to move

		cout << "Player ";

		if (player == 'X')

		{

			cout << 1;

		}

		else

		{

			cout << 2;

		}

		cout << "'s turn:" << endl;




		// Loop until the player selects a valid space for their move

		is_move = false;

		while (!is_move)

		{

			// Loop until the player selects a valid row

			// Assume the user inputs a valid integer

			is_row = false;

			while (!is_row)

			{

				cout << "Row: ";

				cin >> row;

				if (row == 1 || row == 2 || row == 3)

				{

					is_row = true;

				}

				else

				{

					cout << endl << "Invalid row!" << endl;

				}

			} // end of input row loop



			// Loop until the player selects a valid column

			// Assume the user inputs a valid integer

			is_column = false;

			while (!is_column)

			{

				cout << "Column: ";

				cin >> column;

				if (column == 1 || column == 2 || column == 3)

				{

					is_column = true;

				}

				else

				{

					cout << endl << "Invalid column!" << endl;

				}

			} // end of input column loop



			// If the space is empty, mark the chosen space and swich players

			if (board[row - 1][column - 1] == ' ')

			{

				// Mark the space and end the player's turn

				board[row - 1][column - 1] = player;

				is_move = true;



				// Switch to the other player

				if (player == 'X')

				{

					player = 'O';

				}

				else

				{

					player = 'X';

				}

			} // end of marking space and changing players



			// If the space is occupied

			else

			{

				cout << "The selected space is occupied!" << endl;

				cout << "Select a different space:" << endl << endl;

				drawBoard(board);

			}

		} // end of player's move loop



		cout << endl; // for nice output formatting



		//check if the player won.

		winner = checkWinner3by3(board);



		//If there's a winner

		if (winner == 'X' || winner == 'O')

		{

			drawBoard(board);



			//Display congratulations message

			cout << "Congratulations! Player ";

			if (winner == 'X')

			{

				cout << 1;

			}

			else

			{

				cout << 2;

			}

			cout << " is the winner!" << endl;

		}

		else if (winner == 'T')

		{

			drawBoard(board);



			//Display a message if it`s tie

			cout << "It's a tie!" << endl;

		}



	} // End of player's turn loop




	system("pause");

	return 0;

}

//

// Prints the game board

// We know the board is 3 by 3 so we don't need to have the number of rows as

// a parameter.

//

// WRITE THIS FUNCTION

//

void drawBoard(char board[][3])
{
	//Draw the top line of the board
	cout << " " << setw(4) << "1" << setw(4) << "2" << setw(4) << "3" << endl;
	// Draw a row of the board and a line under the row
	for (int r = 0; r<3; r++)
	{
		cout << setw(15) << "+---+---+---+" << endl << (r + 1) << " |";
		for (int c = 0; c<3; c++)
		{
			cout << setw(3) << board[r][c] << "|";
		}
		cout << endl;
	}
	cout << setw(15) << "+---+---+---+" << endl;
}

//

// Checks the whole board if there is a winner.

// We know the board is 3 by 3 so we don't need to have the number of rows as

// a parameter.

//

// WRITE THIS FUNCTION

//
char checkWinner3by3(char board[][3])
{
	// Check all rows
	for (int r = 0; r < 3; r++)
	{
		if (board[r][0] == board[r][1] && board[r][1] == board[r][2] && board[r][0]!=' ')
		{
			return board[r][0];
		}
	}
	// Check all columns
	for (int c = 0; c < 3; c++)
	{
		if (board[0][c] == board[1][c] && board[1][c] == board[2][c] && board[0][c]!=' ')
		{
			return board[0][c];
		}
	}
	// Check diagional from upper left to lower right
	if (board[0][0] == board[1][1] && board[1][1] == board[2][2] && board[1][1]!=' ')
	{
		return board[0][0];
	}
	// Check diagonal from upper right to lower left
	if (board[0][2] == board[1][1] && board[1][1] == board[2][0] && board[1][1] != ' ')
	{\
		return board[0][2];
	}
	// Otherwise, if all spaces are filled, the game is a tie
	int total = 0;
	for (int r = 0; r < 3; r++)
	{
		for (int c = 0; c < 3; c++)
		{
			if (board[r][c] != ' ')
			{
				total++;
			}
		}
	}
	if (total == 9)
	{
		return 'T';
	}
	/*
	if(board[0][0]!=' '&& board[0][1]!=' '&& board[0][2]!=' '&& board[1][0]!=' '&& board[1][1]!=' '&& board[1][2]!=' '&& board[2][0]!=' '&& board[2][1]!=' '&& board[2][2]!=' ')
	{
	return 't';
	}
	*/
	// If none of the conditions above are true, return a blank space
	return ' ';
}