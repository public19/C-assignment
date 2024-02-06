using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltAsgmt1
{
    internal class Refridgerator : Appliance
    {
        public int door { get; set; }
        public double height { get; set; }//in inches
        public double width { get; set; }//in inches

        public Refridgerator() { }
        public Refridgerator(long item_number, string brand, int quantity, decimal wattage, string color, decimal price, short doors, int width, int height) : base(item_number, brand, quantity, wattage, color, price)
        {
            this.door = door;
            this.height = height;
            this.width = width;
        }
        public override string formatFromFile() 
        {
            string common_formatted = base.formatFromFile();
            string appliance_info = string.Join(";", common_formatted, door, height, width);

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
               string.Format("Doors: {0}", door) + "\n" +
               string.Format("Width: {0}", width) + "\n" +
               string.Format("Height: {0}", height);
        
            return display;
        }
    }
}
