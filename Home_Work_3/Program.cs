// Задача 1.
// Вариант 1 (через массив).
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
int[]myArray=new int[5] {1,2,8,2,1};
 if(myArray[0]==myArray[4]&&(myArray[1]==myArray[3]))
    Console.Write ("YES_This_is_a_palindrome");
else
    Console.Write("NO_It's_not_a_palindrome");


// Вариант 2 (через метод).

void Pal(int N)
{
    int x1 = N / 10000;     // первая цифра
    int x2 = (N/1000)%10;   // вторая цифра
    int x4 = (N%100)/10;    // четвертая цифра
    int x5 = N%10;          // пятая цифра
                            
    if(x1==x5 && x2==x4)    // Сравнение цифр.
    {
        Console.Write ("YES_This_is_a_palindrome");
    }
    else
        Console.Write("NO_It's_not_a_palindrome");  

}
Pal(14212);


// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек и находит
//  расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

void Line(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double Line = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)); 
    Console.WriteLine("A (" + x1 + ", " + y1 + ", " + z1 + ");" + " B (" + x2 + ", " + y2 + ", " + z2 + ") -> " + Line);
}    

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Line(x1, y1, z1, x2, y2, z2);
*/

// Задача 3

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num;
Console.Write("N ->");
int N = Convert.ToInt32(Console.ReadLine());

for(num=1;num<=N;num++)
{
    if(num<=N)
    {
        int current;
        current = num*num*num;
        Console.WriteLine(current);
    }
}







