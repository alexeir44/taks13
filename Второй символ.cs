// Инициализация переменных
string? UserNumber;
int number;

//начало программы
Console.WriteLine("Введи число");
UserNumber = Console.ReadLine();

if (int.TryParse(UserNumber, out number))
    Console.Write("Второй символ числа - " + UserNumber[1]);
else
    Console.Write("Ошибка ввода");