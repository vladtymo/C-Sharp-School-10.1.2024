using System.Diagnostics;

internal class Program
{
    const int width = 40;
    const int height = 20;
        
    static int X = width / 2;
    static int Y = height / 2;

    static int speed = 500;
    private static string direction = "right"; // left up down right
    
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        
        PrintMap();
        PrintSnake();

        var moveTimer = new Stopwatch();
        moveTimer.Start();
        
        while (true)
        {
            ChangeDirection();
            
            if (moveTimer.ElapsedMilliseconds >= speed)
            {
                MoveSnake();
                moveTimer.Restart();
            }
        }

        Console.ReadKey();
    }
    static void PrintMap()
    {
        Console.Write("\u2554");
        for (int i = 0; i < width; i++)
        {
            Console.Write("\u2550");
        }

        Console.WriteLine("\u2557");
        
        for (int i = 0; i < height; i++)
        {
            Console.CursorLeft = 0;
            Console.Write("\u2551");
            Console.CursorLeft = width + 1;
            Console.WriteLine("\u2551");
        }
        
        Console.Write("\u255A");
        for (int i = 0; i < width; i++)
        {
            Console.Write("\u2550");
        }
        Console.WriteLine("\u255D");
    }

    static void ChangeDirection()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = "left";
                    break;
                case ConsoleKey.RightArrow:
                    direction = "right";
                    break;
                case ConsoleKey.UpArrow:
                    direction = "up";
                    break;
                case ConsoleKey.DownArrow:
                    direction = "down";
                    break;
            }
        }
    }
    
    static void MoveSnake()
    {
        ClearSnake();
        
        switch (direction)
        {
            case "right": 
                ++X;
                break;
            case "left": 
                --X;
                break;
            case "up": 
                --Y;
                break;
            case "down": 
                ++Y;
                break;
        }

        PrintSnake();
    }
    static void PrintSnake()
    {
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\u25C9");
        Console.ResetColor();
    }
    static void ClearSnake()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(" ");
    }
}



