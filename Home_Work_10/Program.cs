

// Задача 1: Задайте массив строк. Напишите программу,
//  считает кол-во слов в массиве, начинающихся на гласную букву.

// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

/*
string[] words = {"qwestion", "error", "true", "Answer", "you", "relation", "Require", "request", "Order", "vowel", "item", "I"};

int CountVowel(string[] arr)
{
    string[] vowel = {"AEIOUYaeiouy"};  //Массив гласных букв с которым будут сравниваться первые буквы каждого слова.

    int count = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = 0; j < vowel[0].Length; j++)
        {
            if(arr[i][0] == vowel[0][j])
            {
                count = count + 1;
                break;
            }
        }
    }
    return count;
}
Console.WriteLine($"В массиве {CountVowel(words)} слов(а), начинающихся с гласной буквы.");
*/

// Задача 2: Задайте массив строк. Напишите программу, 
// которая генерирует новый массив, объединяя элементы исходного массива попарно.

// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] words = {"qwestion", "error", "true", "Answer", "you", "relation", "Require", "request", "Order", "vowel", "item", "I"};
void PairsArray(string[] arr)
{
    int size = arr.Length/2;
    string[] newArray = new string[size];

    for(int i = 0, j = 0; i < arr.Length; i+=2, j++)
    {
        newArray[j] = arr[i] + arr[i + 1];
        Console.Write($"{newArray[j]}, ");
    }
}

PairsArray(words);
Console.WriteLine();













