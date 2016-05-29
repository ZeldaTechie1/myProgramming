
template<class THING>
struct LLNode
{
	THING data;
	LLNode<THING> *next;
	LLNode<THING> *prev;
};

template<class THING>
class LinkedList
{
private:
	//use a doubly linked-list based implementation
	//keep a head and tail pointer for efficiency
	LLNode<THING> *Head;
	LLNode<THING> *Tail;
	int Count;
public:
	//THIS var is used in main as input of that thing
	THING input;

	//setup initial conditions
	LinkedList();
	//delete all dynamic memory, etc.
	~LinkedList();
	//constant bracket operator to access specific element
	const THING& operator[](int);
	//I didnt know what this did and it would give me errors so i took it out (shot me an email with the differences if it isnt too much trouble)
	/*
	//Bracket operator to access specific element
	THING& operator[](int);
	*/
	//Equality operator to check if two lists are equal
	bool operator==(const LinkedList<THING>&);
	//Inequality operator to check if two lists are equal
	bool operator!=(const LinkedList<THING>&);
	//add x to front of list
	void addFront(THING D);
	//add x to back of list
	void addBack(THING D);
	//add x as the ith thing in the list
	//if there are less than i things, add it to the back
	void add(THING D, int num);
	//remove and return front item from list
	THING removeFront();
	//remove and return back item from list
	THING removeBack();
	//return value of back item (but don't remove it)
	THING getBack();
	//return value of front item (but don't remove it)
	THING getFront();
	//return how many items are in the list
	int length();
	//print all elements in the linked list
	void print();

	//For Sort Bonus
	void sort();
};

//setup initial conditions
template<class THING>
LinkedList<THING>::LinkedList()
{
	//initiate counter of the items in the list and since now its empty set head and tail to null
	int Count = 0;
	Head = NULL;
	Tail = NULL;
}

//delete all dynamic memory, etc.
template<class THING>
LinkedList<THING>::~LinkedList()
{
	//start the temp at tail
	LLNode<THING>*temp = Tail;

	//loop through the linked list until we arrive at head
	while (temp->prev != NULL)
	{
		//move temp to the prev 
		temp = temp->prev;
		//delete the next one wich would be that linked list last value
		delete temp->next;
	}

	//delete head
	delete temp;
}

//OPERATORS START-----------------------------------------------------------------

//constant bracket operator to access specific element
template<class THING>
const THING& LinkedList<THING>::operator[](int index)
{
	//temporary pointer for loop
	LLNode<THING> *temp = Head;

	//loop through the thing and get to the location of index in the linked list
	for (int i = 0; i < index; i++)
	{
		temp = temp->next;
	}

	//return the value in that location
	return temp->data;
}

//I DONT KNOW WHAT THIS EXTRA OPERATOR OVERIDE WAS NEEDED FOR BUT IF I LEFT IT IT WOULDNT DEBUG, I HAVE NO IDEA WHY
/*
//Bracket operator to access specific element
template<class THING>
THING& LinkedList<THING>::operator[](int index)
{
	LLNode<THING>*temp = Head;

	for (int i = 0; i < index; i++)
	{
		temp = temp->next;
	}
	return temp->data;
}
*/

//Equality operator to check if two lists are equal
template<class THING>
bool LinkedList<THING>::operator==(const LinkedList<THING>& LList)
{
	//a variable with the result that will be returned at the end
	bool result = true;

	//if the list counts dont match they its impossible for them to be equal
	if (LList.Count != this->Count)
		result = false;
	else
	{
		//create temp var for that point to their perspective head in their perspective linked list
		LLNode<THING>*temp1 = this->Head;
		LLNode<THING>*temp2 = LList.Head;

		//loops through the list checking that all the values are equal
		for (int i = 0; i < LList.Count && result == true; i++)
		{
			//if any one set of values isnt equal then the whole list isnt equal
			if (temp1->data != temp2->data)
			{
				result = false;
			}	
			//moves to next location on each list
			temp1 = temp1->next;
			temp2 = temp2->next;
		}
	}

	//returns the result
	return result;
}

//Inequality operator to check if two lists are equal
template<class THING>
bool LinkedList<THING>::operator!=(const LinkedList<THING>& LList)
{
	//a var that will store the result
	bool result = true;
	int ChangeC = 0; //change counter

	//if both list count are not equal to each other then its true that they are Not equal
	if (LList.Count != this->Count)
		result = true;
	else
	{
		//create temp var that point to each perspective head in each perspective list
		LLNode<THING>*temp1 = this->Head;
		LLNode<THING>*temp2 = LList.Head;

		//loop through both of the whole lists
		for (int i = 0; i < LList.Count; i++)
		{
			//if the temp do equal each other result for that instance the result is false
			if (temp1->data == temp2->data)
			{
				//if the result was true and now its changing to false the value is changing, which is okay for the first time but no for more than one
				if (result == true)
					ChangeC++;
				result = false;
			}
			//if the temp dont equal each other that for that instance the result is true
			if (temp1->data != temp2->data)
			{
				//if the result was true and is now false the value is changing so add to change counter
				if (result == false)
					ChangeC++;
				result = true;
			}

			//move to next spot on each list
			temp1 = temp1->next;
			temp2 = temp2->next;	
		}
	}

	//if the value change more than one it means that atleast one value is different from the value on the other list that has the same location
	//this would indicate that its true that the A is Not equal to B
	if (ChangeC > 1)
		return true;
	else
		return false;
}

//OPERATORS END-----------------------------------------------------------------

//add x to front of list
template<class THING>
void LinkedList<THING>::addFront(THING D)
{
	//call add function att the first location
	add(D, 0);
}

//add x to back of list
template<class THING>
void LinkedList<THING>::addBack(THING D)
{
	//call add function at last location or count
	add(D, Count);
}

//add x as the ith thing in the list
//if there are less than i things, add it to the back
template<class THING>
void LinkedList<THING>::add(THING D, int num)
{
	//create a new node and assign its data
	LLNode<THING>*N = new LLNode<THING>;
	N->data = D;

	//if the list is empty
	if (Head == NULL)
	{
		Head = N;
		Tail = N;
		N->prev = NULL;
		N->next = NULL;
	}
	else
	{
		//if the value given is too big add what you go to the end
		if (num >= Count)
		{
			N->prev = Tail;
			Tail->next = N;
			Tail = N;
			Tail->next = NULL;
		}
		else//scan through the whole list until you find your value 
		{
			//if your adding to the front
			if (num==0)
			{
				N->next = Head;
				Head->prev = N;
				Head = N;
				Head->prev = NULL;
			}
			else
			{
				//create a temp var
				LLNode<THING>*temp = Head;
				//loop through the list until you arrive at the location of your index
				for (int i = 0; i < num; i++)
				{
					temp = temp->next;
				}
				
				//change the pointer to fit the new Node in the location we wanted it to be at
				N->prev = temp->prev;
				N->next = temp;
				LLNode<THING>*Prev = temp->prev;
				Prev->next = N;
				temp->prev = N;
			}
		}
	}

	//add to count since we did add a node to the list
	Count++;
}

//remove and return front item from list
template<class THING>
THING LinkedList<THING>::removeFront()
{
	//get the data from the front and save it in order to return it later
	THING var;
	var = Head->data;

	//as long as the var isnt empty which would mean the list is empty, do this
	if (var != NULL)
	{
		//if we are in the last Node in the linked 
		if (Head->next == NULL)
		{
			//delete the Head, set both of the to null and subtract from count since we did remove a node
			delete Head;
			Tail = NULL;
			Tail = Head;
			Count--;
		}
		else
		{
			//create a temp pointer to point the what would become head
			LLNode<THING>*Next = Head->next;
			//delete head and set head to next and subtract from the list counter 
			Next->prev = NULL;
			delete Head;
			Head = Next;
			Count--;
		}
	}

	//if its empty it return null and if its not it return the value
	return var;
}

//remove and return back item from list
template<class THING>
THING LinkedList<THING>::removeBack()
{
	//create a var to store the value on the tail so we can return it later
	THING var;
	var = Tail->data;

	//if the list isnt empty do this
	if (var != NULL)
	{
		//if the list is now empty
		if (Tail->prev == NULL)
		{
			//delete tail, set tail and head to null and subtract from the counter
			delete Tail;
			Tail = NULL;
			Head = Tail;
			Count--;
		}
		else
		{
			//create a temp var to point to the value that will become tail
			LLNode<THING>*Prev = Tail->prev;
			//delete the Tail pointer and shit it the the temp var and subtract from the counter
			Prev->next = NULL;
			delete Tail;
			Tail = Prev;
			Count--;
		}
	}

	//return null if empty return the var
	return var;
}

//return value of back item (but don't remove it)
template<class THING>
THING LinkedList<THING>::getBack()
{
	return Tail->data;
}

//return value of front item (but don't remove it)
template<class THING>
THING LinkedList<THING>::getFront()
{
	return Head->data;
}

//return how many items are in the list
template<class THING>
int LinkedList<THING>::length()
{
	return Count;
}

//print all elements in the linked list
template<class THING>
void LinkedList<THING>::print()
{
	//create a temp for the loops
	LLNode<THING>*temp = Head;

	//if the list isnt empty then do this
	if (temp != NULL)
	{
		//loop through it printing every value
		while (temp->next != NULL)
		{
			cout << temp->data << ", ";
			temp = temp->next;
		}
		//print the last value
		cout << temp->data << endl;
	}
	else // if the list is empty let the user know
		cout << "The List Is EMPTY" << endl;
}

//--------------------------OVERLOAD << BONUS(10 points)--------------------------
/*
template<class THING>
vooid LinkedList<THING>::ostream& operator<<(ostream& os)
{
	print();
}
*/


//--------------------------SORT BONUS(50 points)--------------------------


template <class THING>
void LinkedList<THING>::sort()
{
	//a pointer that points to the location that has the smallest value
	LLNode<THING>* low = Head;
	//set the range in where you will start comparing values
	int range=0;

	//loop as many time as it take for the range to equal count to make sure all the numbers are sorted
	for (range; range < Count; range++)
	{
		LLNode<THING>* temp = Head;
		//loop through whole list because even though your range changes this is a linkedlist and you need to start at head
		for (int i = 0; i < Count; i++)
		{
			//if i is within range begin comparing the lowest values
			if (i >= range)
				if (temp->data <= low->data)
					low = temp;
			temp = temp->next;

		}
		//if the lowest number is the Head
		if (&Head != &low)
		{
			if (&Tail == &low)
			{
				LLNode<THING>*Prev1 = low->prev;
				Prev1->next = NULL;
				Tail = Prev1;
			}
			else
			{
				LLNode<THING>*Next1 = low->next;
				LLNode<THING>*Prev1 = low->prev;
				Prev1->next = Next1;
				Next1->prev = Prev1;
			}
			Head->prev = low;
			low->next = Head;
			low->prev = NULL;
			Head = low;
		}	
	}
}

