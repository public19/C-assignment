using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltAsgmt1.Appliances
{
    internal class Dishwasher : Appliance
    {
        public string sound_rating;
        public string feature;
        public Dishwasher() { }
        public Dishwasher(long item_number, string brand, int quantity, decimal wattage, string color, decimal price, string sound_rating, string feature) : base(item_number, brand, quantity, wattage, color, price)
        {
            this.sound_rating = sound_rating;
            this.feature = feature;
        }
        public override string formatFromFile()
        {
            string common_formatted = base.formatFromFile();
            string appliance_info = string.Join(";", common_formatted, sound_rating, feature);

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
                string.Format("Sound Rating: {0}", sound_rating) + "\n" +
                string.Format("Feature: {0}", feature);

            return display;
        }
    }
}
