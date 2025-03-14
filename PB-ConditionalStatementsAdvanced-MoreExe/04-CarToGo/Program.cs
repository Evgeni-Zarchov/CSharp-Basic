double budged = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string typeOfCar = "";
string carClass = "";

if (budged <= 100)
{
    carClass = "Economy class";

    if (season == "Summer")
    {
        typeOfCar = "Cabrio";
        budged *= 0.35;
    }
    else
    {
        typeOfCar = "Jeep";
        budged *= 0.65;
    }
}
else if (budged > 100 && budged <= 500)
{
    carClass = "Compact class";

    if (season == "Summer")
    {
        typeOfCar = "Cabrio";
        budged *= 0.45;
    }
    else
    {
        typeOfCar = "Jeep";
        budged *= 0.80;
    }
}
else
{
    carClass = "Luxury class";
    typeOfCar = "Jeep";
    budged *= 0.90;
}

Console.WriteLine($"{carClass}");
Console.WriteLine($"{typeOfCar} - {budged:f2}");