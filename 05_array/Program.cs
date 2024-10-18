// Робота з масивами

int price1 = 1200;
int price2 = 45;
int price3 = 3400;
int price4 = 99;

Console.WriteLine(price1 + price2 + price3 + price4);

int[] prices = {3, 5, 1200, 99, 456 };

prices[2] = 1350;
Console.WriteLine(prices[2]);

for (int i = 0; i < 5; ++i)
{
    Console.Write(prices[i] + " ");
}

int[,] map = new int[3, 4]
{
    { 1, 2, 3, 4 },
    { 3, 9, 0, 1 },
    { 1, 2, 3, 2 }
};

Console.WriteLine(map[0, 0]); // 1
Console.WriteLine(map[0, 3]); // 4

Console.WriteLine("\n------ Matrix ------");
for (int r = 0; r < 3; r++)
{
    for (int c = 0; c < 4; c++)
    {
        Console.Write(map[r, c] + " ");
    }
    Console.WriteLine();
}