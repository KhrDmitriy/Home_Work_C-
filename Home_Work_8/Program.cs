
// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int[,] newArray =  //Создание и заполнение массива.
{ 
    {1, 4, 7, 2}, 
    {5, 9, 2, 3}, 
    {8, 4, 2, 4},
    {5, 2, 6, 7} 
};

int[,] SortBubbleTwoDementionalArray(int[,] arr)
{
    Console.WriteLine("Отсортированный массив:");

    for(int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for(int col = 0; col < arr.GetLength(1)-1; col++)
        {    
            for(int j = 0; j < arr.GetLength(1)-1; j++)
            {
                int temp = j;
                if(arr[rows,j] > arr[rows, j+1])
                {
                    temp = arr[rows, j];
                    arr[rows, j] = arr[rows, j+1];
                    arr[rows, j+1] = temp;
                }
            }
        }
    }
    return arr;
}

void ShowArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " \t");
        }
        Console.WriteLine();
    }
}

ShowArray(newArray);
Console.WriteLine();
int[,] secondArray = SortBubbleTwoDementionalArray(newArray);
ShowArray(secondArray);












// Задача 2: Задайте прямоугольный двумерный массив. (РАБОТАЕТ)
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

/*

int[,] CreateTwoDementionalArray(int m, int n)
{
    int[,] arr = new int[m,n];
    Console.WriteLine("Рандомный массив:");

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        arr[i,j] = new Random().Next(1,10);
    }
    return arr;
}


void ShowArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " \t");
        }
        Console.WriteLine();
    }
}




void MinSumArrowRow(int[,] arr)
{
    int sum = 0;
    
    for(int i = 0, j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i,j];
    }
    int min = sum;
    Console.WriteLine($"{min}");

    int row = 0;
    sum = 0;

    for(int i = 1; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {  
            sum = sum + arr[i,j];
        }
        Console.WriteLine($"{sum}");
        
        if(sum < min)
        {
            min = sum;
            row = i;
        }

        sum = 0;
    }
    Console.WriteLine($"{row+1} row = {min}");
}

int[,] thirdArray = CreateTwoDementionalArray(4,4);
ShowArray(thirdArray);
Console.WriteLine();

MinSumArrowRow(thirdArray);

*/









// Задача 3. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

/*
int[,] SpiralArray(int m, int n) 
{
    Console.WriteLine("Заполнение массива по спирали:");

    int[,] arr = new int[m,n];

    int countNum = 0;
    int decrement = 0;

    int halfRows;
    if(m % 2 == 0) halfRows = m/2;
    else halfRows = m/2+1;

    for(int i = 0, j = 0; i < halfRows; j++, m--, n--, decrement++)
    {
        for(; j < n; j++)
        {
            countNum++;
            arr[i,j] = countNum;
        }
        j--;

        for(i++; i < m; i++)
        {
            countNum++;
            arr[i,j] = countNum;
 
        }
        i--;

        for(j--; j >= decrement; j--)
        {
            countNum++;
            arr[i,j] = countNum;
        }
        j++;

        for(i--; i > decrement; i--)
        {
            countNum++;
            arr[i,j] = countNum;
        }
        i++;
    }
    return arr;
}


void ShowArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " \t");
        }
        Console.WriteLine();
    }
}


int[,] snailArray = SpiralArray(8,7);
ShowArray(snailArray);

*/




