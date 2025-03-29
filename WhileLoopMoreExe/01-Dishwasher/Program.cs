int chemical = int.Parse(Console.ReadLine()) * 750;
int dishes = 0;
int pots = 0;
int counter = 1;
string command = Console.ReadLine();

while (command != "End" && chemical >= 0)
{
    int currentDishes = int.Parse(command);


    if (counter == 3)
    {
        pots += currentDishes;
        chemical = chemical - currentDishes * 15;
        counter = 0;
    }
    else
    {
        dishes += currentDishes;
        chemical = chemical - currentDishes * 5;

    }

    if (chemical < 0)
    {
        Console.WriteLine($"Not enough detergent, {Math.Abs(chemical)} ml. more necessary!");
        return;
    }

    counter++;
    command = Console.ReadLine();

}

if (chemical >= 0)
{
    Console.WriteLine("Detergent was enough!");
    Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
    Console.WriteLine($"Leftover detergent {chemical} ml.");
}