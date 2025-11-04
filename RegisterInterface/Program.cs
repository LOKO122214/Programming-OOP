using RegisterInterface;
internal class Program
{
    private static void Main(string[] args)
    {
       string username = Console.ReadLine();
 string password = Console.ReadLine(); 
string email = Console.ReadLine(); 


Register first = new Register(username, password, email );
        first.PrintData();
    }
}