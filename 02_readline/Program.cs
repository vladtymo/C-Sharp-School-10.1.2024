// -------------------- Введення в консоль --------------------
Console.WriteLine("Enter your nickname: ");

// створення змінної: тип ім'я = значення;

// типи даних:
// * short - ціле число / 2 bytes / 
// * int - ціле число / 4 bytes / 
// * long - ціле число / 8 bytes / 
// * double - дробове число
// * decimal - дробове число / 16
// * string - рядок

string login = Console.ReadLine();

Console.WriteLine($"Hello, dear {login}!");

// --------- Завдання ---------
// користувач вводить милі, а програма відображає це значення в кіломентрах

Console.Write("Enter miles: ");
int miles = int.Parse(Console.ReadLine());
 
// арифметичні оператори: + - * / % (остача від ділення)

Console.WriteLine($"Kilometers: {miles * 1.609344} km");

// -------------- приклад роботи операторів
Console.WriteLine($"10 + 5: {10 + 5}");
//...
Console.WriteLine($"10 % 5: {10 % 5}"); // 0
Console.WriteLine($"10 % 5: {10 % 3}"); // 1
Console.WriteLine($"10 % 5: {11 % 3}"); // 2