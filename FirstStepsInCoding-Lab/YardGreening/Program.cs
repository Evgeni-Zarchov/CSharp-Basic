double currentSquareMeters = double.Parse(Console.ReadLine());

double pricePerSquareMeters = currentSquareMeters * 7.61;

double discount = pricePerSquareMeters * 0.18;

Console.WriteLine($"The final price is: {pricePerSquareMeters - discount} lv.");

Console.WriteLine($"The discount is: {discount} lv.");
