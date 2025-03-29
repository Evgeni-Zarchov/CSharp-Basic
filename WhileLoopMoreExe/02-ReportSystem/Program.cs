using System.Xml;

int requiredMoney = int.Parse(Console.ReadLine());
double cashPayment = 0;
double cardPayment = 0;
int counter = 0;
int cashCounter = 0;
int cardCounter = 0;
double totalPayment = 0;
string action = Console.ReadLine();

while (action != "End" || totalPayment <= requiredMoney)
{
    int currentPayment = int.Parse(action);

    if (counter % 2 == 0)
    {
        if (currentPayment > 100)
        {
            Console.WriteLine("Error in transaction!");
        }
        else
        {
            Console.WriteLine("Product sold!");
            totalPayment += currentPayment;
            cashPayment += currentPayment;
            cashCounter++;
        }
    }
    else
    {
        if (currentPayment < 10)
        {
            Console.WriteLine("Error in transaction!");
        }
        else
        {
            Console.WriteLine("Product sold!");
            totalPayment += currentPayment;
            cardPayment += currentPayment;
            cardCounter++;
        }
    }


    counter++;
    action = Console.ReadLine();

    if (totalPayment >= requiredMoney)
    {
        Console.WriteLine($"Average CS: {Math.Abs(cashPayment / cashCounter):f2}");
        Console.WriteLine($"Average CC: {Math.Abs(cardPayment / cardCounter):f2}");
        break;
    }
    else
    {
        if (action == "End")
        {
            Console.WriteLine("Failed to collect required money for charity.");
            break;
        }
    }

}




