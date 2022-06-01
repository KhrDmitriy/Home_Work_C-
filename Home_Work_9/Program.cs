




// Задача 1: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// 1 Вариант.
int SumFromToRecurs(int m, int n)
{
    if(m>=n)
    {
        return m;
    }
    else
    {
        return m + SumFromToRecurs(m+=1, n);
    }   
}

int x = SumFromToRecurs(4,8);
Console.WriteLine("Сумма (m -> n) = " + x);


/*
2 Вариант.
int SumFromToRecurs(int m, int n)
{
    if(m<=n)
    {
        return m + SumFromToRecurs(m+=1, n);
    }

    else return 0;
}

int x = SumFromToRecurs(1,15);
Console.WriteLine("Сумма (m -> n) = " + x);

*/




// Задача 2: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9
/*
// 1 Вариант.
int SumOfDigitsInNumber(int a)
{
    if(a > 0)
    {
        return a % 10 + SumOfDigitsInNumber(a/10);
    }
    else return 0;
}

Console.WriteLine("Сумма цифр в числе равна: " + SumOfDigitsInNumber(453));
*/

/*
// 2 Вариант.
int SumOfDigitsInNumber(int N)
{
    if(N < 10)
    {
        return N;
    }
    else
    {
        return N % 10 + SumOfDigitsInNumber(N/10);
    }
}
Console.WriteLine("Сумма цифр в числе равна: " + SumOfDigitsInNumber(453));

*/



