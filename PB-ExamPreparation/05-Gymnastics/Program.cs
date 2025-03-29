string country = Console.ReadLine();
string tehnique = Console.ReadLine();

double pointsRequired = 0;
double practicePoints = 0;
double maxPoints = 0;

if (country == "Russia")
{
    if (tehnique == "ribbon")
    {
        pointsRequired = 9.100;
        practicePoints = 9.400;
    }
    else if (tehnique == "hoop")
    {
        pointsRequired = 9.300;
        practicePoints = 9.800;
    }
    else if (tehnique == "rope")
    {
        pointsRequired = 9.600;
        practicePoints = 9.000;
    }
}
else if (country == "Bulgaria")
{
    if (tehnique == "ribbon")
    {
        pointsRequired = 9.600;
        practicePoints = 9.400;
    }
    else if (tehnique == "hoop")
    {
        pointsRequired = 9.550;
        practicePoints = 9.750;
    }
    else if (tehnique == "rope")
    {
        pointsRequired = 9.500;
        practicePoints = 9.400;
    }
}
else if (country == "Italy")
{
    if (tehnique == "ribbon")
    {
        pointsRequired = 9.200;
        practicePoints = 9.500;
    }
    else if (tehnique == "hoop")
    {
        pointsRequired = 9.450;
        practicePoints = 9.350;
    }
    else if (tehnique == "rope")
    {
        pointsRequired = 9.700;
        practicePoints = 9.150;
    }
}

maxPoints = pointsRequired + practicePoints;

double diff = 20 - maxPoints;
diff = (diff / 20) * 100;
Console.WriteLine($"The team of {country} get {maxPoints:f3} on {tehnique}.");

Console.WriteLine($"{diff:f2}%");

