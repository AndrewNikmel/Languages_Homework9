


// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.


// string DecIntoBin(int i){
//     return (i > 0) ? DecIntoBin(i / 2) + (i % 2).ToString() : "";
// }

// Console.WriteLine("Enter the number: ");
// int i = Convert.ToInt32(Console.ReadLine());
// string res = DecIntoBin(i);
// Console.Write(res);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int SumNumbersMN(int [] array, int i){
    i = 0;
    if(i >= array.GetLength(0)) return 0;
    // int result = SumNumbersMN(array, i + 1);
    return array[i]+SumNumbersMN(array, i + 1);
}

Console.WriteLine("Enter the first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int n = Convert.ToInt32(Console.ReadLine());
int size = n - m;
int i = 0;
if(size<0) size = size * (-1);
int[] array = CreateArray(size, m, n);
int result = SumNumbersMN(array, i);
Console.WriteLine(result);