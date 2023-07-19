// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Please enter your number from 1 to 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7) 
{
    Console.Write("Yahooo! Today is a day-off!");
}
else 
{
    Console.Write("Keep calm and work!");
}