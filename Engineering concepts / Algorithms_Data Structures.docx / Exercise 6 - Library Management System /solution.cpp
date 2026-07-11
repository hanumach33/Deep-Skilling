#include <iostream>
#include <algorithm>
#include <string>

using namespace std;

class Book
{
public:
    int bookId;
    string title;
    string author;
};

bool compare(Book a, Book b)
{
    return a.title < b.title;
}

int linearSearch(Book books[], int n, string key)
{
    for (int i = 0; i < n; i++)
    {
        if (books[i].title == key)
        {
            return i;
        }
    }

    return -1;
}

int binarySearch(Book books[], int n, string key)
{
    int left = 0;
    int right = n - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (books[mid].title == key)
        {
            return mid;
        }

        if (books[mid].title < key)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return -1;
}

int main()
{
    Book books[] =
    {
        {101, "Operating Systems", "Galvin"},
        {102, "Data Structures", "Narasimha Karumanchi"},
        {103, "Database Systems", "Korth"},
        {104, "Computer Networks", "Forouzan"},
        {105, "Algorithms", "Cormen"}
    };

    int n = sizeof(books) / sizeof(books[0]);

    string title;

    cout << "Enter Book Title: ";
    getline(cin, title);

    int index = linearSearch(books, n, title);

    if (index != -1)
    {
        cout << "\nLinear Search Result\n";
        cout << "Book ID : " << books[index].bookId << endl;
        cout << "Title : " << books[index].title << endl;
        cout << "Author : " << books[index].author << endl;
    }
    else
    {
        cout << "\nBook Not Found using Linear Search\n";
    }

    sort(books, books + n, compare);

    index = binarySearch(books, n, title);

    if (index != -1)
    {
        cout << "\nBinary Search Result\n";
        cout << "Book ID : " << books[index].bookId << endl;
        cout << "Title : " << books[index].title << endl;
        cout << "Author : " << books[index].author << endl;
    }
    else
    {
        cout << "\nBook Not Found using Binary Search\n";
    }

    return 0;
}
