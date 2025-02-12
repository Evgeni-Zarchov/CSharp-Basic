string month = Console.ReadLine();
int overNightStay = int.Parse(Console.ReadLine());
double apartmentPricePerNight = 0;
double studioPrizePerNight = 0;

if (month == "May" || month == "October")
{
    studioPrizePerNight = 50;
    apartmentPricePerNight = 65;

    if (overNightStay > 7 && overNightStay <= 14)
    {
        studioPrizePerNight *= 0.95;


    }
    else if (overNightStay > 14)
    {
        studioPrizePerNight *= 0.70;
    }
}
else if (month == "June" || month == "September")
{
    studioPrizePerNight = 75.20;
    apartmentPricePerNight = 68.70;

    if (overNightStay > 14)
    {
        studioPrizePerNight *= 0.80;
    }
}
else if (month == "July" || month == "August")
{
    studioPrizePerNight = 76;
    apartmentPricePerNight = 77;
}


if (overNightStay > 14)
{

    apartmentPricePerNight *= 0.90;

}

Console.WriteLine($"Apartment: {apartmentPricePerNight * overNightStay:f2} lv.");
Console.WriteLine($"Studio: {studioPrizePerNight * overNightStay:f2} lv.");
