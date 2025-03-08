double degrees = double.Parse(Console.ReadLine());

string forecast = "";

if (degrees >= 26.00 && degrees <= 35.00)
{
    forecast = "Hot";
}
else if (degrees >= 20.1 && degrees <= 25.9)
{
    forecast = "Warm";
}
else if (degrees >= 15.00 && degrees <= 20.00)
{
    forecast = "Mild";
}
else if (degrees >= 12.00 && degrees <= 14.9)
{
    forecast = "Cool";
}
else if (degrees >= 5.00 && degrees <= 11.9)
{
    forecast = "Cold";
}
else
{
    forecast = "unknown";
}

Console.WriteLine(forecast);


