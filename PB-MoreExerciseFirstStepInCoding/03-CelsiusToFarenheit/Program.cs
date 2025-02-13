double celsium = double.Parse(Console.ReadLine());

double fahrenheit = (celsium * 9 / 5) + 32;

double finalResult = fahrenheit - 32 * (5 / 9);

Console.WriteLine($"{finalResult:f2}");