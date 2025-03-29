int[] firstMatch = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
int[] secondMatch = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
int[] thirdMatch = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
int winnCount = 0;
int loseCount = 0;
int drawCount = 0;

if (firstMatch[0] > firstMatch[1])
{
    winnCount++;
}
if (secondMatch[0] > secondMatch[1])
{
    winnCount++;
}
if (thirdMatch[0] > thirdMatch[1])
{
    winnCount++;
}
if (firstMatch[0] < firstMatch[1])
{
    loseCount++;
}
if (secondMatch[0] < secondMatch[1])
{
    loseCount++;
}
if (thirdMatch[0] < thirdMatch[1])
{
    loseCount++;
}
if (firstMatch[0] == firstMatch[1])
{
    drawCount++;
}
if (secondMatch[0] == secondMatch[1])
{
    drawCount++;
}
if (thirdMatch[0] == thirdMatch[1])
{
    drawCount++;
}

Console.WriteLine($"Team won {winnCount} games.");
Console.WriteLine($"Team lost {loseCount} games.");
Console.WriteLine($"Drawn games: {drawCount}");