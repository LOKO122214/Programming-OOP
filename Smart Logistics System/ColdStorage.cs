using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Logistics_System
{
    internal class ColdStorage :StorageUnit
    {
        public double TargetTemperature { get; set; }

        public ColdStorage(string id, double capacity, double targetTemp) : base(id, capacity)
        {
            TargetTemperature = targetTemp;
            currentTemperature = targetTemp;
        }

        public void CheckClimateSafety()
        {
            if (currentTemperature > 5.0)
            {
                IsLocked = true;
                Console.WriteLine($"АЛАРМА: Температурата в {UnitIndentifier} е критична! Клетката е блокирана.");
            }
            else
            {
                Console.WriteLine($"Климатът в {UnitIndentifier} е стабилен ({currentTemperature}°C).");
            }
        }
    }
}
