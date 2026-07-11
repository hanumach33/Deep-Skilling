interface CustomerRepository
{
    String findCustomerById(int id);
}

class CustomerRepositoryImpl implements CustomerRepository
{
    public String findCustomerById(int id)
    {
        if (id == 101)
        {
            return "Rahul";
        }
        else if (id == 102)
        {
            return "Kiran";
        }
        else if (id == 103)
        {
            return "Sneha";
        }

        return "Customer Not Found";
    }
}

class CustomerService
{
    private CustomerRepository repository;

    public CustomerService(CustomerRepository repository)
    {
        this.repository = repository;
    }

    public void getCustomer(int id)
    {
        System.out.println(repository.findCustomerById(id));
    }
}

public class Main
{
    public static void main(String[] args)
    {
        CustomerRepository repository = new CustomerRepositoryImpl();

        CustomerService service = new CustomerService(repository);

        service.getCustomer(101);
        service.getCustomer(102);
        service.getCustomer(200);
    }
}
