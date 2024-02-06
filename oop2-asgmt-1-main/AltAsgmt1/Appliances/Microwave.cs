using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltAsgmt1
{
    internal class Microwave : Appliance
    {
        public float capacity { get; set; }
        public char room_type { get; set; }
        public Microwave() { }
        public Microwave(long item_number, string brand, int quantity, decimal wattage, string color, decimal price, float capacity, char room_type) : base(item_number, brand, quantity, wattage, color, price)
        {
            this.capacity = capacity;
            this.room_type = room_type;
        }
        public override string formatFromFile()
        {
            string common_formatted = base.formatFromFile();
            string appliance_info = string.Join(";", common_formatted, capacity, room_type);

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
                string.Format("Capacity: {0}", capacity) + "\n" +
                string.Format("Room Type: {0}", room_type);

            return display;
        }

    }
}
