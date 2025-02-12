double depositedSum = double.Parse(Console.ReadLine());
int depositTerm = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double finalResult = depositedSum + depositTerm * ((depositedSum * annualInterestRate * 0.01) / 12);
Console.WriteLine(finalResult);
