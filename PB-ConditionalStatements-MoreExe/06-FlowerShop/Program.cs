int magnoliasCount = int.Parse(Console.ReadLine());
int hyacinthsCount = int.Parse(Console.ReadLine());
int rosesCount = int.Parse(Console.ReadLine());
int cactusCount = int.Parse(Console.ReadLine());
double giftPrice = double.Parse(Console.ReadLine());

double magnoliasPrice = 3.25 * magnoliasCount;
double hyacinthsPrice = 4.00 * hyacinthsCount;
double rosesPrice = 3.50 * rosesCount;
double cactusPrice = 8.00 * cactusCount;

double finalSum = magnoliasPrice + hyacinthsPrice + rosesPrice + cactusPrice;

finalSum *= 0.95;
double totalSum = Math.Abs(finalSum - giftPrice);
if (finalSum < giftPrice)
{
    ;
    Console.WriteLine($"She will have to borrow {Math.Ceiling(totalSum)} leva.");
}
else
{

    Console.WriteLine($"She is left with {Math.Floor(totalSum)} leva.");
}