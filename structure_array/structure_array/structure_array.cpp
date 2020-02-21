// structure_array.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <string>
using namespace std;

//struct employee
//{
//	char name[100];
//	float salary;
//	int id;
//};
//int main()
//{
//	employee emp[2];
//	for (int i = 0; i < 2; i++)
//	{
//		cout << "employee" << i + 1;
//		cout << "id";
//		cin >> emp[i].id;
//		cout << "salary";
//		cin >> emp[i].salary;
//		cout << "name";
//		cin >> emp[i].name;
//	}
//	cout << "Displaying the information" << endl;
//	cout << "-------------------";
//
//	for (int i =0; i<2 ; i++)
//	{
//		cout << "employee : " << i + 1 <<endl;
//		cout << "id";
//		cout << emp[i].id << endl;
//		cout << "salary :";
//		cout <<emp[i].salary << endl;
//		cout << "name  :";
//		cout << emp[i].name <<endl;
//		cout << "-------------------";
// system ("pause");
// system ("cls");
//	}
//}

//struct student
//{
//	char name[100];
//	int phone;
//	int id;
//};
//student getdata()
//{
//	student s;
//	for (int i = 0; i < 3; i++)
//	{
//		cout << "please enter the name \n";
//		cin.getline(s.name, 100);
//		cout << "please phone number \n";
//		cin >> s.phone;
//		cout << "please enter the id \n";
//		cin >> s.id;
//	}
//		return s;
//	
//}
//void displaydata(student s)
//{
//	for (int i = 0; i < 3; i++)
//	{
//		cout << "\nDisplaying Information." << endl;
//		cout << "student : " << i + 1 << endl;
//		cout << "id: " << s.id << endl;
//		cout << "Name: " << s.name << endl;
//		cout << "phone: " << s.phone << endl;
//
//	}
//}
//int main()
//{
//	student s = getdata(); // getdata do not have any parameter
//	displaydata(s);
//
//
//	system("pause");
//	system("cls");
//
//}



struct student    //Defining structure
{
	char sname[20];
	int rollno;
	float fee;
};
int main()
{
	struct student st;  //Declare st of type student
	cout << "\n Enter Student Details " << " ";
	cout << "\n ---------------------------------\n";
	for (int i = 0; i < 3; i++)
	{
		cout << " Student Name : "<<endl ;
		cin.getline(st.sname, 20) ;
		//Accessing member of structure using member access operator (.)
		cout << " Roll Number : ";
		cin >> st.rollno;
		cout << " Student Fee : ";
		cin >> st.fee;
	}
	
		cout << "\n\n Student Details\n" << " ";
		cout << "---------------------------------";
		for (int i = 0; i < 3; i++)
		{
		cout << "\n Student Name : " << st.sname <<endl;
		cout << "\n Roll Number : " << st.rollno<<endl;
		cout << "\n Student Fee : " << st.fee <<endl;
	}
	return 0;
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
