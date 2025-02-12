double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarianMenuPrice = 8.15;

double deliveryPrice = 2.50;

int chickenMenuCount = int.Parse(Console.ReadLine());
int fishMenuCount = int.Parse(Console.ReadLine());
int vegetarianMenuCount = int.Parse(Console.ReadLine());

double currentPrice = chickenMenuCount * chickenMenuPrice + fishMenuCount * fishMenuPrice + vegetarianMenuCount * vegetarianMenuPrice;

double dessertPrice = currentPrice * 0.20;

double finalPrice = currentPrice + dessertPrice + deliveryPrice;

Console.WriteLine(finalPrice);
