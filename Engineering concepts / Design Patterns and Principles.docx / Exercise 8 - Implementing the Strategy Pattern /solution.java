interface PaymentStrategy
{
    void pay(double amount);
}

class CreditCardPayment implements PaymentStrategy
{
    public void pay(double amount)
    {
        System.out.println("Paid ₹" + amount + " using Credit Card.");
    }
}

class PayPalPayment implements PaymentStrategy
{
    public void pay(double amount)
    {
        System.out.println("Paid ₹" + amount + " using PayPal.");
    }
}

class PaymentContext
{
    private PaymentStrategy paymentStrategy;

    public void setPaymentStrategy(PaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void makePayment(double amount)
    {
        paymentStrategy.pay(amount);
    }
}

public class Main
{
    public static void main(String[] args)
    {
        PaymentContext paymentContext = new PaymentContext();

        paymentContext.setPaymentStrategy(new CreditCardPayment());
        paymentContext.makePayment(2500);

        paymentContext.setPaymentStrategy(new PayPalPayment());
        paymentContext.makePayment(5000);
    }
}
