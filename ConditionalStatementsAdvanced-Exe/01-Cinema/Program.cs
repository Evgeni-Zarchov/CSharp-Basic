//01.Consts,tickets price.
double premiere = 12.00;
double normal = 7.50;
double discount = 5.00;

// 02.Input.
string projectionType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cows = int.Parse(Console.ReadLine());

double currentPrice = 0;

if (projectionType == "Premiere")
{
    currentPrice = premiere;
}
else if (projectionType == "Normal")
{
    currentPrice = normal;
}
else if (projectionType == "Discount")
{
    currentPrice = discount;
}

double seats = rows * cows;
double totalPrice = currentPrice * seats;

Console.WriteLine($"{totalPrice:f2} leva");