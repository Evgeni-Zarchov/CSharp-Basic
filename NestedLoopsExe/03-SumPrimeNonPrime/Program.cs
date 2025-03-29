int primeNumbersCount = 0;
int nonPrimeNumbersCount = 0;
string action;
while ((action = Console.ReadLine()) != "stop")
{
    int currentNumber = int.Parse(action);

    bool isPrime = false;
    if (currentNumber < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    for (int i = 2; i <= Math.Sqrt(currentNumber); i++)
    {
        if (currentNumber % i == 0)
        {
            isPrime = true;
            break;
        }
    }

    if (!isPrime)
    {
        primeNumbersCount += currentNumber;
    }
    else
    {
        nonPrimeNumbersCount += currentNumber;
    }
}

Console.WriteLine($"Sum of all prime numbers is: {primeNumbersCount}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersCount}");