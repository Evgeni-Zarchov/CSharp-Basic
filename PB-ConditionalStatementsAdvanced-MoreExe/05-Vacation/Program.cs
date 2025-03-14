double budged = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string vacationType = "";
string location = "";

if (budged <= 1000)
{
    vacationType = "Camp";

    if (season == "Summer")
    {
        location = "Alaska";
        budged *= 0.65;
    }
    else
    {
        location = "Morocco";
        budged *= 0.45;
    }
}
else if (budged > 1000 && budged <= 3000)
{
    vacationType = "Hut";

    if (season == "Summer")
    {
        location = "Alaska";
        budged *= 0.80;
    }
    else
    {
        location = "Morocco";
        budged *= 0.60;
    }
}
else
{
    vacationType = "Hotel";

    if (season == "Summer")
    {
        location = "Alaska";
        budged *= 0.90;
    }
    else
    {
        location = "Morocco";
        budged *= 0.90;
    }
}

Console.WriteLine($"{location} - {vacationType} - {budged:f2}");