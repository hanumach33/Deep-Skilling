#include <iostream>
using namespace std;

class Order
{
public:
    int orderId;
    string customerName;
    double totalPrice;
};

void display(Order orders[], int n)
{
    for (int i = 0; i < n; i++)
    {
        cout << orders[i].orderId << " "
             << orders[i].customerName << " "
             << orders[i].totalPrice << endl;
    }
}

void bubbleSort(Order orders[], int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (orders[j].totalPrice > orders[j + 1].totalPrice)
            {
                swap(orders[j], orders[j + 1]);
            }
        }
    }
}

int partition(Order orders[], int low, int high)
{
    double pivot = orders[high].totalPrice;

    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        if (orders[j].totalPrice < pivot)
        {
            i++;
            swap(orders[i], orders[j]);
        }
    }

    swap(orders[i + 1], orders[high]);

    return i + 1;
}

void quickSort(Order orders[], int low, int high)
{
    if (low < high)
    {
        int pivot = partition(orders, low, high);

        quickSort(orders, low, pivot - 1);
        quickSort(orders, pivot + 1, high);
    }
}

int main()
{
    Order orders1[] =
    {
        {101, "Rahul", 2500},
        {102, "Anjali", 1200},
        {103, "Kiran", 5600},
        {104, "Sneha", 3400},
        {105, "Vikram", 1800}
    };

    int n = sizeof(orders1) / sizeof(orders1[0]);

    Order orders2[5];

    for (int i = 0; i < n; i++)
    {
        orders2[i] = orders1[i];
    }

    bubbleSort(orders1, n);

    cout << "Bubble Sort Result\n\n";

    display(orders1, n);

    quickSort(orders2, 0, n - 1);

    cout << "\nQuick Sort Result\n\n";

    display(orders2, n);

    return 0;
}
