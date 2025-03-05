int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int cake = width * length;
int totalPieces = 0;
string action = Console.ReadLine();
bool isEnough = true;
while (action != "STOP")
{
    int currentPieces = int.Parse(action);
    totalPieces += currentPieces;

    if (totalPieces > cake)
    {
        isEnough = false;
        break;
    }

    action = Console.ReadLine();
}

int cakeLeft = Math.Abs(totalPieces - cake);

if (isEnough)
{
    Console.WriteLine($"{cakeLeft} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {cakeLeft} pieces more.");
}