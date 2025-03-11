int nKilometers = int.Parse(Console.ReadLine());
string dayOrNight = Console.ReadLine();

double totalPrice = 0;


if (nKilometers < 20 && dayOrNight == "day")
{
    double startingPrice = 0.70;
    double currentPrice = 0.79 * nKilometers;
    double taxiPrice = startingPrice + currentPrice;
    totalPrice += taxiPrice;
}
else if (nKilometers < 20 && dayOrNight == "night")
{
    double startingPrice = 0.70;
    double currentPrice = 0.90 * nKilometers;
    double taxiPrice = startingPrice + currentPrice;
    totalPrice += taxiPrice;
}
else if (nKilometers < 100)
{
    double busPrice = 0.09 * nKilometers;
    totalPrice += busPrice;
}
else
{
    double trainPrice = 0.06 * nKilometers;
    totalPrice += trainPrice;
}

Console.WriteLine($"{totalPrice:f2}");
