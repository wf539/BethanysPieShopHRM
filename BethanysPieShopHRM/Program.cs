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

Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

switch (age)
{
	case < 18:
	case > 65:
		Console.WriteLine("Sorry, your age is not within the range we are looking for");
		break;
	case 23:
		Console.WriteLine("Wow, exactly what we are looking for");
		break;
	default:
		Console.WriteLine("Great, you can now start with the application!");
		break;
}