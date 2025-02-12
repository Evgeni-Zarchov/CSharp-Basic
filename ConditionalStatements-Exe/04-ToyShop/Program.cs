// Consts, price for the products.

double puzzlesPrice = 2.60;
double dollsPrice = 3.00;
double bearsPrice = 4.10;
double minionsPrice = 8.20;
double trucksPrice = 2.00;

// Input, the products counter.
double excursionPrice = double.Parse(Console.ReadLine());
double puzzlesCount = double.Parse(Console.ReadLine());
double dollsCount = double.Parse(Console.ReadLine());
double bearsCount = double.Parse(Console.ReadLine());
double minionsCount = double.Parse(Console.ReadLine());
double trucksCount = double.Parse(Console.ReadLine());

// Calculations
double toysCount = puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount;

double totalPrice = puzzlesCount * puzzlesPrice + dollsCount * dollsPrice + bearsCount * bearsPrice + minionsCount * minionsPrice + trucksCount * trucksPrice;


if (toysCount >= 50)
{
    totalPrice = totalPrice - (totalPrice * 0.25);
}

double rent = totalPrice * 0.10;

double currentPrice = totalPrice - rent;



if (currentPrice >= excursionPrice)
{
    Console.WriteLine($"Yes! {currentPrice - excursionPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {Math.Abs(currentPrice - excursionPrice):f2} lv needed.");
}

