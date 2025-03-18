int n = int.Parse(Console.ReadLine());

double oddSum = 0;
double oddMin = double.MaxValue;
double oddMax = double.MinValue;
double evenSum = 0;
double evenMax = double.MinValue;
double evenMin = double.MaxValue;

for (int i = 1; i <= n; i++)
{
    double currentNumber = double.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        evenSum += currentNumber;

        if (evenMin >= currentNumber)
        {
            evenMin = currentNumber;

        }

        if (evenMax <= currentNumber)
        {
            evenMax = currentNumber;
        }
    }

    if (i % 2 != 0)
    {
        oddSum += currentNumber;

        if (oddMin >= currentNumber)
        {
            oddMin = currentNumber;
        }

        if (oddMax <= currentNumber)
        {
            oddMax = currentNumber;
        }
    }
}
Console.WriteLine($"OddSum={oddSum:f2},");

if (oddMin == 0 || oddMin == double.MaxValue)
{
    Console.WriteLine($"OddMin=No,");
}
else
{
    Console.WriteLine($"OddMin={oddMin:f2},");
}

if (oddMax == 0 || oddMax == double.MinValue)
{
    Console.WriteLine($"OddMax=No,");
}
else
{
    Console.WriteLine($"OddMax={oddMax:f2},");
}
Console.WriteLine($"EvenSum={evenSum:f2},");
if (evenMin == 0 || evenMin == double.MaxValue)
{
    Console.WriteLine($"EvenMin=No,");
}
else
{
    Console.WriteLine($"EvenMin={evenMin:f2},");
}

if (evenMax == 0 || evenMax == double.MinValue)
{
    Console.WriteLine($"EvenMax=No");
}
else
{
    Console.WriteLine($"EvenMax={evenMax:f2}");
}








