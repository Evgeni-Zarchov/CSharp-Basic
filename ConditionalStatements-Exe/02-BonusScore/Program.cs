int number = int.Parse(Console.ReadLine());

double bonusScore = 0.0;

if (number <= 100)
{
    bonusScore = 5;
}
else if (number > 1000)
{
    bonusScore = number * 0.10;
}
else
{
    bonusScore = number * 0.20;
}

if (number % 2 == 0)
{
    bonusScore = bonusScore + 1;
}

if (number % 10 == 5)
{
    bonusScore = bonusScore + 2;
}

Console.WriteLine(bonusScore);
Console.WriteLine(number + bonusScore);