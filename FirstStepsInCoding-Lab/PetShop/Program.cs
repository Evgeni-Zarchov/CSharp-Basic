int dogFoodCount = int.Parse(Console.ReadLine());
int catFoodCount = int.Parse(Console.ReadLine());

double priceForDogFood = 2.50;
double priceForCatFood = 4.00;

double totalPrice = dogFoodCount * priceForDogFood + catFoodCount * priceForCatFood;

Console.WriteLine($"{totalPrice} lv.");
