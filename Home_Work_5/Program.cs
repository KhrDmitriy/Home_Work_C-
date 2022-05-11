//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//1 Вариант с помощью функции Math.Pow
/*
Console.Write("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень ");
int N = Convert.ToInt32(Console.ReadLine());

void Stepen(int num, int n)
{
    Console.Write(Math.Pow(num,n));
}
Stepen(Num,N);
*/


/*
//2 Вариант.

Console.Write("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень ");
int N = Convert.ToInt32(Console.ReadLine());
int Num_N=1;

void Stepen(int num, int n)
{
    for(int i=0; i < N; i++)
    {
        Num_N*= Num;   
    }
    Console.Write(Num_N);
}
Stepen(Num,N);

*/


//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


void SumFromNum(int x) 
{
    int start_num = x; //Начальное число
    int last = x;   //Последнее число
    int sum = 0;    //Сумма чисел
    for(int i = 0; x > 10; i++) 
    {
        last = x%10;    //Записываем последнюю цифру (остаток от деления).
        sum = sum + last;   //Cумма прошлых чисел + текущее число.
        x = x/10;   // Начальное число уменьшается на знак (последнюю цифру).
    }

    sum = sum + x;  //При выходе из цикла записывается последняя цифра.
    Console.WriteLine($"Сумма всех цифр в числе {start_num} равна: {sum}");
}
Console.Write("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());
SumFromNum(Num); 





//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*
//1 Вариант.
void PrintArray()
{
    Console.Write("Введите количество элементов массива: ");   //Можно запросить размер массива с консоли.
    int elementsCount = Convert.ToInt32(Console.ReadLine());    //Ввод размера массива в переменную elementsCount.
    int[]myArray=new int[elementsCount];    //Создание массива с вводом размера с консоли.
    //int[] myArray = new int[8];       //Создание массива на 8 элементов.
    for(int i=0; i < myArray.Length; i++)
    {
        Console.Write("Введите элемент массива под индексом "  + i + " --> ");
        myArray[i] = Convert.ToInt32(Console.ReadLine()); //Строка запроса данных с консоли
    }
    // После создания массива ещё раз запускаем цикл for для вывода массива в консоль. 
    for(int i=0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] +" ");    //Вывод массива в консоль + пробел между элементами.
    }
}
PrintArray();   //Вызов метода PrintArray.
*/

/*
//2 Вариант как на семинаре.

int[  ] CreateArray(int size)		// Метод создания массива в ручную.
{
	int[] array = new int[size];
	
	for(int i=0; i<size; i++)
    {
	    Console.Write("Введите "  + i +  " element --> ");
		array[i]= Convert.ToInt32(Console.ReadLine());
	}
	return array;
}
void ShowArray(int[] array)	//Метод вывода массива на экран.
{
	for(int i =0; i <array.Length; i++)
    {
		Console.Write(array[i] +"  ");
    }    
	Console.WriteLine();
}

int[  ] myArray = CreateArray(8);
ShowArray(myArray ); 

*/






