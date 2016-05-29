//Bryan Cancel 
//2-12-15 11:30 pm
//I think all this is right but because the h files and the cpp files sometimes say things that dont match I cant quite be sure. 
//Tried my best

#include"player.h"

player::player()
{
Name="Player";
Health=100;
Level=1;
DamageDone=0;
Blocking=false;
Taunt="Tu Es Estupet Computa Dora di Explora";
}

player::player(string name)
{
Name=name;
Health=100;
Level=1;
DamageDone=0;
Blocking=false;
Taunt="Tu Es Estupet";
}

//Takes an int that specifies the number of sides of the die, rolls and 
//  returns value of roll times the Level 
//  Every time the player does 10 damage they level up. 
//  If their Health is less than 10, add 5 to their attack 
int player::Attack(int NUM_SIDES)
{
	int at=(rand() % NUM_SIDES + 1)*Level;
	if(Health<10)
		at=at+5;
	DamageDone=DamageDone+at;
	Level=(DamageDone/10)+1;
	return at;
}

//Sets the level to input
void player::setHealth(int health)
{
	Health=health;
}

//Returns the players health
int player::getHealth()
{
	return Health;
}

//Returns the player's Level
int player::getLevel()
{
	return Level;
}

//Returns whether the player is alive or not (Health > 0)
bool player::isAlive()
{
	return (Health > 0);
}

//Subtracts the damage done, but first it rolls a die.  If they roll the max ON THE ATTACK DIE, -----------------------------         
//     value, then it is a critical hit and does double damage 
//    If blocking, the damage is halved, then blocking is turned off
void player::TakeDamage(int damage, int NUM_SIDES)
{
	int def = (rand() % NUM_SIDES + 1);
	
	if (damage%12 == 0)
		damage = damage * 2;
	
	damage = damage - def;


	if (Blocking == true)
	{
		damage = damage / 2;
		Blocking = false;
	}

	Health = Health - damage;
}

//Block only lasts for one hit (TakeDamage) at a time. 
//  If blocking, the attack die is 4 sided 
int player::Block(int NUM_SIDES)
{
	int bl=(rand() % NUM_SIDES + 1);
	Blocking = true;
	return bl;
}



//Returns their name
string player::getName()
{
	return Name;
}


//Returns a string to taunt the other player
string player::getTaunt()
{
	return Taunt;
}


//Sets the string to taunt the other player
void player::setTaunt(string word)
{
	Taunt=word;
}

