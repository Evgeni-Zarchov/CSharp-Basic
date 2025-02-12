double budged = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string hotelOrCamp = "";
string destination = "";

if (budged <= 100)
{
    if (season == "summer")
    {
        destination = "Bulgaria";
        hotelOrCamp = "Camp";
        budged = budged - (budged * 0.70);
    }
    else if (season == "winter")
    {
        destination = "Bulgaria";
        hotelOrCamp = "Hotel";
        budged = budged - (budged * 0.30);
    }
}
else if (budged <= 1000)
{
    if (season == "summer")
    {
        destination = "Balkans";
        hotelOrCamp = "Camp";
        budged = budged - (budged * 0.6);
    }
    else if (season == "winter")
    {
        destination = "Balkans";
        hotelOrCamp = "Hotel";
        budged = budged - (budged * 0.20);
    }
}
else
{
    destination = "Europe";
    hotelOrCamp = "Hotel";
    budged = budged - (budged * 0.10);
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{hotelOrCamp} - {budged:f2}");
