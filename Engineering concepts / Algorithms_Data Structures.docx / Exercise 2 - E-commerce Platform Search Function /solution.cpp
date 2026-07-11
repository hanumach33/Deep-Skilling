#include <iostream>
#include <algorithm>
using namespace std;

class Product
{
public:
    int productId;
    string productName;
    string category;
};

bool compare(Product a, Product b)
{
    return a.productId < b.productId;
}

int linearSearch(Product products[], int n, int key)
{
    for (int i = 0; i < n; i++)
    {
        if (products[i].productId == key)
            return i;
    }
    return -1;
}

int binarySearch(Product products[], int n, int key)
{
    int left = 0;
    int right = n - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (products[mid].productId == key)
            return mid;

        if (products[mid].productId < key)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return -1;
}

int main()
{
    Product products[] =
    {
        {105, "Laptop", "Electronics"},
        {101, "Mouse", "Electronics"},
        {104, "Chair", "Furniture"},
        {102, "Keyboard", "Electronics"},
        {103, "Table", "Furniture"}
    };

    int n = sizeof(products) / sizeof(products[0]);

    int key;

    cout << "Enter Product ID to Search: ";
    cin >> key;

    int index = linearSearch(products, n, key);

    if (index != -1)
    {
        cout << "\nLinear Search Result\n";
        cout << products[index].productId << " "
             << products[index].productName << " "
             << products[index].category << endl;
    }
    else
    {
        cout << "\nProduct Not Found using Linear Search\n";
    }

    sort(products, products + n, compare);

    index = binarySearch(products, n, key);

    if (index != -1)
    {
        cout << "\nBinary Search Result\n";
        cout << products[index].productId << " "
             << products[index].productName << " "
             << products[index].category << endl;
    }
    else
    {
        cout << "\nProduct Not Found using Binary Search\n";
    }

    return 0;
}
