
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int FindExp(int num, int index)
{
    int exp = 1;
    for(int i=1;i<=index;i++)
        exp = exp*num;
    return exp;
}

Console.Write("Input natural number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input natural number 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} to the power of {b} is {FindExp(a,b)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumbers(int number)
{
    int current = 0;
    int sum = 0;
    while (number > 0)
    {
        current = number % 10;
        number = number / 10;
        sum = sum + current;
    }
    return sum;
}
Console.Write("enter integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(n));
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] Array(int size, int n1, int n2, int n3, int n4, int n5, int n6,int n7,int n8)
{
    int[] newArray = new int[size];
    newArray[0] = n1;
    newArray[1] = n2;
    newArray[2] = n3;
    newArray[3] = n4;
    newArray[4] = n5;
    newArray[5] = n6;
    newArray[6] = n7;
    newArray[7] = n8;
    return newArray;
}

void DemoArray(int[] array)
{
    for(int i=0;i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите 1 число массива - ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число массива - ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число массива - ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 4 число массива - ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 5 число массива - ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 6 число массива - ");
int n6 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 7 число массива - ");
int n7 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 8 число массива - ");
int n8 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ваш массив - ");
DemoArray(Array(8,n1,n2,n3,n4,n5,n6,n7,n8));

*/
