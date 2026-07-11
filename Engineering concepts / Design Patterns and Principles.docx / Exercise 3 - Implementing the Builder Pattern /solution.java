class Computer
{
    private String cpu;
    private String ram;
    private String storage;

    private Computer(Builder builder)
    {
        this.cpu = builder.cpu;
        this.ram = builder.ram;
        this.storage = builder.storage;
    }

    public void display()
    {
        System.out.println("CPU : " + cpu);
        System.out.println("RAM : " + ram);
        System.out.println("Storage : " + storage);
        System.out.println();
    }

    static class Builder
    {
        private String cpu;
        private String ram;
        private String storage;

        public Builder setCPU(String cpu)
        {
            this.cpu = cpu;
            return this;
        }

        public Builder setRAM(String ram)
        {
            this.ram = ram;
            return this;
        }

        public Builder setStorage(String storage)
        {
            this.storage = storage;
            return this;
        }

        public Computer build()
        {
            return new Computer(this);
        }
    }
}

public class Main
{
    public static void main(String[] args)
    {
        Computer gamingComputer = new Computer.Builder()
                .setCPU("Intel Core i9")
                .setRAM("32 GB")
                .setStorage("1 TB SSD")
                .build();

        Computer officeComputer = new Computer.Builder()
                .setCPU("Intel Core i5")
                .setRAM("16 GB")
                .setStorage("512 GB SSD")
                .build();

        System.out.println("Gaming Computer");
        gamingComputer.display();

        System.out.println("Office Computer");
        officeComputer.display();
    }
}
