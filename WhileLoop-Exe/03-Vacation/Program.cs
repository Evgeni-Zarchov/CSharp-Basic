double vacationPrice = double.Parse(Console.ReadLine());
double currentMoney = double.Parse(Console.ReadLine());
int daysCount = 0;
int spendCounter = 0;

for (; ; )
{
    string action = Console.ReadLine();
    double spendOrSave = double.Parse(Console.ReadLine());
    daysCount++;

    if (action == "spend")
    {
        currentMoney -= spendOrSave;
        spendCounter++;
    }
    else
    {
        currentMoney += spendOrSave;
        spendCounter = 0;
    }

    if (currentMoney <= 0)
    {
        currentMoney = 0;
    }

    if (spendCounter == 5 || currentMoney >= vacationPrice)
    {
        break;

    }
}

if (spendCounter == 5)
{
    Console.WriteLine($"You can't save the money.");
    Console.WriteLine($"{daysCount}");
}
else
{
    Console.WriteLine($"You saved the money for {daysCount} days.");
}

