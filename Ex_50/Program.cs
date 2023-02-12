//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
        array [i, j] = Convert.ToInt32(new Random().Next(0,100));
    }  
}

bool checkSomething(int x, int y, int checkData){
    //Console.Write(array[x][y]);
    return array[x, y] == checkData;
}

for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
    }
}
 
Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(checkSomething(a, b, c));
