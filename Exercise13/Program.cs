// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
void f(int x)
{
    if (x.ToString().Length >= 3)
    {
        string xIsString = x.ToString();
        List<int> list = new List<int>();
        foreach(char item in xIsString)
        {
            list.Add(Convert.ToInt32(item.ToString()));
        }
        //Console.WriteLine(list);
        int[] array = list.ToArray();
        //Console.WriteLine(array);
        Console.Write($"Here is the third digit: {array[2]}");
    }
    else
    {
        Console.Write("There is no third digit!"); 
    }
}
Console.Write("Please insert your number: ");
int n = Convert.ToInt32(Console.ReadLine());
f(n);
