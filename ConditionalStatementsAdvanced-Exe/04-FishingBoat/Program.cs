int budged = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermens = int.Parse(Console.ReadLine());

double boatPrice = 0;

if (season == "Spring")
{
    boatPrice = 3000;
}
else if (season == "Summer" || season == "Autumn")
{
    boatPrice = 4200;
}
else if (season == "Winter")
{
    boatPrice = 2600;
}

if (fishermens <= 6)
{
    boatPrice *= 0.90;
}
else if (fishermens <= 11)
{
    boatPrice *= 0.85;
}
else
{
    boatPrice *= 0.75;
}



if (fishermens % 2 == 0 && season != "Autumn")
{
    boatPrice *= 0.95;
}

if (budged >= boatPrice)
{
    Console.WriteLine($"Yes! You have {budged - boatPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(budged - boatPrice):f2} leva.");
}
