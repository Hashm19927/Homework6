/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Введите значения через запятую, пробел или точку: ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(' ',',','.'), int.Parse);// изменение формата, чтобы выполнялось условие if
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
        count++;
}

string str = string.Join(" ", arr); //чтобы вывести в ответ строку и число положительных значений
Console.WriteLine($"{str}->{count}");
