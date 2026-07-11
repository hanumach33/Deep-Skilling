interface PaymentProcessor
{
    void processPayment(double amount);
}

class PayPalGateway
{
    public void makePayment(double amount)
    {
        System.out.println("Payment of ₹" + amount + " processed through PayPal.");
    }
}

class StripeGateway
{
    public void pay(double amount)
    {
        System.out.println("Payment of ₹" + amount + " processed through Stripe.");
    }
}

class PayPalAdapter implements PaymentProcessor
{
    private PayPalGateway gateway;

    public PayPalAdapter()
    {
        gateway = new PayPalGateway();
    }

    public void processPayment(double amount)
    {
        gateway.makePayment(amount);
    }
}

class StripeAdapter implements PaymentProcessor
{
    private StripeGateway gateway;

    public StripeAdapter()
    {
        gateway = new StripeGateway();
    }

    public void processPayment(double amount)
    {
        gateway.pay(amount);
    }
}

public class Main
{
    public static void main(String[] args)
    {
        PaymentProcessor paypal = new PayPalAdapter();
        PaymentProcessor stripe = new StripeAdapter();

        paypal.processPayment(2500);
        stripe.processPayment(5000);
    }
}
