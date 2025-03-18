
double inheritanceMoney = double.Parse(Console.ReadLine());
int pastYear = int.Parse(Console.ReadLine());

int yearOld = 18;
double moneySpent = 0;

for (int i = 1800; i <= pastYear; i++)
{

    if (i % 2 == 0)
    {
        inheritanceMoney = inheritanceMoney - 12000;
    }
    else
    {

        inheritanceMoney = inheritanceMoney - (12000 + (yearOld * 50));

    }

    yearOld++;
}

if (inheritanceMoney >= moneySpent)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {inheritanceMoney:f2} dollars left.");


}
else
{
    Console.WriteLine($"He will need {Math.Abs(inheritanceMoney)}:f2 dollars to survive.");
}
