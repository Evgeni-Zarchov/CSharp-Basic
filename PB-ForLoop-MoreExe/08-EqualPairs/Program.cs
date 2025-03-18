int n = int.Parse(Console.ReadLine());

int firstNum = 0;
int secondNum = 0;
double sum = 0;
for (int i = 1; i <= n; i++)
{
    int currentFirstNumber = int.Parse(Console.ReadLine());
    int currentSecondNumber = int.Parse(Console.ReadLine());


    if (i % 2 != 0)
    {
        secondNum = currentFirstNumber + currentSecondNumber;
        
    }
    else
    {
        firstNum = currentFirstNumber + currentSecondNumber;
    }

    if ((secondNum != firstNum) && (i > 1))
    {
        double diff = Math.Abs(firstNum - secondNum);
        
        if (sum <= diff)
        {
            sum = diff;
        }
    }
}

if (sum == 0)
{
    Console.WriteLine($"Yes, value={secondNum}");
}
else
{
    Console.WriteLine($"No, maxdiff={sum}");
}