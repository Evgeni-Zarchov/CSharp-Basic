double movieBudged = double.Parse(Console.ReadLine());
int extrasCount = int.Parse(Console.ReadLine());
double priceForClotherPerExtras = double.Parse(Console.ReadLine());

double clothesPrice = extrasCount * priceForClotherPerExtras;
double decor = movieBudged * 0.10;

if (extrasCount > 150)
{
    clothesPrice = clothesPrice - (clothesPrice * 0.10);
}

double finalPrice = clothesPrice + decor;

if (movieBudged >= finalPrice)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {movieBudged - finalPrice:f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {Math.Abs(movieBudged - finalPrice):f2} leva more.");

}