string username = Console.ReadLine();
string password = Console.ReadLine();

string input = Console.ReadLine();

while (input != password)
{
    input = Console.ReadLine();
}

Console.WriteLine($"Welcome {username}!");

// Experiment with for loop to prove that for loop can work as while.
// Is not good practice to use for as while, but for the experiment it will do the work.

for (; ; )
{
    if (input == password)
    {
        break;
    }
    input = Console.ReadLine();
}

Console.WriteLine($"Welcome {username}!");