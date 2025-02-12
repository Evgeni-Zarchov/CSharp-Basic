int number = int.Parse(Console.ReadLine());
string output = "";

if (number >= -100 && number <= 100 && number != 0)
{
    output = "Yes";
}
else
{
    output = "No";
}


Console.WriteLine(output);