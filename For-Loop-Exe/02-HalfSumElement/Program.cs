int n = int.Parse(Console.ReadLine());

int maxNumber = int.MinValue;
int sum = 0;
for (int i = 0; i < n; i++)
{
    int currentNumbers = int.Parse(Console.ReadLine());
    sum += currentNumbers;

    if (currentNumbers > maxNumber)
    {
        maxNumber = currentNumbers;
    }
}

int sumWithoutMax = sum - maxNumber;

if (maxNumber == sumWithoutMax)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxNumber}");
}
else
{
    int difference = Math.Abs(maxNumber - sumWithoutMax);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}

