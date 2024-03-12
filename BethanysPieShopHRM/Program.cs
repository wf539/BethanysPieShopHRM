// See https://aka.ms/new-console-template for more information

//int age = 23;

//bool a = age == 23;

//Console.WriteLine("Age is 23: " +  a);

//bool b = age > 23;
//Console.WriteLine("Age is greater than 23: " + b);

//bool c = (age >= 18) && (age <= 65);
//Console.WriteLine("Age is between 18 and 65: " + c);

//int age1 = 16;
//int age2 = 64;
//bool d = (age1 >= 18) && (age2 <= 65);
//Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d);
//bool e = (age1 >= 18) || (age2 <= 65);
//Console.WriteLine("Age1 is greater than 18 OR age2 is less than 65: " + e);

//Console.WriteLine("Enter the age of the new candidate: ");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the age of the new candidate: ");
//int age = int.Parse(Console.ReadLine());

//switch (age)
//{
//	case < 18:
//	case > 65:
//		Console.WriteLine("Sorry, your age is not within the range we are looking for");
//		break;
//	case 23:
//		Console.WriteLine("Wow, exactly what we are looking for");
//		break;
//	default:
//		Console.WriteLine("Great, you can now start with the application!");
//		break;
//}



//int i = 1;
//while (i < 11)
//{
//	Console.WriteLine(i);
//	i++;
//}
//Console.WriteLine(i);



Console.WriteLine("Enter a value:");
int sum = 0;

string stringValue = Console.ReadLine();
int startValue = int.Parse(stringValue);

for (int i = startValue; i > 0; i--)
{
	sum += i;

}

Console.WriteLine("The sum is " + sum);


























//Console.WriteLine("Choose the action you want to do: ");
//Console.WriteLine("1. Add employee");
//Console.WriteLine("2. Update employee");
//Console.WriteLine("3. Delete employee");
//Console.WriteLine("99. Exit application");
//string selectedAction = Console.ReadLine();

//while (selectedAction != "99")
//{
//		switch (selectedAction)
//		{
//			case "1":
//				Console.WriteLine("Adding new employee...");
//				break;
//			case "2":
//				Console.WriteLine("Updating employee...");
//				break;
//			case "3":
//				Console.WriteLine("Deleting employee...");
//				break;
//			default:
//				Console.WriteLine("Invalid input");
//				break;
//		}
//	Console.WriteLine("Choose the action you want to do: ");
//	Console.WriteLine("1. Add employee");
//	Console.WriteLine("2. Update employee");
//	Console.WriteLine("3. Delete employee");
//	Console.WriteLine("99. Exit application");
//	selectedAction = Console.ReadLine();
//}
//Console.WriteLine("Closing application");

//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());
//int i = 0;


//while (i < max)
//{
//	Console.WriteLine(i);
//	i++;
//}

//int i = 10;

//while (i > 0)
//{
//	Console.WriteLine(i);
//	i--;
//}

//Console.WriteLine("Loop finished!");

//int i = 0;
//int j = 0;

//while (i < 10)
//{
//	while (j < 10)
//	{
//		Console.WriteLine("i: " + i + "   j: " + j);
//		j++;
//	}
//	j = 0;
//	i++;
//}

//while (true)
//{
//	Console.WriteLine(DateTime.Now);
//}


