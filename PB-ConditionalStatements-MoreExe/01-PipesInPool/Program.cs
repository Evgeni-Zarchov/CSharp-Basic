int volume = int.Parse(Console.ReadLine());
int pipeOne = int.Parse(Console.ReadLine());
int pipeTwo = int.Parse(Console.ReadLine());
double hours = double.Parse(Console.ReadLine());

double p1 = pipeOne * hours;
double p2 = pipeTwo * hours;

double totalVolume = p1 + p2;

if (totalVolume <= volume)
{
    double p1Percent = (p1 / totalVolume) * 100;
    double p2Percent = (p2 / totalVolume) * 100;
    double poolVolume = (totalVolume / volume) * 100;

    Console.WriteLine($"The pool is {poolVolume:f2}% full. Pipe 1: {p1Percent:f2}%. Pipe 2: {p2Percent:f2}%.");

}
else
{
    double poolOverFlows = totalVolume - volume;
    Console.WriteLine($"For {hours} hours the pool overflows with {poolOverFlows:f2} liters.");
}