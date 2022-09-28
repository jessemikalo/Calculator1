using System.ComponentModel;
using System.Transactions;

Console.WriteLine("Welcome to Calculator: Enter your Option (1-4)");
Console.WriteLine("1. Add");
Console.WriteLine("2. Sub");
Console.WriteLine("3. Multiply");
Console.WriteLine("4. Divide");

float action, number1, number2, result;
bool stillMore;
do
{
    Console.Write("Enter your option: ");
    string received = Console.ReadLine();
    while (!float.TryParse(received, out action))
    { 
        Console.Write("Not valid, try again: ");
        received = Console.ReadLine();
    }

    Console.Write("Enter 1st No: ");
    received = Console.ReadLine();
    while (!float.TryParse(received, out number1))
    { 
        Console.Write("Not valid, try again: ");
        received = Console.ReadLine();
    }

    Console.Write("Enter 2nd No: ");
    received = Console.ReadLine();
    while (!float.TryParse(received, out number2))
    {
        Console.WriteLine("Not valid, try again: ");
        received= Console.ReadLine();
    }

    switch (action)
    {
        case 1:
            result = number1 + number2;
            Console.WriteLine("Add: " + result);
            break;

        case 2:
            result = number1 - number2;
            Console.WriteLine("Sub: " + result);
            break;

        case 3:
            result = number1 * number2;
            Console.WriteLine("Multiply: " + result);
            break;

        case 4:
            result = number1 / number2;
            if(number2 == 0)
                Console.WriteLine("Denominator can't be 0.");
            else
                Console.WriteLine("Divide: " + result);
            break;

        default:
            Console.WriteLine("Not valid, try again: ");
            break;
    }

            Console.Write("More numbers to calculate (Y/N)?: ");
            string choice = Console.ReadLine().ToUpper();
            if (choice.StartsWith("Y"))
                stillMore = true;
            else
                stillMore = false;
    } while (stillMore);






