using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Thermostat
{
    internal class SmartHomeThermostat
    {
        private string roomName;
        private double currentTemperature;
        private double targetTemperature;
        private static byte devicesCount;


        private string RoomName
        {
            get 
            { 
                return roomName; 
            }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    roomName = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        
        
        private double CurrentTemperature
        {
            get
            {
                return currentTemperature;
            }
            set
            {
                currentTemperature = value;
            }
        }

        private double TargetTemperature
        {
            get
            {
                return targetTemperature;
            }
            set
            {
                if (value < 5 || value >30) 
                { 
                  throw new ArgumentOutOfRangeException();
                }
                else
                {
                    targetTemperature = value;
                }
            }
        }

       public static void devicescount()
        {
            Console.WriteLine($"The Count of devices is {devicesCount}");
        }


        public SmartHomeThermostat()
        {
            currentTemperature = 20.0;
            targetTemperature = 20.0;
            devicesCount++;
            roomName = "Unknown Room";
        }

        public SmartHomeThermostat(string roomName,double currentTemperature, double targettemperature)
        {
            this.RoomName = roomName;
            this.CurrentTemperature = currentTemperature;
            this.TargetTemperature = targettemperature;
            devicesCount++;
        }

        public void GetStatus()
        {
            string status = "";
            if (CurrentTemperature < TargetTemperature)
            {
                status = "Heating";
            }
            else if (CurrentTemperature == TargetTemperature)
            {
                status = "Reached";
            }
            else 
            {
                status = "Cooling";
            }
                Console.WriteLine($"Room:{RoomName}|Current:{CurrentTemperature}|Target:{TargetTemperature}|Status:{status}");
        }

        public double CalculateTimeToReachTarget(double heatingRate)
        {
            double deltaT = TargetTemperature - CurrentTemperature;
            if (deltaT > 0)
            {
                heatingRate = deltaT / heatingRate;
                Console.WriteLine($"Room will heat in {heatingRate} minutes");
            }
            else if (deltaT == 0)
            {
                Console.WriteLine("Room will not heat or cool");
            }
            else
            {
                heatingRate = deltaT / heatingRate;
                Console.WriteLine($"Room will cool in {-1*(heatingRate)} minutes");
            }
                return heatingRate;
        }


    }
        
}
