using System.ComponentModel;
using System.Transactions;

Console.WriteLine("Welcome to Calculator: Enter your Option (1-4)");
Console.WriteLine("1. Add");
Console.WriteLine("2. Sub");
Console.WriteLine("3. Multiply");
Console.WriteLine("4. Divide");

int action, number1, number2, result;
bool stillMore;
do
{
    Console.WriteLine("Enter your first option: ");
    string received = Console.ReadLine();
    while (!Int32.TryParse(received, out action))
    {
        Console.Write("Not valid, try again");
    }

    Console.WriteLine("First number: ");
    received = Console.ReadLine();
    while (!Int32.TryParse(received, out number1))
    { 
        Console.WriteLine("Not valid, try again");
    }

    Console.WriteLine("Second number: ");
    received = Console.ReadLine();
    while (!Int32.TryParse(received, out number2))
    {
        Console.WriteLine("Not valid, try again");
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






