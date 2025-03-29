double priceOfTennisRocket = double.Parse(Console.ReadLine());
int tennisRocketsCount = int.Parse(Console.ReadLine());
int shoesCount = int.Parse(Console.ReadLine());

double shoesPrice = (priceOfTennisRocket / 6) * shoesCount;
double rocketsPrice = priceOfTennisRocket * tennisRocketsCount;
double price = shoesPrice + rocketsPrice;
double percent = price * 0.20;

double totalPrice = price + percent;
double priceToBePaidByPlayer = totalPrice / 8;
double priceToBePaidBySponsors = (totalPrice * 7) / 8;
Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceToBePaidByPlayer):f0}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceToBePaidBySponsors):f0}");
