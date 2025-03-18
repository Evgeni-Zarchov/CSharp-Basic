int n = int.Parse(Console.ReadLine());

double numberOne = 0;
double numberTwo = 0;
double numberThree = 0;
double numberFour = 0;
double numberFive = 0;
double invalidNumber = 0;
double result = 0;
for (int i = 0; i < n; i++)
{
    double currentNumber = double.Parse(Console.ReadLine());


    if (currentNumber >= 0 && currentNumber <= 9)
    {
        result += (0.20 * currentNumber);
        numberOne++;
    }
    else if (currentNumber >= 10 && currentNumber <= 19)
    {
        result += (0.30 * currentNumber);
        numberTwo++;
    }
    else if (currentNumber >= 20 && currentNumber <= 29)
    {
        result += (0.40 * currentNumber);
        numberThree++;
    }
    else if (currentNumber >= 30 && currentNumber <= 39)
    {
        result += 50;
        numberFour++;
    }
    else if (currentNumber >= 40 && currentNumber <= 50)
    {
        result += 100;
        numberFive++;
    }


    if (currentNumber < 0 || currentNumber > 50)
    {
        result = result / 2;
        invalidNumber++;
    }
}

Console.WriteLine($"{result:f2}");
Console.WriteLine($"From 0 to 9: {(numberOne / n) * 100:f2}%");
Console.WriteLine($"From 10 to 19: {(numberTwo / n) * 100:f2}%");
Console.WriteLine($"From 20 to 29: {(numberThree / n) * 100:f2}%");
Console.WriteLine($"From 30 to 39: {(numberFour / n) * 100:f2}%");
Console.WriteLine($"From 40 to 50: {(numberFive / n) * 100:f2}%");
Console.WriteLine($"Invalid numbers: {(invalidNumber / n) * 100:f2}%");