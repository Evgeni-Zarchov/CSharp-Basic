string cityName = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());
double percent = 0;
if (cityName == "Sofia")
{
    if (sales > 10000)
    {
        percent = 0.12;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        percent = 0.08;
    }
    else if (sales > 500 && sales <= 1000)
    {
        percent = 0.07;
    }
    else if (sales > 0 && sales <= 500)
    {
        percent = 0.05;
    }
}
else if (cityName == "Varna")
{
    if (sales > 10000)
    {
        percent = 0.13;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        percent = 0.10;
    }
    else if (sales > 500 && sales <= 1000)
    {
        percent = 0.075;
    }
    else if (sales > 0 && sales <= 500)
    {
        percent = 0.045;
    }
}
else if (cityName == "Plovdiv")
{
    if (sales > 10000)
    {
        percent = 0.145;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        percent = 0.12;
    }
    else if (sales > 500 && sales <= 1000)
    {
        percent = 0.08;
    }
    else if (sales > 0 && sales <= 500)
    {
        percent = 0.055;
    }
}

if (percent == 0)
{
    Console.WriteLine("error");
}
else
{
    double totalSales = sales * percent;
    Console.WriteLine($"{totalSales:f2}");
}
