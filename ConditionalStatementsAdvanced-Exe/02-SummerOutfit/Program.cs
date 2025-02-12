// Shirts
string sweatshirt = "Sweatshirt";
string shirt = "Shirt";
string tShirt = "T-Shirt";
string swimSuit = "Swim Suit";

//shoes
string sneakers = "Sneakers";
string sandals = "Sandals";
string barefoot = "Barefoot";
string moccasins = "Moccasins";

//01.Input.
int degrees = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();

string outfit = "";
string shoes = "";

if (degrees <= 18)
{
    if (timeOfDay == "Morning")
    {
        outfit = sweatshirt;
        shoes = sneakers;
    }
    else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
    {
        outfit = shirt;
        shoes = moccasins;
    }
}
else if (degrees <= 24)
{
    if (timeOfDay == "Morning" || timeOfDay == "Evening")
    {
        outfit = shirt;
        shoes = moccasins;
    }
    else if (timeOfDay == "Afternoon")
    {
        outfit = tShirt;
        shoes = sandals;
    }
}
else
{
    if (timeOfDay == "Morning")
    {
        outfit = tShirt;
        shoes = sandals;
    }
    else if (timeOfDay == "Afternoon")
    {
        outfit = swimSuit;
        shoes = barefoot;
    }
    else if (timeOfDay == "Evening")
    {
        outfit = shirt;
        shoes = moccasins;
    }

}

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");