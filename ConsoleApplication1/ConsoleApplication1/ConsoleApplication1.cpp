// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include<string>
using namespace std;

int main()
{
	// std::cout << "Hello World!\n";
	string firstName, lastName;
	int finalMarks, midterm, project, id;

	cout << "enter your ID:\n";
	cin >> id;
	cin.ignore();
	cout << "enter your firstname:\n";
	getline(cin, firstName);

	cout << "enter your lastname:" << endl;
	getline(cin, lastName);

	cout << "enter midterm marks:\n";
	cin >> midterm;
	
	cout << "enter project marks:\n";
	cin >> project;

	cout << "enter final marks:\n";
	cin >> finalMarks;

	finalMarks = (midterm*0.3 + finalMarks * 0.4 + project * 0.4);
	cout << "id   firstname  lastname  midterm  project  finalmarks " << endl;
	cout << "==\t=====\t=====\t  =====\t  =====\t  =====\t " << endl;
	cout << id << "\t" << firstName << "\t" << lastName << "\t" << midterm << "\t" << project << "\t" << finalMarks << endl;
	if (finalMarks < 60)
	{
		cout << "student fail";
	}
	else
	{ 
		cout << "student pass" << endl;
	}

	

    //cout << "Hello World!\n"; 
	system("pause");
	system("cls");

}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
