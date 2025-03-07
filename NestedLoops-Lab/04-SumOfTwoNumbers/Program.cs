int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int magic = 0;
for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        magic++;
        if (i + j == magicNumber)
        {
            Console.WriteLine($"Combination N:{magic} ({i} + {j} = {i + j})");
            return;
        }
    }
}

Console.WriteLine($"{magic} combinations - neither equals {magicNumber}");