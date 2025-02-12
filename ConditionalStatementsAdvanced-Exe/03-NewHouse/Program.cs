// Flowers price.

double rosesPrice = 5;
double dahliasPrice = 3.80;
double tulipsPrice = 2.80;
double narcissusPrice = 3.00;
double gladiolusPrice = 2.50;

//Input.
string flowersType = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
double budged = double.Parse(Console.ReadLine());



double currentPrice = 0;

switch (flowersType)
{
    case "Roses":
        currentPrice = rosesPrice;
        break;
    case "Dahlias":
        currentPrice = dahliasPrice;
        break;
    case "Tulips":
        currentPrice = tulipsPrice;
        break;
    case "Narcissus":
        currentPrice = narcissusPrice;
        break;
    case "Gladiolus":
        currentPrice = gladiolusPrice;
        break;
}

double totalPrice = currentPrice * flowersCount;
// "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
if (flowersCount > 80 && flowersType == "Roses")
{
    totalPrice = totalPrice - (totalPrice * 0.10);
}
else if (flowersCount > 90 && flowersType == "Dahlias")
{
    totalPrice = totalPrice - (totalPrice * 0.15);
}
else if (flowersCount > 80 && flowersType == "Tulips")
{
    totalPrice = totalPrice - (totalPrice * 0.15);
}
else if (flowersCount < 120 && flowersType == "Narcissus")
{
    totalPrice = totalPrice * 1.15;
}
else if (flowersCount < 80 && flowersType == "Gladiolus")
{
    totalPrice = totalPrice * 1.20;
}


if (budged >= totalPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budged - totalPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {Math.Abs(totalPrice - budged):f2} leva more.");
}
