class Logger
{
    private static Logger instance;

    private Logger()
    {
    }

    public static Logger getInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }

        return instance;
    }

    public void log(String message)
    {
        System.out.println("Log : " + message);
    }
}

public class Main
{
    public static void main(String[] args)
    {
        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();

        logger1.log("Application Started");
        logger2.log("Loading Modules");

        if (logger1 == logger2)
        {
            System.out.println("Only one Logger instance exists.");
        }
        else
        {
            System.out.println("Multiple Logger instances exist.");
        }
    }
}
