namespace AbstractFactory
{
    public interface ILaptop
    {
        public void GetLaptop();
    }

    public interface INetbook
    {
        public void GetNetbook();
    }

    public interface ISmartphone
    {
        public void GetSmartphone();
    }

    public class ArasakaLaptop : ILaptop
    {
        public void GetLaptop() 
        {
            Console.WriteLine("This is new Arasaka Laptop");
        }
    }
    public class ArasakaNetbook : INetbook
    {
        public void GetNetbook()
        {
            Console.WriteLine("This is new Arasaka Netbook");
        }
    }
    public class ArasakaSmartphone : ISmartphone
    {
        public void GetSmartphone()
        {
            Console.WriteLine("This is new Arasaka Smartphone");
        }
    }

    public class SasungLaptop : ILaptop
    {
        public void GetLaptop()
        {
            Console.WriteLine("This is new Sasung Laptop");
        }
    }
    public class SasungNetbook : INetbook
    {
        public void GetNetbook()
        {
            Console.WriteLine("This is new Sasung Netbook");
        }
    }
    public class SasungSmartphone : ISmartphone
    {
        public void GetSmartphone()
        {
            Console.WriteLine("This is new Sasung Smartphone");
        }
    }
}
