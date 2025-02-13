int number = int.Parse(Console.ReadLine());
int pow = 1;

for (int i = 0; i <= number; i += 2)
{

    Console.WriteLine(pow);

    pow *= 4;
}

