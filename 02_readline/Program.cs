// -------------------- Введення в консоль --------------------
Console.WriteLine("Enter your nickname: ");

// створення змінної: тип ім'я = значення;

// типи даних:
// * int - ціле число
// * double - дробове число
// * string - рядок

string login = Console.ReadLine();

Console.WriteLine($"Hello, dear {login}!");

// --------- Завдання ---------
// користувач вводить милі, а програма відображає це значення в кіломентрах

Console.Write("Enter miles: ");
int miles = int.Parse(Console.ReadLine());

// арифметичні оператори: + - * /

Console.WriteLine($"Kilometers: {miles * 1.609344} km");