string command = Console.ReadLine();
int maxNumber = int.MinValue;

while (command != "Stop")
{
    int currentNumber = int.Parse(command);

    if (currentNumber > maxNumber)
    {
        maxNumber = currentNumber;
    }

    command = Console.ReadLine();
}

Console.WriteLine(maxNumber);