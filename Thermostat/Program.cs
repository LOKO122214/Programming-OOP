using Thermostat;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, SmartHomeThermostat> devices = new Dictionary<string, SmartHomeThermostat>();
        Console.Write("How many devices you want to add:");
        byte count = byte.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++) 
        {
            Console.Write("Enter room:");
            string roomName = Console.ReadLine();
            Console.Write("Enter current temperature:");
            double currentTemperature = double.Parse(Console.ReadLine());
            Console.Write("Enter target temperature:");
            double targetTemperature = double.Parse(Console.ReadLine());
            devices[roomName] = new SmartHomeThermostat(roomName, currentTemperature, targetTemperature);
        }
        Console.Clear();
        
        
        SmartHomeThermostat.devicescount();
        Metods(devices);

        
    }

    private static void Metods(Dictionary<string, SmartHomeThermostat> devices)
    {
        Console.WriteLine("1.Room List");
        Console.WriteLine("2.Status");
        Console.WriteLine("3.Heating time");
        Console.Write("Which Metod you want to use:");
        byte choose = byte.Parse(Console.ReadLine());


        if (choose != 1 && choose != 2&& choose !=3)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {

            switch (choose)
            {
                case 1:
                    foreach (var item in devices)
                    {
                        Console.WriteLine(item.Key);
                    }
                    break;
                
                
                case 2:
                    Console.Write("Wich room you want to see:");
                    string room = Console.ReadLine();
                    if (devices.ContainsKey(room))
                    {
                        devices[room].GetStatus();
                    }
                    else
                    {
                        throw new ArgumentNullException();
                    }

                    break;


                case 3:
                    Console.Write("Which room you want to see:");
                    string hroom = Console.ReadLine();
                    if (devices.ContainsKey(hroom))
                    {
                        Console.Write("For what rate you want to see(from 0.1 to 1.0:");
                        double rate = double.Parse(Console.ReadLine());
                        if (rate < 0.1 || rate > 1.0)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        else
                        {
                            devices[hroom].CalculateTimeToReachTarget(rate);
                        }
                    }
                    else
                    {
                        throw new ArgumentNullException();
                    }

                    break;
            }
            Console.WriteLine("Do you want to see other information y/n:");
            char cont = char.Parse(Console.ReadLine());
            if (cont == 'y')
            {
                Metods(devices);
            }
        }
    }
    }