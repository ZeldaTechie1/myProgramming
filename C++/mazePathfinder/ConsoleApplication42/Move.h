class Move{public:	Move();	Move(int r, int c);private:	int row, col;};

Move::Move(int r, int c)
{
	row = r;
	col = c;
}