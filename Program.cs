// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


System.Console.WriteLine("What operation do you want to perform Enter The correct number to continue");
Console.WriteLine("1.Addition.\n2.Division.\n3.Multiplication.\n4.Subtraction.");

decimal num1;
decimal num2;
decimal result;


int userInput = Convert.ToInt32(Console.ReadLine());
switch (userInput)
{
    case 1:
        Console.Write("Enter your First Number: ");
        num1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter your Second Number: ");
        num2 = Convert.ToDecimal(Console.ReadLine());
        result = num1 + num2;
        System.Console.WriteLine($"The Addition of {num1} and {num2} is: {result}");
        break;

    case 2:
        Console.Write("Enter your First Number: ");
        num1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter your Second Number: ");
        num2 = Convert.ToDecimal(Console.ReadLine());
        result = num1 / num2;
        System.Console.WriteLine($"The Division of {num1} and {num2} is: {result}");
        break;

    case 3:
        Console.Write("Enter your First Number: ");
        num1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter your Second Number: ");
        num2 = Convert.ToDecimal(Console.ReadLine());
        result = num1 * num2;
        System.Console.WriteLine($"The Multiplication of {num1} and {num2} is: {result}");
        break;

    case 4:
        Console.Write("Enter your First Number: ");
        num1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter your Second Number: ");
        num2 = Convert.ToDecimal(Console.ReadLine());
        result = num1 - num2;
        System.Console.WriteLine($"The Subtraction of {num1} and {num2} is: {result}");
        break;

    default:
        System.Console.WriteLine("You did\'nt specify a defined operation \n try again");
        break;
}