// structure.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
# include <string>
using namespace std;

//struct Person // Name should start with capital
//{
//	int id;
//	char name[100];
//	float salary;
//};
//int main()
//{
//	Person p1;
//	
//	cout << "please enter the name \n";
//	cin.getline(p1.name, 100);
//	cout << "please salary \n";
//	cin >> p1.salary;
//	cout << "please enter the id \n";
//	cin >> p1.id;
//
//	cout << "\nDisplaying Information." << endl;
//	cout << "id: " << p1.id << endl;
//	cout << "Name: " << p1.name << endl;
//	cout << "salary: " << p1.salary ;
//
//	system("pause");
//	system("cls");
//
//}

//program to save information of book and display information inside a function named displaydata.
//struct Information
//{
//	char name[100];
//	char author[100];
//	int id;
//};
//
//void displaydata(Information);
//int  main()
//{
//	Information ob1;
//
//	cout << "please enter the name \n";
//	cin.getline(ob1.name, 100);
//	cout << "please author \n";
//	cin.getline(ob1.author, 100);
//	cout << "please enter the id \n";
//	cin >> ob1.id;
//	displaydata(ob1);
//	return 0;
//}
//	void displaydata(Information ob1)
//	{
//	cout << "\nDisplaying Information." << endl;
//	cout << "id: " << ob1.id << endl;
//	cout << "Name: " << ob1.name << endl;
//	cout << "author: " << ob1.author<<endl;
//
//	system("pause");
//	system("cls");
//
//}
struct Information
{
	char name[100];
	char author[100];
	int id;
};
Information getdata()
{
	
	Information ob1;


	cout << "please enter the name \n";
	cin.getline(ob1.name, 100);
	cout << "please author \n";
	cin.getline(ob1.author, 100);
	cout << "please enter the id \n";
	cin >> ob1.id;

	return ob1;
}
	void displaydata(Information ob1)
	{
	cout << "\nDisplaying Information." << endl;
	cout << "id: " << ob1.id << endl;
	cout << "Name: " << ob1.name << endl;
	cout << "author: " << ob1.author<<endl;

	
}

	int main()
	{
		Information ob1=getdata(); // getdata do not have any parameter
		displaydata(ob1);


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
