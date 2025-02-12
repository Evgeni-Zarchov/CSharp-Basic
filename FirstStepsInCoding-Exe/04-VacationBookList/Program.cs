int pagesCount = int.Parse(Console.ReadLine());
int pages = int.Parse(Console.ReadLine());
int daysCount = int.Parse(Console.ReadLine());

int pagesPerHour = pagesCount / pages;
int neededTime = pagesPerHour / daysCount;

Console.WriteLine(neededTime);
