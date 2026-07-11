#include <iostream>
#include <string>

using namespace std;

class Task
{
public:
    int taskId;
    string taskName;
    string status;
    Task* next;

    Task(int id, string name, string s)
    {
        taskId = id;
        taskName = name;
        status = s;
        next = NULL;
    }
};

Task* head = NULL;

void addTask()
{
    int id;
    string name, status;

    cout << "Enter Task ID: ";
    cin >> id;

    cin.ignore();

    cout << "Enter Task Name: ";
    getline(cin, name);

    cout << "Enter Status: ";
    getline(cin, status);

    Task* newTask = new Task(id, name, status);

    if (head == NULL)
    {
        head = newTask;
    }
    else
    {
        Task* temp = head;

        while (temp->next != NULL)
        {
            temp = temp->next;
        }

        temp->next = newTask;
    }

    cout << "Task Added Successfully\n";
}

void searchTask()
{
    int id;

    cout << "Enter Task ID: ";
    cin >> id;

    Task* temp = head;

    while (temp != NULL)
    {
        if (temp->taskId == id)
        {
            cout << "\nTask Found\n";
            cout << "Task ID : " << temp->taskId << endl;
            cout << "Task Name : " << temp->taskName << endl;
            cout << "Status : " << temp->status << endl;
            return;
        }

        temp = temp->next;
    }

    cout << "Task Not Found\n";
}

void displayTasks()
{
    if (head == NULL)
    {
        cout << "No Tasks Available\n";
        return;
    }

    Task* temp = head;

    cout << "\nTask List\n\n";

    while (temp != NULL)
    {
        cout << "Task ID : " << temp->taskId << endl;
        cout << "Task Name : " << temp->taskName << endl;
        cout << "Status : " << temp->status << endl;
        cout << "---------------------------\n";

        temp = temp->next;
    }
}

void deleteTask()
{
    int id;

    cout << "Enter Task ID: ";
    cin >> id;

    if (head == NULL)
    {
        cout << "Task List is Empty\n";
        return;
    }

    if (head->taskId == id)
    {
        Task* temp = head;
        head = head->next;
        delete temp;

        cout << "Task Deleted Successfully\n";
        return;
    }

    Task* current = head;
    Task* previous = NULL;

    while (current != NULL && current->taskId != id)
    {
        previous = current;
        current = current->next;
    }

    if (current == NULL)
    {
        cout << "Task Not Found\n";
        return;
    }

    previous->next = current->next;
    delete current;

    cout << "Task Deleted Successfully\n";
}

int main()
{
    int choice;

    do
    {
        cout << "\nTask Management System\n";
        cout << "1. Add Task\n";
        cout << "2. Search Task\n";
        cout << "3. Display Tasks\n";
        cout << "4. Delete Task\n";
        cout << "5. Exit\n";
        cout << "Enter Choice: ";
        cin >> choice;

        switch (choice)
        {
            case 1:
                addTask();
                break;

            case 2:
                searchTask();
                break;

            case 3:
                displayTasks();
                break;

            case 4:
                deleteTask();
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
