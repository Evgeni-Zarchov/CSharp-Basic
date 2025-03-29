int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

for (int i = firstNumber; i <= secondNumber; i++)
{
    int evenPosition = 0;
    int oddPosition = 0;
    int currentPositions = 0;

    int currentNumber = i;

    while (currentNumber != 0)
    {
        int lastDigit = currentNumber % 10;
        currentNumber = currentNumber / 10;

        if (currentPositions % 2 == 0)
        {
            evenPosition += lastDigit;
        }
        else
        {
            oddPosition += lastDigit;
        }

        currentPositions++;

    }

    if (evenPosition == oddPosition)
    {
        Console.Write($"{i} ");
    }
}
