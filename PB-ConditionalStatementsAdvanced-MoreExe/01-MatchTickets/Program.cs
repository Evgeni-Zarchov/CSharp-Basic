double budged = double.Parse(Console.ReadLine());
string ticketType = Console.ReadLine();
int groupPeoples = int.Parse(Console.ReadLine());

if (groupPeoples >= 1 && groupPeoples <= 4)
{
    budged = budged - (budged * 0.75);
}
else if (groupPeoples >= 5 && groupPeoples < 9)
{
    budged = budged - (budged * 0.60);
}
else if (groupPeoples >= 10 && groupPeoples < 24)
{
    budged = budged - (budged * 0.50);
}
else if (groupPeoples >= 25 && groupPeoples <= 49)
{
    budged = budged - (budged * 0.40);
}
else
{
    budged = budged - (budged * 0.25);
}

double ticketPrice = 0;

if (ticketType == "Normal")
{
    ticketPrice = 249.99;
}
else if (ticketType == "VIP")
{
    ticketPrice = 499.99;
}

ticketPrice *= groupPeoples;

double totalPrice = Math.Abs(ticketPrice - budged);
if (ticketPrice <= budged)
{
    Console.WriteLine($"Yes! You have {totalPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {totalPrice:f2} leva.");
}