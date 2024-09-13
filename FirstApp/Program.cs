// це є коментар

// WriteLine - переносить вкінці текст на новий рядок
// Write - не переносить текст на новий рядок

// скорочення: cw + Tab = Console.WriteLine();

Console.WriteLine("Hello, World!");

Console.WriteLine("My name is Vlad!");

Console.Write("Red");
Console.Write("Green");
Console.Write("Blue");

// спец символи: \t \n \' \"

Console.Write("\n\nHello\tTab1\t\tTab2\n");
Console.WriteLine("We are studing \"C#\"");

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Glory to Ukraine!");

Console.ResetColor();

// для показу кирилиці
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Привіт Україно!");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Гарного дня!");