/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


int InputNum(string message) //ввод параметров
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size) //создание массива (ссылки на массив) с заданным размером 
{
    return new int[size];
}

void FillArray(int[] array) //заполнение массива
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 1000); 
}

int CountEvenArray(int[] array) //изменение массива
{
    int countEvenNum = 0;
    foreach (int item in array)
        if (item % 2 == 0) countEvenNum ++; 
    return countEvenNum;
}        

string PrintArray(int[] array) //вывод массива в строку
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int size = InputNum("Введите размер массива: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
int numEven = CountEvenArray(myArray);
Console.WriteLine(numEven);


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int InputNum(string message) //ввод параметров
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size) //создание массива (ссылки на массив) с заданным размером 
{
    return new int[size];
}

void FillArray(int[] array) //заполнение массива
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(-99, 100); 
}                                      

int SumOddArray(int[] array) 
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i]; 
    return sum;
}        

string PrintArray(int[] array) //вывод массива в строку
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int size = InputNum("Введите размер массива: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
int numOdd = SumOddArray(myArray);
Console.WriteLine(numOdd);
*/


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

/*
int InputNum(string message) //ввод параметров
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size) //создание массива (ссылки на массив) с заданным размером 
{
    return new double[size];
}

void FillArray(double[] array) //заполнение массива
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.NextDouble() + rnd.Next(0, 100);
}

double MinMaxArray(double[] array)
{
    int max = 0;
    int min = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[max] < array[i]) max = i;
        if (array[min] > array[i]) min = i;
    }
    double res = array[max] - array[min];
    return res;
}

string PrintArray(double[] array) //вывод массива в строку
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += Math.Round(array[i], 2) + " ";
    return res;
}

int size = InputNum("Введите размер массива: ");
double[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
double res = MinMaxArray(myArray);
Console.WriteLine(Math.Round(res, 2));
*/