import java.util.ArrayList;
import java.util.List;

interface Observer
{
    void update(String stockName, double price);
}

interface Stock
{
    void registerObserver(Observer observer);

    void removeObserver(Observer observer);

    void notifyObservers();
}

class StockMarket implements Stock
{
    private List<Observer> observers = new ArrayList<>();
    private String stockName;
    private double price;

    public void setStock(String stockName, double price)
    {
        this.stockName = stockName;
        this.price = price;
        notifyObservers();
    }

    public void registerObserver(Observer observer)
    {
        observers.add(observer);
    }

    public void removeObserver(Observer observer)
    {
        observers.remove(observer);
    }

    public void notifyObservers()
    {
        for (Observer observer : observers)
        {
            observer.update(stockName, price);
        }
    }
}

class MobileApp implements Observer
{
    public void update(String stockName, double price)
    {
        System.out.println("Mobile App: " + stockName + " price updated to ₹" + price);
    }
}

class WebApp implements Observer
{
    public void update(String stockName, double price)
    {
        System.out.println("Web App: " + stockName + " price updated to ₹" + price);
    }
}

public class Main
{
    public static void main(String[] args)
    {
        StockMarket stockMarket = new StockMarket();

        Observer mobile = new MobileApp();
        Observer web = new WebApp();

        stockMarket.registerObserver(mobile);
        stockMarket.registerObserver(web);

        stockMarket.setStock("TCS", 4250.50);

        System.out.println();

        stockMarket.setStock("Infosys", 1685.75);
    }
}
