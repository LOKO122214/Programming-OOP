using Smart_Logistics_System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== СИСТЕМА ЗА УПРАВЛЕНИЕ НА SMART СКЛАД ===");

        ColdStorage fridge = new ColdStorage("COLD-01", 10.5, -18.0);
        HighSecurityVault vault = new HighSecurityVault("VAULT-X", 2.0, "1234");

        Console.WriteLine("--- Тест на Method Overloading ---");
        fridge.PlaceItem("Ваксини тип А");

        fridge.PlaceItem("Морски дарове", 4.2);

        vault.PlaceItem("Голям метален контейнер", 5.5);
        Console.WriteLine();

        Console.WriteLine("--- Тест на Климатичен Контрол ---");
        fridge.CheckClimateSafety();


        Console.WriteLine("--- Тест на Сигурност ---");

        Console.Write("Опит за отключване с ПИН 0000: ");
        vault.Unlock("0000");

        Console.Write("Опит за отключване с ПИН 1234: ");
        vault.Unlock("1234");


        Console.WriteLine("=== КРАЙ НА СИМУЛАЦИЯТА ===");
        Console.ReadLine();
    }
}