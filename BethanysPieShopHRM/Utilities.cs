using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
	internal class Utilities
	{

		public static void ParsingStrings()
		{
			Console.WriteLine("Enter the wage: ");
			string wage = Console.ReadLine();

			//int wageValue = int.Parse(wage);

			int wageValue;
			if (int.TryParse(wage, out wageValue))
				Console.WriteLine("Parsing success: " + wageValue);
			else
				Console.WriteLine("Parsing failed");
		}

		public static void UsingStringEquality()
		{
			string name1 = "Bethany";
			string name2 = "BETHANY";

			Console.WriteLine("Are both names equal? " + (name1 == name2));
			Console.WriteLine("Is name1 equal to Bethany? " + (name1 == "Bethany"));
			Console.WriteLine("Is name2 equal to BETHANY? " + name2.Equals("BETHANY"));
			Console.WriteLine("Is lowercase name equal to bethany? " + (name1.ToLower() == "bethany"));
		}

		public static void UsingEscapeCharacters()
		{
			string firstName = "Bethany";
			string lastName = "Smith";

			string displayName = $"Welcome!\n{firstName}\t{lastName}";
			Console.WriteLine(displayName);

			//string filePath = "C:\\data\\employeelist.xlsx";

			string filePath = @"C:\data\employeelist.xlsx";

			string marketingTagLine = "Baking the \"best pies\" ever";
		}

		public static void ManipulatingStrings()
		{
			string firstName = "Bethany";
			string lastName = "Smith";

			string fullName = firstName + " " + lastName;
			string employeeIdentification = String.Concat(firstName + lastName);

			string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

			int length = empId.Length;

			if (fullName.Contains("beth") || fullName.Contains("Beth"))
			{
				Console.WriteLine("It's Bethany!");
			}

			string subString = fullName.Substring(1, 3);
			Console.WriteLine("Characters 2 through 4 of fullName are " + subString);

			string userNameWithInterpolation = $"{firstName}-{lastName}";
		}

		public static void UsingSimpleStrings()
		{
			string firstName = "Bethany";
			string lastName = "Smith";
			string s;
			s = firstName;
			var userName = "BethanyS";
			userName = userName.ToLower();

			userName = string.Empty;
			userName = "";//identical to string.Empty;
		}
	}
}
