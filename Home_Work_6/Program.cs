

//Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

/*
int[] ManualInputArray(int m)
{
    int[] Array = new int[m];
    for(int i=0; i < m; i++)
    {
        Console.Write("Введите элемент массива под индексом "  + i + " --> ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Array;
}

void NumberOfPositiveNumbers(int[] Array)
{
    int count = 0;
    for(int i=0; i < Array.Length; i++)
    {
        if(Array[i] > 0)    
        count++;
    }

    Console.WriteLine("Количество положительных чисел " + count);
}   


Console.Write("Введите количество чисел М : ");
int M = Convert.ToInt32(Console.ReadLine());
int[] myArray = ManualInputArray(M);
NumberOfPositiveNumbers(myArray);

*/




//Задача 2: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное.

//45 -> 101101

//3 -> 11

//2 -> 10

/*
void NumberConversion(int decine)
{
  
    string result = string.Empty; // Создание пустой строки.
    int remainder; // остаток от деления

    for(int i = 0; decine > 0; i++)
    {
        remainder = decine % 2;
        decine = decine/2;
        result = remainder + result;
        
    }
    Console.WriteLine(result);
}    
NumberConversion(45);

*/





//Задача 3: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// double y1 = k1 * x + b1;
// double y2 = k2 * x + b2;


void IntersectionPoint(double b1, double b2, double k1, double k2)
{
    // double b1=2;
    // double b2=4;
    // double k1=5;
    // double k2=9;
    double x=(b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine("X "+x);
    Console.WriteLine("Y1 "+y);
}
IntersectionPoint(2,4,5,9);









//СЕМИНАР



//Задайте двумерный массив размера m на n, каждый элемент в массиве 
//находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

//Задача 3.
//Задайте двумерный массив. Найдите сумму элементов, находящихся на 
//главной диагонали (с индексами (0,0); (1;1) и т.д.







