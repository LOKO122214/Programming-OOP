using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Logistics_System
{
    internal class HighSecurityVault :StorageUnit
    {
        private string secretPin;

        public HighSecurityVault(string id, double capacity, string pin) : base(id, capacity)
        {
            secretPin = pin;
        }

        public bool Unlock(string pinAttempt)
        {
            if (pinAttempt == secretPin)
            {
                IsLocked = false;
                Console.WriteLine($"Сейф {UnitIndentifier} е успешно отключен.");
                return true;
            }

            Console.WriteLine($"ГРЕШЕН ПИН за сейф {UnitIndentifier}! Достъпът е отказан.");
            return false;
        }


    }
}
