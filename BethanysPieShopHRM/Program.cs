﻿// See https://aka.ms/new-console-template for more information

/*
 Multi-line
 comment
 */
Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

//Console.WriteLine("Please enter your name: ");

//The following will accept the name
//string name = Console.ReadLine();

//string name2 = Console.ReadLine();

//string name_2 = Console.ReadLine();

//string Name_2 = Console.ReadLine();

//string 2Name = Console.ReadLine();

var monthlyWage = 1234;

int months = 12, bonus = 1000;

var isActive = true;

var rating = 99.25;

var numberOfEmployees = 300;

int hoursWorked;

hoursWorked = 125;

hoursWorked = 148;

//monthlyWage = true;

const double interestRate = 0.07;

// interestRate = 0.08;

string firstName = "Bethany";
string lastName = "Smith";

string emptyString = "";

//Console.WriteLine("Please enter your name: ");
//string name = Console.ReadLine();

double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine(currentMonthWage);

ratePerHour += 3; //same as ratePerHour = ratePerHour +3;
Console.WriteLine(ratePerHour);

if (currentMonthWage > 2000)
	Console.WriteLine("Top paid employee!");

//int employeeCount = 15;
//employeeCount--;

//bool a;
//int b;

//Console.WriteLine(employeeCount);

//int intMaxValue = int.MaxValue;
//int intMinValue = int.MinValue;

//char userSelection = 'a';

//char upperVersion = char.ToUpper(userSelection);

//bool isDigit = char.IsDigit(userSelection);

//bool isLetter = char.IsLetter(userSelection);

var hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
//Console.WriteLine(hireDate);

//DateTime exitDate = new DateTime(2025, 12, 11);

////DateTime invalidDate = new DateTime(2025, 15, 11);

//DateTime startDate = hireDate.AddDays(15);                                   
//Console.WriteLine(startDate);

//DateTime currentDate = DateTime.Now;
//bool areWeInDst = currentDate.IsDaylightSavingTime();

//DateTime startHour = DateTime.Now;
//TimeSpan workTime = new TimeSpan(8, 35, 0);
//DateTime endHour = startHour.Add(workTime);

//Console.WriteLine(startHour.ToLongDateString());
//Console.WriteLine(endHour.ToShortTimeString());

long veryLongMonth = numberOfHoursWorked;//works fine

double d = 123456789.0;

int x = (int)d;

int intVeryLongMonth = (int)veryLongMonth;

Console.ReadLine();
