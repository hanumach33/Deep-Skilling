#include <iostream>

using namespace std;

double futureValue(double amount, double rate, int years)
{
    if (years == 0)
    {
        return amount;
    }

    return futureValue(amount * (1 + rate / 100.0), rate, years - 1);
}

int main()
{
    double amount;
    double rate;
    int years;

    cout << "Enter Initial Investment: ";
    cin >> amount;

    cout << "Enter Annual Growth Rate (%): ";
    cin >> rate;

    cout << "Enter Number of Years: ";
    cin >> years;

    double result = futureValue(amount, rate, years);

    cout << "\nFuture Value after "
         << years
         << " years = "
         << result
         << endl;

    return 0;
}
