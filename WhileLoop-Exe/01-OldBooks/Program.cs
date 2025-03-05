string searchedBook = Console.ReadLine();
bool isFound = false;
int bookCounter = 0;

string currentBook = Console.ReadLine();

while (currentBook != "No More Books")
{

    if (currentBook == searchedBook)
    {
        isFound = true;
        break;
    }

    bookCounter++;

    currentBook = Console.ReadLine();
}

if (isFound)
{
    Console.WriteLine($"You checked {bookCounter} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {bookCounter} books.");
}

//string searchedBook = Console.ReadLine();
//int bookCounter = 0;

//string currentBook = Console.ReadLine();

//while(currentBook != "No More Books")
//{

//    if (currentBook == searchedBook)
//    {
//        Console.WriteLine($"You checked {bookCounter} books and found it.");
//        return;
//    }

//    bookCounter++;
//    currentBook = Console.ReadLine();
//}

//Console.WriteLine("The book you search is not here!");
//Console.WriteLine($"You checked {bookCounter} books.");