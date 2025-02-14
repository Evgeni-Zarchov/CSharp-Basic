int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toysPrice = int.Parse(Console.ReadLine());


double totalToyPrice = 0;
double savedMoney = 0;
int giftedMoney = 10;


for (int i = 1; i <= age; i++)
{


    if (i % 2 != 0)
    {
        savedMoney += toysPrice;
    }
    else
    {
        savedMoney += giftedMoney - 1;

        giftedMoney += 10;
    }

}

if (savedMoney >= washingMachinePrice)
{
    Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:f2}");
}
else
{
    Console.WriteLine($"No! {Math.Abs(savedMoney - washingMachinePrice):f2}");
}

