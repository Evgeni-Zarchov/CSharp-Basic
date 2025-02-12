int overNightStay = int.Parse(Console.ReadLine()) - 1;
string apartmentType = Console.ReadLine();
string rating = Console.ReadLine();

double price = 0;

switch (apartmentType)
{
    case "room for one person":
        price = 18.00;
        break;
    case "apartment":
        price = 25.00;
        break;
    case "president apartment":
        price = 35.00;
        break;
}

double totalPrice = price * overNightStay;

if (overNightStay <= 10)
{
    if (apartmentType == "apartment")
    {
        totalPrice = totalPrice - (totalPrice * 0.30);
    }
    else if (apartmentType == "president apartment")
    {
        totalPrice = totalPrice - (totalPrice * 0.10);
    }

}
else if (overNightStay > 10 && overNightStay <= 15)
{
    if (apartmentType == "apartment")
    {
        totalPrice = totalPrice - (totalPrice * 0.35);
    }
    else if (apartmentType == "president apartment")
    {
        totalPrice = totalPrice - (totalPrice * 0.15);
    }

}
else
{
    if (apartmentType == "apartment")
    {
        totalPrice = totalPrice - (totalPrice * 0.50);
    }
    else if (apartmentType == "president apartment")
    {
        totalPrice = totalPrice - (totalPrice * 0.20);
    }

}

if (rating != "positive")
{
    totalPrice = totalPrice - (totalPrice * 0.10);
}
else
{
    totalPrice *= 1.25;
}

Console.WriteLine($"{totalPrice:f2}");