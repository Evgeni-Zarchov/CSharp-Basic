string season = Console.ReadLine();
double kmPerSeason = double.Parse(Console.ReadLine());

double kmPrice = 0;
int seasonDuration = 4;
if (kmPerSeason <= 5000)
{
    if (season == "Spring" || season == "Autumn")
    {
        kmPrice = 0.75;
    }
    else if (season == "Summer")
    {
        kmPrice = 0.90;
    }
    else
    {
        kmPrice = 1.05;
    }
}
else if (kmPerSeason > 5000 && kmPerSeason <= 10000)
{
    if (season == "Spring" || season == "Autumn")
    {
        kmPrice = 0.95;
    }
    else if (season == "Summer")
    {
        kmPrice = 1.10;
    }
    else
    {
        kmPrice = 1.25;
    }
}
else if (kmPerSeason > 10000 && kmPerSeason <= 20000)
{
    kmPrice = 1.45;
}

double salary = kmPrice * kmPerSeason * seasonDuration;
salary = salary - (salary * 0.10);

Console.WriteLine($"{salary:f2}");

