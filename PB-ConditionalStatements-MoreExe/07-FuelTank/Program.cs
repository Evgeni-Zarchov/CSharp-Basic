string fuelType = Console.ReadLine();
double fuelCount = double.Parse(Console.ReadLine());

if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
{
    if (fuelCount >= 25)
    {
        Console.WriteLine($"You have enough {fuelType.ToLower()}.");
    }
    else
    {
        Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
    }
}
else
{
    Console.WriteLine("Invalid fuel!");
}
