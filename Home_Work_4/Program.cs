
//Задача 1: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*
void Sum()      //Создание метода.
{
    int[]myArray=new int[4];                    //Создание массива на 4 элемента.
    myArray[0] = new Random().Next(100,999);    //Заполнение элемента массива случайным числом.
    Console.WriteLine(myArray[0]);              //Вывод в консоль элемента масива под индексом 0 (Для посмотреть).
    myArray[1] = new Random().Next(100,999);
    Console.WriteLine(myArray[1]);      
    myArray[2] = new Random().Next(100,999);
    Console.WriteLine(myArray[2]);
    myArray[3] = new Random().Next(100,999);
    Console.WriteLine(myArray[3]);

    int count=0;                              // Переменная для счетчика. Где храниться результат.
    for(int i =0; i<myArray.Length;i++)
    {
        if(myArray[i]%2==0 )                 //Проверка на четность.
        count++;                             //Счетчик четных чисел.
    }
    Console.WriteLine("Количество чётных чисел " + count);
}
Sum();      //Вызов метода

*/

//Задача 2: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

/*
void Sum()   //Создание метода.
{
    int[]myArray=new int[5];                       //Создание массива на 4 элемента.
    int result=0;                                  //Переменная в которой будет храниться сумма чисел с нечетными индексами.
    for(int i =0; i < myArray.Length; i++)        //Цикл который пропустит через себя все элементы массива.
    {
         myArray[i]=new Random().Next(-99,99);       //В каждой ячейке (индекс) будет присвоено значение от -99 до 99.
        Console.WriteLine("Индекс" +i+ " = "+ myArray[i]);    //Строка выведет результат в консоль (индекс + число).
     
        if(i%2!= 0)                     //ЕСЛИ ИНДЕКС НЕЧЕТНОЕ ЧИСЛО
        result = result+myArray[i];    // Сумма нечетных элементов.
    }

    Console.WriteLine(result);
}
Sum(); //Вызов метода

*/

//Задача 3: 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

//doube - вещественные числа.
double[]CreateArray(int lenght) //Метод который возвращает массив
{
    double[]myArray=new double[lenght];   //Массив вещественных чисел.
    for(int i =0; i < myArray.Length; i++)
    {
        myArray[i]=new Random().Next(1,99);       
    }
    return myArray; //Возврат массива.
}
void PrintArray(double[]myArray)
   {
       for(int i=0; i < myArray.Length; i++)
       {
        Console.WriteLine("Индекс" +i+ " = "+ myArray[i]);
       }
   }

double Diff(double[]array)
{
    double minNum = array[0]; //Пусть минимальным числом будет 1 число массива.
    for(int i=0; i < array.Length; i++)
    {
        if(array[i] < minNum)
        minNum = array[i];
    }   
    Console.WriteLine("MIN число -->" +minNum);  

    double maxNum = array[0];
    for(int i=0; i < array.Length; i++)
    {
        if(array[i] > maxNum)
        maxNum = array[i];
    }           
    Console.WriteLine("MAX число -->" +maxNum);  

    double diff = maxNum-minNum;
    Console.WriteLine(diff);
    return diff;
}
Console.WriteLine ("Введите_размер массива : ");
int Size=Convert.ToInt32(Console.ReadLine());
double[]XYZ = CreateArray(Size);
PrintArray(XYZ); //Вывод массива.
double RES = Diff(XYZ);
Console.WriteLine("Разница max-min " +RES);
