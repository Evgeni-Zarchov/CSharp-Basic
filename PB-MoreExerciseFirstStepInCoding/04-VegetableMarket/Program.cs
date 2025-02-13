double euro = 1.94;

double veggyPrice = double.Parse(Console.ReadLine());
double fruitsPrice = double.Parse(Console.ReadLine());
int veggyKilo = int.Parse(Console.ReadLine());
int fruitsKilo = int.Parse(Console.ReadLine());

double veggyCost = veggyPrice * veggyKilo;
double fruitsCost = fruitsPrice * fruitsKilo;

double finalPrice = veggyCost + fruitsCost;

double priceIntoEuro = finalPrice / euro;

Console.WriteLine($"{priceIntoEuro:f2}");
