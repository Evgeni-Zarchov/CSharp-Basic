string season = Console.ReadLine();
string groupType = Console.ReadLine();
int studentsCount = int.Parse(Console.ReadLine());
int overnightStay = int.Parse(Console.ReadLine());

string sport = "";
double price = 0;

if (season == "Winter")
{
    if (groupType == "girls")
    {
        sport = "Gymnastics";
    }
    else if (groupType == "boys")
    {
        sport = "Judo";
    }
    else if (groupType == "mixed")
    {
        sport = "Ski";
    }
}
else if (season == "Spring")
{
    if (groupType == "girls")
    {
        sport = "Athletics";
    }
    else if (groupType == "boys")
    {
        sport = "Tennis";
    }
    else if (groupType == "mixed")
    {
        sport = "Cycling";
    }
}
else if (season == "Summer")
{
    if (groupType == "girls")
    {
        sport = "Volleyball";
    }
    else if (groupType == "boys")
    {
        sport = "Football";
    }
    else if (groupType == "mixed")
    {
        sport = "Swimming";
    }
}

if (groupType == "boys" || groupType == "girls")
{
    if (season == "Winter")
    {
        price = 9.60;
    }
    else if (season == "Spring")
    {
        price = 7.20;
    }
    else if (season == "Summer")
    {
        price = 15.00;
    }
}
else if (groupType == "mixed")
{
    if (season == "Winter")
    {
        price = 10.00;
    }
    else if (season == "Spring")
    {
        price = 9.50;
    }
    else if (season == "Summer")
    {
        price = 20.00;
    }
}

double totalPrice = studentsCount * price * overnightStay;

if (studentsCount >= 50)
{
    totalPrice = totalPrice - (totalPrice * 0.50);
}
else if (studentsCount >= 20 && studentsCount < 50)
{
    totalPrice *= 0.85;
}
else if (studentsCount >= 10 && studentsCount < 20)
{
    totalPrice *= 0.95;
}

Console.WriteLine($"{sport} {totalPrice:f2} lv.");