//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

int n = 3;
int size = 6;
string[] arrayOne = new string[size];
Console.WriteLine($"Введите набор символов, обозначающий значение элемента массива, {size} раз, через Enter, без пробелов");
FillArray(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"готовый массив, размер которого меньше либо равен {n}:");
Console.WriteLine();
if (GetSecondArray(arrayOne) ==0)
{
    Console.Write("заданы значения больше 3 символов, выполнение программы невозможно");
}
else
{
    string[] arrayTwo = TansferOfElements(arrayOne);
    PrintArray(arrayTwo);
}


void FillArray (string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine()!;
    }
}
void PrintArray(string[] arr)
{
    int arrleng = arr.Length;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int GetSecondArray(string[] arr)
{
    int secondsize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            secondsize++;
        }
    }
    return secondsize;
}

string[] TansferOfElements(string[] arr)
{
    string[] arrayTwo = new string[GetSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    } 
    return arrayTwo;   
}
