double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5.00;
double nylonBags = 0.40;

int nylonQuantity = int.Parse(Console.ReadLine());
int paintQuantity = int.Parse(Console.ReadLine());
int thinnerQuantity = int.Parse(Console.ReadLine());
int workingHours = int.Parse(Console.ReadLine());

double morePaint = paintQuantity * 1.10;
double moreNylon = nylonQuantity + 2.00;

double currentPrice = moreNylon * nylonPrice + morePaint * paintPrice + thinnerQuantity * thinnerPrice + nylonBags;

double moneyForTheWorkers = currentPrice * 0.30;

double workersFinalMoney = moneyForTheWorkers * workingHours;

double finalPrice = currentPrice + workersFinalMoney;

Console.WriteLine(finalPrice);
