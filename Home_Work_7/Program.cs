//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
//1 Вариант.(РАБОТАЕТ)
void PrintMatrix()
{
	int[,]matrix = new int[3,4];
	for(int i = 0; i < matrix.GetLength(0); i++)
	{
    	for(int j = 0 ;j < matrix.GetLength(1); j++)
    	{
        	matrix[i,j] = new Random().Next(0,10);
        	Console.Write(matrix[i,j]+ " ");
    	}
     	Console.WriteLine();
	}
}
PrintMatrix();	
*/

//2Вариант.(РАБОТАЕТ)
/*

	int[,] myArray = new int[3, 4];
	Random random = new Random();	//random – имя объекта.
	for(int i=0; i < myArray.GetLength(0); i++)
	{
    	for(int j=0; j < myArray.GetLength(1); j++)
		{
			myArray[i,j]=random.Next(10);		
		}
	}
	
	for(int y=0; y< myArray.GetLength(0); y++)
	{
    	for(int x=0; x< myArray.GetLength(1); x++)
		{
			Console.Write(myArray[y,x]+ "\t");
		}
		Console.WriteLine();
	}

*/














//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17 -> такого числа в массиве нет
/*
int[,] myArray =	//Создание и заполнение массива.
{ 
    {1, 4, 7, 2}, 
    {5, 9, 2, 3}, 
    {8, 4, 2, 4} 
};


// Работает.

Console.Write("Enter the coordinate string  X: ");
int x = Convert.ToInt32(Console.ReadLine());	//номер строки.
Console.Write("Enter the coordinate column Y: ");
int y = Convert.ToInt32(Console.ReadLine());	//номер столбца.
Console.Write("enter a number: ");
int Num = Convert.ToInt32(Console.ReadLine());	//искомое число по координатам X и Y.

void FindTheNumber(int[,]myArray)
{
	if(myArray[x,y]==Num)
		Console.WriteLine(Num +"\t"+ "YES, there is such a number");
	else
		Console.WriteLine(Num + "--> there is NO such number in the array");
}
FindTheNumber(myArray);

*/







/*
//Поиск элемента в массиве.
for(int i= 0; i < myArray.GetLength(0); i++)
{
	for(int j= 0; j <myArray.GetLength(1); j++)
	{
		if(myArray[i,j]==9)
			Console.WriteLine(myArray[i,j]);
		else
			Console.WriteLine("N");
	}		
}
*/

/*
//Создание и заполнение массива с консоли.
int[,]myArray=new int[3,4];
for(int i=0; i <myArray.GetLength(0); i++)
{
	for(int j=0; j <myArray.GetLength(1); j++)
	{
	    Console.Write("Y: " + i + " X: "+ j +"--> ");
	    myArray[i,j]=Convert.ToInt32(Console.ReadLine());
	}
}
Console.WriteLine(myArray);


//Вывод массива в консоль.
int height = myArray.GetLength(0);
int width = myArray.GetLength(1);
for(int y=0; y< myArray.GetLength(0); y++)
{
    for(int x=0; x< myArray.GetLength(1); x++)
	{
		Console.Write(myArray[y,x]+ "\t");
	}
	Console.WriteLine();
}


*/















//Задача 3. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] ArrayCreation()
{
// Создание и заполнение массива числами от 0 до 10.
	int[,] myArray = new int [4, 4];	//Создание массива.
	Random random = new Random();		//random – имя объекта.
	for(int i=0; i< myArray.GetLength(0); i++)
	{
    	for(int j=0; j< myArray.GetLength(1); j++)
		{
			myArray[i,j]=random.Next(10);	 
		}		 
	}
	return myArray;
}	
// Console.WriteLine(ArrayCreation()); 

//ВЫВОД массива на консоль.
void PrintMatrix(int[,]myArray)
{
	for(int y=0; y< myArray.GetLength(0); y++)
	{
		for(int x=0; x< myArray.GetLength(1); x++)
		{
			Console.Write(myArray[y,x] +"\t");
		}
		Console.WriteLine();
	}
}	
int[,]Array=ArrayCreation();
PrintMatrix(Array);

void SumMatrix(int[,]myArray)
{
	double sumColumn = 0;
	for(int j=0;j<myArray.GetLength(1);j++)
	{
		for(int i=0; i<myArray.GetLength(0); i++)
		{
			sumColumn += myArray[i,j];	//Сумма всех элементов колонки.
			
		}
		Console.WriteLine();
		// Console.WriteLine("Сумма " +(j+1) + "колонки равна " + sumColumn);	//Вывод суммы колонки.
		Console.WriteLine("Сумма " +(j+1) + "колонки равна " + sumColumn/4);	//Вывод среднего арифметического колонки.
		sumColumn = 0;
	}
	
}	
SumMatrix(Array);
















/*
//СУММА элементов ВСЕГО массива.
int sum=0;		//Объявление переменной sum.
for(int i=0; i< myArray.GetLength(0); i++)
{
    for(int j=0; j< myArray.GetLength(1); j++)
	{
    	sum=sum+myArray[i,j];	//Сумма всей матрицы. 
	}	
}
Console.WriteLine(sum); 
*/

/*
//СУММА ЭЛЕМЕНТОВ КАЖДОЙ СТРОКИ.
double sumString=0;
for(int i=0;i<4;i++)
{
	for(int j=0; j<4; j++)
	{
		sumString += myArray[i,j];	//Сумма всех элементов строки.
	}
	Console.WriteLine();
	// Console.WriteLine("Сумма " +(i+1) + "строки равна " + sumString);	//Вывод суммы строки.
	Console.WriteLine("Сумма " +(i+1) + "строки равна " + sumString/4);	//Вывод среднего арифметического строки.
	sumString = 0; 	//После прохода цикла обнуляем сумму строки.
}
*/


/*
//ВЫВОД массива на консоль.
for(int y=0; y< myArray.GetLength(0); y++)
{
	for(int x=0; x< myArray.GetLength(1); x++)
	{
		Console.Write(myArray[y,x] +"\t");
	}
	Console.WriteLine();
}
*/












// СЕМИНАР.

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
int[,] myArray =	//Создание и заполнение массива.
{ 
    {1, 4, 7, 2}, 
    {5, 9, 2, 3}, 
    {8, 4, 2, 4} 
};
Console.WriteLine();

int[,] newArray = new int[myArray.GetLength(1),myArray.GetLength(0)];
for(int i = 0; i < myArray.GetLength(0); i++)
{
	for(int j = 0; j < myArray.GetLength(1); j++)
	{
		newArray[j,i] = myArray[i,j];
	}
	
}
Console.WriteLine(newArray);

*/
/*
1.	Задача.
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

2.	Задача.
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

*/




