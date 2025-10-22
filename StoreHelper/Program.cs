using StoreHelper;

internal class Program
{
    private static void Main(string[] args)
    {
        Product coffe = new Product("кафе", 10);
        coffe.PrintInfo();
        coffe.PrintMessage();


        Product tea = new Product("чай", 5);
        tea.PrintInfo(); 
        tea.PrintMessage();
    }
}