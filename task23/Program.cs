/* Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
= Console.ReadLine();
Console.WriteLine("Введите число");
*/

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int Squares = 1;
while (Squares <= Number)
{
        Console.WriteLine(Squares *Squares * Squares + "");
        Squares++;
}
{
    int result = 0;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine();
    Console.ResetColor();
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}