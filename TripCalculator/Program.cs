/*
* Name: Seth Medley
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/
Console.WriteLine("=== Part 1: Road Trip ===");
Console.Write("Round trip miles: ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());


Console.Write("Miles per gallon: ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("Price Per Gallon:  ");
double gasPrice = Convert.ToDouble(Console.ReadLine());
double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

Console.WriteLine("=== Part 2: Pizza Party ===");
const int pizzaSlices = 8;
Console.Write("How many people are going?");
int peopleGoing = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas? ");
int pizzaAmt = Convert.ToInt32(Console.ReadLine());

Console.Write("How much does each pizza cost? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

int totalSlices = pizzaAmt * pizzaSlices;
double slicesPerPerson = (double)totalSlices / peopleGoing;
double pizzaTotalCost = pizzaAmt * pizzaPrice;

Console.WriteLine($"Total slices: {totalSlices}");
Console.WriteLine($"Slices per person: {slicesPerPerson.ToString("F1")}");
Console.WriteLine($"Pizza cost: {pizzaTotalCost.ToString("C")}");

Console.WriteLine("=== Part 3: Paycheck ===");

const double taxRate = 0.18;
Console.Write("Hours worked this week: ");
int hours = Convert.ToInt32(Console.ReadLine());
Console.Write("Hourly rate: ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());


double grossPay = hours * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;
Console.Write($"Gross pay: {grossPay.ToString("C")}");
Console.Write($"Tax withheld: {taxWithheld.ToString("C")}");
Console.Write($"Take home pay: {takeHomePay.ToString("C")}");


Console.WriteLine("=== Part 4: The Whole Trip ===");
double tripTotal = fuelCost + pizzaTotalCost;
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = takeHomePay / hours;
double hoursToWork = costPerPerson / takeHomePayPerHour;

Console.WriteLine($"Trip total: {tripTotal.ToString("C")}");
Console.WriteLine($"Cost per person:  {costPerPerson.ToString("C")}");
Console.WriteLine($"Take home pay per hour: {takeHomePay.ToString("C")}");
Console.WriteLine($"Hours you must work to cover your share: {tripTotal.ToString("F2")} hours.");