int annualTax = int.Parse(Console.ReadLine());

double basketballShoes = annualTax - (annualTax * 0.4);
double basketballClothes = basketballShoes - (basketballShoes * 0.2);
double ball = basketballClothes / 4;
double accessories = ball / 5;

double finalExpenses = annualTax + basketballShoes + basketballClothes + ball + accessories;

Console.WriteLine(finalExpenses);