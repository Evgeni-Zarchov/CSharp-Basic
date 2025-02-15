double height = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());

height *= 100;
width *= 100;

double h = Math.Floor(height / 120);
double w = Math.Floor((width - 100) / 70);


double finalResult = (w * h) - 3;

Console.WriteLine(finalResult);

