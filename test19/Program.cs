// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000) 
{
bool IsPalindrome (int num)
    {
        int dig1 = (num % 100000) / 10000;
        int dig2 = (num % 10000) / 1000;
        int dig4 = (num % 100) / 10;
        int dig5 = num % 10;
        return dig1 == dig5 && dig2 == dig4;
    }
    if (IsPalindrome(number)) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
}
else Console.WriteLine("Введено некорректное значение");

