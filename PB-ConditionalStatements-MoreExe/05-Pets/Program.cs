int daysCount = int.Parse(Console.ReadLine());
int leftFood = int.Parse(Console.ReadLine());

double foodForDog = double.Parse(Console.ReadLine());
double foodForCat = double.Parse(Console.ReadLine());
double foodForTurtle = double.Parse(Console.ReadLine()) / 1000;

double foodPerDayDog = foodForDog * daysCount;
double foodPerDayCat = foodForCat * daysCount;
double foodPerDayTurtple = foodForTurtle * daysCount;

double totalFood = foodPerDayDog + foodPerDayCat + foodPerDayTurtple;

double finalFoodSum = Math.Abs(totalFood - leftFood);
if (totalFood <= leftFood)
{
    Console.WriteLine($"{Math.Floor(finalFoodSum)} kilos of food left.");
}
else
{

}
{
    Console.WriteLine($"{Math.Ceiling(finalFoodSum)} more kilos of food are needed.");
}

