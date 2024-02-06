using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltAsgmt1
{
    internal class Vacuum : Appliance
    {
        public string grade { get; set; }
        public short battery_voltage { get; set;}

        public Vacuum() { }
        public Vacuum(long item_number, string brand, int quantity, decimal wattage, string color, decimal price, string grade, short battery_voltage) : base(item_number, brand, quantity, wattage, color, price)
        {
            this.grade = grade;
            this.battery_voltage = battery_voltage;
        }
        public override string formatFromFile()
        {
            string common_formatted = base.formatFromFile();
            string appliance_info = string.Join(";", common_formatted, grade, battery_voltage);

            return appliance_info;
        }

        public override string ToString()
        {
            string display =
                string.Format("Item Number: {0}", item_number) + "\n" +
                string.Format("Brand: {0}", brand) + "\n" +
                string.Format("Quantity: {0}", quantity) + "\n" +
                string.Format("Wattage: {0}", wattage) + "\n" +
                string.Format("Color: {0}", color) + "\n" +
                string.Format("Price: {0}", price) + "\n" +
                string.Format("Grade: {0}", grade) + "\n" +
                string.Format("Battery Voltage: {0}", battery_voltage);

            return display;
        }

    }
}
