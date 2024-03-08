// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// string GetNumbersInRange(int M, int N)
// {
//     if (M == N)
//     {
//         return M.ToString();
//     }
//     else
//     {
//         return M + ", " + GetNumbersInRange(M + 1, N);
//     }
// }

// System.Console.WriteLine("Введите значение M:");
// int M = int.Parse(System.Console.ReadLine()!);

// System.Console.WriteLine("Введите значение N:");
// int N = int.Parse(System.Console.ReadLine()!);

// Console.WriteLine(GetNumbersInRange(M, N));


// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// Пример:
// m = 2, n = 3 -> A(m, n) = 29

// int Ackermann(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0)
//     {
//         return Ackermann(n - 1, 1);
//     }
//     else
//     {
//         return Ackermann(n - 1, Ackermann(n, m - 1));
//     }
// }

// System.Console.WriteLine("Введите значение n:");
// int n = int.Parse(System.Console.ReadLine()!);

// System.Console.WriteLine("Введите значение m:");
// int m = int.Parse(System.Console.ReadLine()!);

// Console.WriteLine($"A({n}, {m}) = {Ackermann(n, m)}");

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

// void PrintArrayReversed(int[] array, int index)
// {
//     if (index >= 0)
//     {
//         Console.Write(array[index] + " ");
//         PrintArrayReversed(array, index - 1);
//     }
// }

// int[] array = { 1, 2, 3, 0, 8, 34 };
// PrintArrayReversed(array, array.Length - 1);