/*
* Name: Seth Medley
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/
///////////////////////////
// Road Trip
/////////////////////
Console.WriteLine("=== Part 1: Road Trip ===");
Console.Write("Round trip miles: ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("Miles per gallon: ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("Price per gallon: ");
double gasPrice = Convert.ToDouble(Console.ReadLine());
double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2")); // Calculates fuel.
System.Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
System.Console.WriteLine();
//////////////////////////////////////////////
// Pizza Party
///////////////////////////////////
Console.WriteLine("=== Part 2: Pizza Party ===");
const int pizzaSlices = 8;
Console.Write("How many people are going: ");
int peopleGoing = Convert.ToInt32(Console.ReadLine());
Console.Write("How many pizzas: ");
int pizzaAmt = Convert.ToInt32(Console.ReadLine());
Console.Write("Price Per Pizza: ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());
int totalSlices = pizzaAmt * pizzaSlices;
double slicesPerPerson = (double)totalSlices / peopleGoing;
double pizzaTotalCost = pizzaAmt * pizzaPrice;

// Calculates Pizza Prices, How many slices each person gets and how much each pizza costs.
Console.WriteLine($"Total slices: {totalSlices}");
Console.WriteLine($"Slices per person: {slicesPerPerson.ToString("F1")}");
Console.WriteLine($"Pizza cost: {pizzaTotalCost.ToString("C")}");
System.Console.WriteLine();
/////////////////////////////////////////
// Paycheck
//////////////////////////////
Console.WriteLine("=== Part 3: Paycheck ===");
const double taxRate = 0.18; // Defines tax rate.
Console.Write("Hours worked this week: ");
int hours = Convert.ToInt32(Console.ReadLine());
Console.Write("Hourly rate: ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

// Calculates User gross pay, taxes withheld from pay, and how much pay they take home.
double grossPay = hours * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;
Console.WriteLine($"Gross pay: {grossPay.ToString("C")}");
Console.WriteLine($"Tax withheld: {taxWithheld.ToString("C")}");
Console.WriteLine($"Take home pay: {takeHomePay.ToString("C")}");
System.Console.WriteLine();
////////////////////////////////////
// The whole trip
////////////////////////
Console.WriteLine("=== Part 4: The Whole Trip ===");
double tripTotal = fuelCost + pizzaTotalCost;
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = takeHomePay / hours;
double hoursToWork = costPerPerson / takeHomePayPerHour;

// Summary combines the total cost of the trip, the cost for each person, how much the user takes home per hour, and how many hours they need to work in order to cover their share.
Console.WriteLine($"Trip total: {tripTotal.ToString("C")}");
Console.WriteLine($"Cost per person: {costPerPerson.ToString("C")}");
Console.WriteLine($"Take home pay per hour: {takeHomePayPerHour.ToString("C")}");
Console.WriteLine($"Hours you must work to cover your share: {hoursToWork.ToString("F2")}");
System.Console.WriteLine();