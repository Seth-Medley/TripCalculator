/*
* Name: Seth Medley
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/
// Road Trip
Console.Write("What was the round trip in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());


Console.Write("What is the miles per gallon for the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());
double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;
System.Console.WriteLine("Gallons Needed: " + gallonsNeeded.ToString("F1"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
////////////////////////////////////////////////////////////////
// Pizza Party
const int pizzaSlices = 8;
Console.WriteLine("How many people are going?");
int peopleGoing = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"There are {peopleGoing} going on the trip.");

Console.WriteLine("How many pizzas? ");
int pizzaAmt = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You are getting {pizzaAmt} pizzas.");

Console.WriteLine("How much does each pizza cost? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"You are getting {pizzaPrice} pizzas.");

int totalSlices = pizzaAmt * pizzaSlices;
int slicesPerPerson = totalSlices / peopleGoing;
double pizzaTotalCost = pizzaAmt * pizzaPrice;

Console.WriteLine($"Total slices: {totalSlices}");
Console.WriteLine($"Slices per person: {slicesPerPerson}");
Console.WriteLine($"Pizza cost: {pizzaTotalCost.ToString("F1")}");

// Paycheck
const double taxRate = 0.18;
Console.WriteLine("How many hours have you worked?");
int hours = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You have worked {hours} hours.");
Console.WriteLine("How much do you make per hour?");
double hourlyRate = Convert.ToDouble(Console.ReadLine());


double grossPay = hours * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;
Console.WriteLine($"Gross Pay: {grossPay.ToString("F2")}");
Console.WriteLine($"Tax Withheld: {taxWithheld.ToString("F2")}");
Console.WriteLine($"Take Home Pay: {takeHomePay.ToString("F2")}");


// Summary
double tripTotal = fuelCost + pizzaPrice;
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = takeHomePay / hours;
double hoursToWork = costPerPerson / takeHomePayPerHour;