using AltAsgmt1.Appliances;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AltAsgmt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] appliances = File.ReadAllLines("C:\\Users\\one39\\OneDrive\\Desktop\\oop2-asgmt-1-main\\AltAsgmt1\\res\\appliances.txt");

            string[] appliance_data = { };

             Random random = new Random();

            ArrayList all_appliances = new ArrayList();
            ArrayList all_refridgerators = new ArrayList();
            ArrayList all_vacuums = new ArrayList();
            ArrayList all_microwaves = new ArrayList();
            ArrayList all_dishwashers = new ArrayList();

            void createAppliances()
            {
                //creating appliance objects
                foreach (string appliance in appliances)
                {
                    appliance_data = appliance.Split(';');
                    if (int.Parse(appliance_data[0].Substring(0,1)) == 1)//refridgerator
                    {
                        Refridgerator refridgerator = new Refridgerator(long.Parse(appliance_data[0]), appliance_data[1], int.Parse(appliance_data[2]), decimal.Parse(appliance_data[3]), appliance_data[4], decimal.Parse(appliance_data[5]), short.Parse(appliance_data[6]), int.Parse(appliance_data[7]), int.Parse(appliance_data[8]));
                        all_appliances.Add(refridgerator);
                        all_refridgerators.Add(refridgerator);
                        Console.WriteLine("Create Refridgerator");
                    }
                    else if (int.Parse(appliance_data[0].Substring(0, 1)) == 2)//vacuum
                    {
                        Vacuum vacuum = new Vacuum(long.Parse(appliance_data[0]), appliance_data[1], int.Parse(appliance_data[2]), decimal.Parse(appliance_data[3]), appliance_data[4], decimal.Parse(appliance_data[5]), appliance_data[6], short.Parse(appliance_data[7]));
                        all_appliances.Add(vacuum);
                        all_vacuums.Add(vacuum);
                        Console.WriteLine("Create Vacuum");
                    }
                    else if (int.Parse(appliance_data[0].Substring(0, 1)) == 3)//microwave
                    {
                        Microwave microwave = new Microwave(long.Parse(appliance_data[0]), appliance_data[1], int.Parse(appliance_data[2]), decimal.Parse(appliance_data[3]), appliance_data[4], decimal.Parse(appliance_data[5]), float.Parse(appliance_data[6]), char.Parse(appliance_data[7]));
                        all_appliances.Add(microwave);
                        all_microwaves.Add(microwave);
                        Console.WriteLine("Create Microwave");
                    }
                    else if (int.Parse(appliance_data[0].Substring(0, 1)) == 4 || int.Parse(appliance_data[0].Substring(0, 1)) == 5)//dishwasher
                    {
                        Dishwasher dishwasher = new Dishwasher(long.Parse(appliance_data[0]), appliance_data[1], int.Parse(appliance_data[2]), decimal.Parse(appliance_data[3]), appliance_data[4], decimal.Parse(appliance_data[5]), appliance_data[6], appliance_data[7]);
                        all_appliances.Add(dishwasher);
                        all_dishwashers.Add(dishwasher);
                        Console.WriteLine("Create Dishwasher");
                    }
                    else
                    {
                        Console.WriteLine("idk what to put here :/");
                    }
                }
            }

            string readUserInput()
            {
                string user_input = Console.ReadLine();
                return user_input;
            }

            void welcome()
            {
                Console.WriteLine("Welcome to Modern Appliances!");
                Console.WriteLine("How may we assist you?");
                Console.WriteLine("1 – Check out appliance");
                Console.WriteLine("2 – Find appliances by brand");
                Console.WriteLine("3 – Display appliances by type");
                Console.WriteLine("4 – Produce random appliance list");
                Console.WriteLine("5 – Save & exit");
                Console.WriteLine("\nEnter option:");

                string user_input = readUserInput();

                if (user_input == "1") 
                {
                    Console.WriteLine("Enter the item number of an appliance:");
                    user_input = readUserInput();
                }
                else if (user_input == "2")
                {
                    Console.WriteLine("Enter brand to search for:");
                    user_input = readUserInput();
                }
                else if (user_input == "3")
                {
                    Console.WriteLine("Appliance type:");
                    Console.WriteLine("1 – Refrigerators");
                    Console.WriteLine("2 – Vacuums");
                    Console.WriteLine("3 – Microwaves");
                    Console.WriteLine("4 – Dishwashers");
                    Console.WriteLine("\nEnter type of appliance:");
                    user_input = readUserInput();
                }
                else if (user_input == "4")
                {
                    Console.WriteLine("Enter number of appliances:");
                    user_input = readUserInput();
                    Console.WriteLine("Random appliances:");
                    for (int i = 0; i < int.Parse(user_input); i++)
                    {
                        int index = random.Next(all_appliances.Count);
                        Console.WriteLine(all_appliances[index]);
                    }
                }
                else if (user_input == "5")
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option. Rerun program");
                }

            }
            
            createAppliances();
            welcome();
            Console.ReadKey();
        }
    }
}
