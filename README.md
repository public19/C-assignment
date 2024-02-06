# C-assignmentAssignment: Classes and Inheritance

Scenario
A local company, Modern Appliances, has hired you to implement a system to manage their appliance data more efficiently. They want a system that allows both employees and customers to find, list and purchase appliances. 
They company has provided you with a data file containing a sample list of appliances. The data file contains four types of appliances: refrigerators, vacuums, microwaves and dishwashers. Each appliance is uniquely identified using an item number, and information about each type of appliance is described in the formatting section.
Equipment and Materials
For this assignment, you will need:
•	Visual Studio IDE
•	Supplied data file: appliances.txt 
 
Instructions
1.	Review the scenario, and then carefully read the Appliance Details and Program Guidelines sections of this document.
2.	Working outside of class time, complete the submission sections of this assignment.
3.	Review the grading criteria for the group submissions. 
4.	See the course schedule and/or Brightspace for due dates.


Appliance Details
Data Formatting
•	Each of the following appliance types is represented differently in the supplied appliances.txt file. 
•	Each line in the file represents a different appliance and each piece of information for an appliance is separated by a semi-colon. 
•	The first digit of the Item Number indicates the type of the appliance. Each item number is 9 digits long.
Refrigerators
•	The first digit of the Item Number for refrigerators is 1. 
•	Refrigerators have an Item Number, Brand, Quantity, Wattage, Color, Price, Number of Doors, Height and Width (in inches). 
•	The number of doors value can be either 2 (double doors), 3 (three doors) or 4 (four doors).
•	Each refrigerator is represented in the appliances.txt file file as follows:
ItemNumber;Brand;Quantity;Wattage;Color;Price;NumberOfDoors;Height;Width
Example:
089360200;Bosch;176;60;black;2000;2;62;29;
Vacuums 
•	The first digit of the Item Number for vacuums is 2. 
•	Vacuums have an Item Number, Brand, Quantity, Wattage, Color, Price, Grade and Battery Voltage. 
•	The Battery voltage value can be either 18 V (Low) or 24 V (High).
•	Each vacuum is represented in the appliances.txt file as follows:
ItemNumber;Brand;Quantity;Wattage;Color;Price;Grade;BatteryVoltage
Example:
263788832;Hoover;59;600;black;750;Residential;18;
Microwaves
•	The first digit of the Item Number for microwaves is 3. 
•	Microwaves have an Item Number, Brand, Quantity, Wattage, Color, Price, Capacity and Room Type. 
•	The room type is where the microwave will be installed, and is either K (kitchen) or W (work site)
•	Each microwave is represented in the appliances.txt file as follows:
ItemNumber;Brand;Quantity;Wattage;Color;Price;Capacity;RoomType
Example:
383477937;Miele;201;2350;white;179.9;1.8;Kitchen;
Dishwashers
•	The first digit of the Item Number for dishwashers is 4 or 5. 
•	Dishwashers have an Item Number, Brand, Quantity, Wattage, Color, Price, Sound Rating, and Feature. 
•	The Sound Rating of the dishwasher can be Qt (Quietest), Qr (Quieter), Qu (Quiet) or M (Moderate).
•	Each dishwasher is represented in the appliances.txt file as follows:
ItemNumber;Brand;Quantity;Wattage;Color;Price;Feature;SoundRating
Example:
587065284;Kenwood;74;1010;silver;390;Clean with Steam;Qu; 
Program Guidelines
The fact that the data formatting is different for each type of appliance adds a level of complexity to program development. Creating a class hierarchy is required:
•	Determine the attributes that are shared between the appliance types and create an Appliance class containing them. 
Note: The Appliance class cannot be instantiated and must be a super-class.
•	Create the following classes such that each one inherits the Appliance class and is located in the program’s ProblemDomain folder:
o	Refrigerator
o	Vacuum
o	Microwave 
o	Dishwasher 
•	Ensure that each of these classes has a user-defined constructor that assigns the appropriate attributes.
•	Override the ToString() method in each one of these classes, so that the data is in a human readable format. 
•	The attributes should be displayed using vertical headers.
 
Along with the functionality mentioned above, include the following methods in your program:
•	A method that parses the appliances.txt file into a single list. 
o	The list must be able to contain all appliance types (refrigerator, vacuum, microwave, and dishwasher). 
o	Use the first digit of the item number to determine what valid type of appliance needs to be created (see the Appliance Details section for more information). 
•	A method that allows a customer to purchase an appliance. 
o	The customer is prompted to enter the item number of an appliance. If the entered item number does not match, the program will inform the customer with an error message. If the item number matches, the program checks the appliance’s availability. If there is an appliance available, the available count will be decremented and the appliance information will be displayed. Otherwise, the customer will be informed the appliance is not available. 
•	A method that prompts the customer to enter a brand. The program performs a case-insensitive search of appliances that have the same brand, and displays them.
•	A method that prompts a user to enter a number, and the program then displays that number of random appliances. The appliances can be of any type. 
•	When the program exits, implement and call a method that takes the appliances stored in the list and persists them back to the appliances.txt file in the proper format.
