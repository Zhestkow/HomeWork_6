// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3




using static System.Console;
Clear();

WriteLine("введите длину массива: ");
int M = int.Parse(ReadLine()!);
int[] array = GetArray(M);
int res=0;
for (int i = 0; i < M; i++)
{
    if (array[i]>0)
    {
        res = res +1;
    }
}
WriteLine($"[{String.Join(", ", array)}]-> количество чисел больше 0 = {res}");




int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        WriteLine($"Введите {i+1} числo: ");
        int num = int.Parse(ReadLine()!);
        result[i] = num;
    }
    return result;
}


