// Consts
int gpusPrice = 250;

// Input
double budged = double.Parse(Console.ReadLine());
int gpusCount = int.Parse(Console.ReadLine());
int cpusCount = int.Parse(Console.ReadLine());
int ramsCount = int.Parse(Console.ReadLine());


// Calculations
int gpusFinalPrice = gpusCount * gpusPrice;
double processorsPrice = cpusCount * (gpusFinalPrice * 0.35);
double ramsPrice = ramsCount * (gpusFinalPrice * 0.10);
double finalSum = gpusFinalPrice + processorsPrice + ramsPrice;

if (gpusCount > cpusCount)
{
    finalSum = finalSum - (finalSum * 0.15);
}

if (budged >= finalSum)
{
    Console.WriteLine($"You have {budged - finalSum:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(finalSum - budged):f2} leva more!");
}



