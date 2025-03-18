int months = int.Parse(Console.ReadLine());

double waterBill = 20;
double internetBill = 15;
double electricityBill = 0;

for (int i = 1; i <= months; i++)
{
    double everyMonthElectricityBill = double.Parse(Console.ReadLine());
    electricityBill += everyMonthElectricityBill;
}

double totalWater = waterBill * months;
double totalInternet = internetBill * months;
double totalBill = totalWater + totalInternet + electricityBill;
totalBill *= 1.20;
double average = electricityBill + totalInternet + totalWater + totalBill;

Console.WriteLine($"Electricity: {electricityBill:f2} lv");
Console.WriteLine($"Water: {totalWater:f2} lv");
Console.WriteLine($"Internet: {totalInternet:f2} lv");
Console.WriteLine($"Other: {totalBill:f2} lv");
Console.WriteLine($"Average: {average / months:f2} lv");


