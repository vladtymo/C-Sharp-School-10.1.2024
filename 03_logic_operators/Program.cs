// logic operators: > < >= <= == !=
// condition combine: && (і) || (або)

Console.Write("Hours: ");
int hours = int.Parse(Console.ReadLine()!);

if (hours >= 0 && hours <= 23)
{
    Console.WriteLine("Right!");
}
else
{
    Console.WriteLine("Wrong!");
}

Console.Write("Year: ");
int year = int.Parse(Console.ReadLine()!);

// якщо блок має лише одну інструкцію, то фігурні дужки {} можна опустити
if (year % 4 == 0)
    Console.WriteLine("Leap year!");

Console.Write("Your number: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0 || number == 777)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Your number is lucky!");
}