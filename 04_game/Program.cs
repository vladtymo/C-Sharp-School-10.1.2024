// Гра: користувач вводить число, а програма імітує підкидання грального кубика.
// Взалежності від комбінацій, нараховуються бали

var rand = new Random();
int score = 100;

while (true)
{
    Console.Write("Enter your rate (1-6): ");
    int rate = int.Parse(Console.ReadLine());

    Console.Clear();

    int randomNumber = rand.Next(1, 7);

    if (rate == randomNumber)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You won! +20");
        score += 20;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You loose! -5");
        score -= 5;
    }

    DrawDice(randomNumber);
    Console.ResetColor();

    Console.WriteLine($"Score: {score}");
}

static void DrawDice(int roll) 
{
    switch (roll)
    {
        case 1:
            Console.WriteLine("+-------+");
            Console.WriteLine("|       |");
            Console.WriteLine("|   o   |");
            Console.WriteLine("|       |");
            Console.WriteLine("+-------+");
            break;
        case 2:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o     |");
            Console.WriteLine("|       |");
            Console.WriteLine("|     o |");
            Console.WriteLine("+-------+");
            break;
        case 3:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o     |");
            Console.WriteLine("|   o   |");
            Console.WriteLine("|     o |");
            Console.WriteLine("+-------+");
            break;
        case 4:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o   o |");
            Console.WriteLine("|       |");
            Console.WriteLine("| o   o |");
            Console.WriteLine("+-------+");
            break;
        case 5:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o   o |");
            Console.WriteLine("|   o   |");
            Console.WriteLine("| o   o |");
            Console.WriteLine("+-------+");
            break;
        case 6:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o   o |");
            Console.WriteLine("| o   o |");
            Console.WriteLine("| o   o |");
            Console.WriteLine("+-------+");
            break;
    }
}