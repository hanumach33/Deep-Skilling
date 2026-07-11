#include <iostream>
#include <unordered_map>
#include <string>

using namespace std;

class Product
{
public:
    int productId;
    string productName;
    int quantity;
    double price;

    Product()
    {
    }

    Product(int id, string name, int qty, double p)
    {
        productId = id;
        productName = name;
        quantity = qty;
        price = p;
    }
};

unordered_map<int, Product> inventory;

void addProduct()
{
    int id, qty;
    string name;
    double price;

    cout << "Enter Product ID: ";
    cin >> id;

    cout << "Enter Product Name: ";
    cin.ignore();
    getline(cin, name);

    cout << "Enter Quantity: ";
    cin >> qty;

    cout << "Enter Price: ";
    cin >> price;

    inventory[id] = Product(id, name, qty, price);

    cout << "Product Added Successfully.\n";
}

void updateProduct()
{
    int id;

    cout << "Enter Product ID: ";
    cin >> id;

    if (inventory.find(id) != inventory.end())
    {
        cout << "Enter New Product Name: ";
        cin.ignore();
        getline(cin, inventory[id].productName);

        cout << "Enter New Quantity: ";
        cin >> inventory[id].quantity;

        cout << "Enter New Price: ";
        cin >> inventory[id].price;

        cout << "Product Updated Successfully.\n";
    }
    else
    {
        cout << "Product Not Found.\n";
    }
}

void deleteProduct()
{
    int id;

    cout << "Enter Product ID: ";
    cin >> id;

    if (inventory.erase(id))
    {
        cout << "Product Deleted Successfully.\n";
    }
    else
    {
        cout << "Product Not Found.\n";
    }
}

void displayProducts()
{
    if (inventory.empty())
    {
        cout << "Inventory is Empty.\n";
        return;
    }

    cout << "\nInventory\n\n";

    for (auto &item : inventory)
    {
        Product p = item.second;

        cout << "ID: " << p.productId << endl;
        cout << "Name: " << p.productName << endl;
        cout << "Quantity: " << p.quantity << endl;
        cout << "Price: " << p.price << endl;
        cout << "-----------------------------\n";
    }
}

int main()
{
    int choice;

    do
    {
        cout << "\nInventory Management System\n";
        cout << "1. Add Product\n";
        cout << "2. Update Product\n";
        cout << "3. Delete Product\n";
        cout << "4. Display Products\n";
        cout << "5. Exit\n";
        cout << "Enter Choice: ";
        cin >> choice;

        switch (choice)
        {
        case 1:
            addProduct();
            break;

        case 2:
            updateProduct();
            break;

        case 3:
            deleteProduct();
            break;

        case 4:
            displayProducts();
            break;

        case 5:
            cout << "Thank You.\n";
            break;

        default:
            cout << "Invalid Choice.\n";
        }

    } while (choice != 5);

    return 0;
}
