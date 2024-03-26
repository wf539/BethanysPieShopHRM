﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
	internal class Utilities
	{
		public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
		{
			//Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked}");
			//return monthlyWage * numberOfMonthsWorked;

			if (numberOfMonthsWorked == 12)//let's add a bonus month
				return monthlyWage * (numberOfMonthsWorked + 1);

			return monthlyWage * numberOfMonthsWorked;
		}

		public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
		{
			Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
			return monthlyWage * numberOfMonthsWorked + bonus;
		}

		public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
		{
			Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
			return monthlyWage * numberOfMonthsWorked + bonus; 
		}
	}
}
