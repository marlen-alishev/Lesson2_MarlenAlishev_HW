// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int f(int x)
{
    int result = (x/10)%10;
    return result; 
}
Console.Write("Please insert three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Here is the second digit: {f(n)}");