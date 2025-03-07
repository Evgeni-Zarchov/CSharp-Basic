int end = int.Parse(Console.ReadLine());
int counter = 0;
for (int x1 = 0; x1 <= end; x1++)
{
    for (int x2 = 0; x2 <= end; x2++)
    {
        for (int x3 = 0; x3 <= end; x3++)
        {
            if (x1 + x2 + x3 == end)
            {
                counter++;
            }
        }
    }

}
Console.WriteLine(counter);
