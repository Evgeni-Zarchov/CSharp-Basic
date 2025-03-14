int juniorBikers = int.Parse(Console.ReadLine());
int seniorBikers = int.Parse(Console.ReadLine());
string raceType = Console.ReadLine();

double taxJunior = 0;
double taxSenior = 0;

if (raceType == "trail")
{
    taxJunior = 5.50;
    taxSenior = 7.00;
}
else if (raceType == "cross-country")
{
    taxJunior = 8.00;
    taxSenior = 9.50;
}
else if (raceType == "downhill")
{
    taxJunior = 12.25;
    taxSenior = 13.75;
}
else if (raceType == "road")
{
    taxJunior = 20.00;
    taxSenior = 21.50;
}

double totalTax = taxJunior * juniorBikers + taxSenior * seniorBikers;

if (juniorBikers + seniorBikers >= 50 && raceType == "cross-country")
{
    totalTax *= 0.75;
}

totalTax *= 0.95;

Console.WriteLine($"{totalTax:f2}");
