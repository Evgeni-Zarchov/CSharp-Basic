int n = int.Parse(Console.ReadLine());
//int counter = 1;

//for (int rows = 1; rows <= n; rows++)
//{

//    for (int cols = 1; cols <= rows; cols++)
//    {
//        if (counter > n)
//        {
//            break;
//        }

//        Console.Write($"{counter} ");

//        counter++;
//    }

//    if (counter > n)
//    {
//        break;
//    }

//    Console.WriteLine();
//}

// Second way to do it with one for.

// The algorithm is.
// if rows and cols is equal we're going to the next row first col.
// The number of rows are also the numbers of cols.
// if rows 2 cols also is 1 so it looks like that.
// 1
// 2 3 and so on

int rows = 1;
int cols = 1;

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i} ");

    if (rows == cols)
    {
        rows++;
        cols = 1;

        Console.WriteLine();
    }
    else
    {
        cols++;
    }
}
