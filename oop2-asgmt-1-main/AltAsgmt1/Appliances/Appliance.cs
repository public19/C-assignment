using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltAsgmt1
{
    abstract internal class Appliance
    {
        public long item_number { get; set; }
        public string brand { get; set; }
        public int quantity { get; set; }
        public decimal wattage { get; set; }
        public string color { get; set; }
        public decimal price { get; set; }
        

        public Appliance() { }
        public Appliance(long item_number, string brand, int quantity, decimal wattage, string color, decimal price) // : base(item_number, brand, quantity, wattage, color, price)
        {
            this.item_number = item_number;
            this.brand = brand;
            this.quantity = quantity;
            this.wattage = wattage;
            this.color = color;
            this.price = price;
        }

        public int checkOut()
        {
            quantity -= 1;
            return quantity;
        }
        public virtual string formatFromFile() 
        {
            string appliance_info = $"{item_number};{brand};{quantity};{wattage};{color};{price}";
            return appliance_info;
        }
        public string DetermineAppliance(long item_number)
        {
            string string_first_digit = item_number.ToString().Substring(0, 1);
            int first_digit = int.Parse(string_first_digit);

            if (first_digit == 1)
            {
                return "Refrigerator";
            }
            else if (first_digit == 2)
            {
                return "Vacuum";
            }
            else if (first_digit == 3)
            {
                return "Microwave";
            }
            else if (first_digit == 4 || first_digit == 5)
            {
                return "Dishwasher";
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
