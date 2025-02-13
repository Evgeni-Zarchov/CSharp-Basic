string text = Console.ReadLine();

int sum = 0;

for (int i = 0; i < text.Length; i++)
{
    char script = text[i];

    int points = 0;
    switch (script)
    {
        case 'a':
            points = 1;
            break;
        case 'e':
            points = 2;
            break;
        case 'i':
            points = 3;
            break;
        case 'o':
            points = 4;
            break;
        case 'u':
            points = 5;
            break;
    }

    sum += points;
}

Console.WriteLine(sum);
