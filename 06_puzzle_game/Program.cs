int zeroY = 2;
int zeroX = 1;

int[,] puzzle = new int[4, 4]
{
    { 4, 10, 9, 1 },
    { 3, 2, 15, 5 },
    { 8, 0, 7, 11 },
    { 6, 12, 14, 13 }
};
PrintPuzzle();

while (true)
{
    var key = Console.ReadKey().Key;

    switch (key)
    {
        case ConsoleKey.LeftArrow:
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX + 1]);
            ++zeroX;
            break;
        case ConsoleKey.RightArrow:
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX - 1]);
            --zeroX;
            break;
    }

    Console.Clear();
    PrintPuzzle();
}

void PrintPuzzle()
{
    for (int r = 0; r < 4; r++)
    {
        for (int c = 0; c < 4; c++)
        {
            if (puzzle[r, c] == 0)
                Console.Write("[  ] ");
            else
                Console.Write($"[{puzzle[r, c], 2}] ");
        }
        Console.WriteLine();
    }
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}