#include "pch.h"
#include <iostream>
#include <string>
using namespace std;

struct Employee
{
	int id;
	char name[20];
	char country[20];
};

int main()
{
	int number;
	cout << "how many employee you want to enter";
	cin >> number;
	Employee emp[100];
	int i;
	char ch;
	//getting information from user
	for (i = 0; i < number; i++)
	{
		cout << "Employee No: ";
		cin >> emp[i].id;
		cin.ignore();
		cout << "Employee Name: ";
		cin.getline(emp[i].name, 20);
		cout << " Employee Country: ";
		cin.getline(emp[i].country, 20);

		cout << "\n";
	}

	system("cls");

	do
	{
		cout << "Enter employee no. whose information is to be displayed:\n";
		int eno;
		cin >> eno;
		bool flag = false;
		for (i = 0; i < number; i++)
		{
			if (emp[i].id == eno)
			{
				flag = true;
				cout << "\nEmployee Data:\n";
				cout << "Employee No: " << emp[i].id;
				cout << "\nName: " << emp[i].name;
				cout << "Country: " << emp[i].country;
				cout << "\n";
				break;
			}
		}
		if (flag == false)
		{
			cout << "\nSorry..!!..No such employee exists..!!\n";
			cout << "Exiting.....Press a key...\n";
			//getch();
			exit(1);
		}
		cout << "Want to search  more ? (y/n).. ";
		cin >> ch;
	} while (ch == 'y' || ch == 'Y');
}

