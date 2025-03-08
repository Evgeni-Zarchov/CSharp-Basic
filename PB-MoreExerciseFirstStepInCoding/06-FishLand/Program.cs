// To determinate the price for the otherFishes.
double mackerelPricePerKg = double.Parse(Console.ReadLine());
double sprinklePricePerKg = double.Parse(Console.ReadLine());

// FishKilo
double bonitoKg = double.Parse(Console.ReadLine());
double safridKg = double.Parse(Console.ReadLine());
double mussleKg = double.Parse(Console.ReadLine());

// FishPrice
double bonitoPrice = mackerelPricePerKg + (mackerelPricePerKg * 0.60);
double safridPrice = sprinklePricePerKg + (sprinklePricePerKg * 0.80);

double totalBonitoPrice = bonitoPrice * bonitoKg;
double totalSafridPrice = safridPrice * safridKg;
double totalMusslePrice = mussleKg * 7.50;

double totalSum = totalBonitoPrice + totalSafridPrice + totalMusslePrice;
Console.WriteLine($"{totalSum:f2}");
