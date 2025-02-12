int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double currentVolume = length * width * height;
double volume = currentVolume / 1000;

double finalVolume = volume - ((volume * percent) / 100);
Console.WriteLine(finalVolume);

