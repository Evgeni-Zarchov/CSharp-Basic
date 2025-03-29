int yearlyTax = int.Parse(Console.ReadLine());
double basketballShoes = yearlyTax - (yearlyTax * 0.40);
double basketBallClothes = basketballShoes - (basketballShoes * 0.20);
double basketBall = basketBallClothes / 4;
double accesories = basketBall / 5;

double totalPrice = basketballShoes + basketBallClothes + basketBall + accesories + yearlyTax;

Console.WriteLine($"{totalPrice:f2}");
