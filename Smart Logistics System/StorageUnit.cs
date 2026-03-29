using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Logistics_System
{
    internal class StorageUnit
    {
        private string unitIdentifier;
        private double maxCapacity;
        private protected double currentTemperature;
        private protected bool isLokced;

        public string UnitIndentifier
        {
            get { return unitIdentifier; }
            set { if (!string.IsNullOrEmpty(value))
                {
                    unitIdentifier = value;
                } 
            
            }
        }

        public double MaxCapacity
        {
            get { return maxCapacity; }
            set { if  (value !< 0)
                {
                    maxCapacity = value;
                } 
            }
        }


        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set {  currentTemperature = value; }
        }

        public bool IsLocked
        {
            get { return isLokced; }
            set { isLokced = value; }
        }

        public StorageUnit(string id,double maxCapacity) 
        { 
            UnitIndentifier = id;
            maxCapacity = MaxCapacity;
        }



        public void PlaceItem(string itemName)
        {
            Console.WriteLine($"Предмет '{itemName}' е поставен в клетка {UnitIndentifier}.");
        }

        public void PlaceItem(string itemName, double itemVolume)
        {
            if (itemVolume > MaxCapacity)
            {
                Console.WriteLine($"ГРЕШКА: Предметът '{itemName}' е твърде голям за клетка {UnitIndentifier}!");
            }
            else
            {
                Console.WriteLine($"Предмет '{itemName}' с обем {itemVolume} m3 е успешно заскладен.");
            }
        }

    }
}
