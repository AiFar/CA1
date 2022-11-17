using System;
namespace Q6
{
    public class ElectricBike
    {
        public ElectricBike()
        {
        }

        private string id;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private string location;

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        private int batteryPercentage;

        public int BatteryPercentage
        {
            get { return this.batteryPercentage; }
            set { this.batteryPercentage = value; }
        }
    }
}
