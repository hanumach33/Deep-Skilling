#include <iostream>
#include <string>

using namespace std;

class Employee
{
public:
    int employeeId;
    string name;
    string position;
    double salary;
};

Employee employees[100];
int countEmployee = 0;

void addEmployee()
{
    if (countEmployee == 100)
    {
        cout << "Employee Array is Full\n";
        return;
    }

    cout << "Enter Employee ID: ";
    cin >> employees[countEmployee].employeeId;

    cin.ignore();

    cout << "Enter Employee Name: ";
    getline(cin, employees[countEmployee].name);

    cout << "Enter Position: ";
    getline(cin, employees[countEmployee].position);

    cout << "Enter Salary: ";
    cin >> employees[countEmployee].salary;

    countEmployee++;

    cout << "Employee Added Successfully\n";
}

void searchEmployee()
{
    int id;

    cout << "Enter Employee ID: ";
    cin >> id;

    for (int i = 0; i < countEmployee; i++)
    {
        if (employees[i].employeeId == id)
        {
            cout << "\nEmployee Found\n";
            cout << "ID : " << employees[i].employeeId << endl;
            cout << "Name : " << employees[i].name << endl;
            cout << "Position : " << employees[i].position << endl;
            cout << "Salary : " << employees[i].salary << endl;
            return;
        }
    }

    cout << "Employee Not Found\n";
}

void traverseEmployees()
{
    if (countEmployee == 0)
    {
        cout << "No Employee Records\n";
        return;
    }

    cout << "\nEmployee List\n\n";

    for (int i = 0; i < countEmployee; i++)
    {
        cout << "ID : " << employees[i].employeeId << endl;
        cout << "Name : " << employees[i].name << endl;
        cout << "Position : " << employees[i].position << endl;
        cout << "Salary : " << employees[i].salary << endl;
        cout << "-----------------------------\n";
    }
}

void deleteEmployee()
{
    int id;

    cout << "Enter Employee ID: ";
    cin >> id;

    for (int i = 0; i < countEmployee; i++)
    {
        if (employees[i].employeeId == id)
        {
            for (int j = i; j < countEmployee - 1; j++)
            {
                employees[j] = employees[j + 1];
            }

            countEmployee--;

            cout << "Employee Deleted Successfully\n";
            return;
        }
    }

    cout << "Employee Not Found\n";
}

int main()
{
    int choice;

    do
    {
        cout << "\nEmployee Management System\n";
        cout << "1. Add Employee\n";
        cout << "2. Search Employee\n";
        cout << "3. Display Employees\n";
        cout << "4. Delete Employee\n";
        cout << "5. Exit\n";
        cout << "Enter Choice: ";
        cin >> choice;

        switch (choice)
        {
            case 1:
                addEmployee();
                break;

            case 2:
                searchEmployee();
                break;

            case 3:
                traverseEmployees();
                break;

            case 4:
                deleteEmployee();
                break;

            case 5:
                cout << "Thank You\n";
                break;

            default:
                cout << "Invalid Choice\n";
        }

    } while (choice != 5);

    return 0;
}
