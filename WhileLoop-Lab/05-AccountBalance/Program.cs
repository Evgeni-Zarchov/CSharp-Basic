string command = Console.ReadLine();
double totalBalance = 0;

while (command != "NoMoreMoney")
{
    double currentSum = double.Parse(command);

    if (currentSum < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {currentSum:f2}");
    totalBalance += currentSum;

    command = Console.ReadLine();
}

Console.WriteLine($"Total: {totalBalance:f2}");