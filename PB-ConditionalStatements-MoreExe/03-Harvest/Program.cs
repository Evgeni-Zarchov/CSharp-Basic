int vineyard = int.Parse(Console.ReadLine());
double grapes = double.Parse(Console.ReadLine());
int neededLitreWine = int.Parse(Console.ReadLine());
int workersCount = int.Parse(Console.ReadLine());
double grape = 2.5;

double currentWine = (vineyard * 0.40) * grapes;

double totalWine = currentWine / grape;

double wineLeft = Math.Abs(totalWine - neededLitreWine);

if (totalWine >= neededLitreWine)
{
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");

    Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / workersCount)} liters per person.");
}
else
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLeft)} liters wine needed.");
}
