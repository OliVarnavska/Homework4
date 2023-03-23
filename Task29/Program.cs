// Задача 29: Напишите программу, которая задаёт
//  массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

//Ввод числа с экрана
int Prompt(string msg)
{

    Console.Write(msg); //Выводим приглашение ко вводу
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат

}
//метод для получения случайных значений массива
int[] Array(int Length, int minValue, int maxValue)
{

    int[] array = new int[Length];//объявляем массив 
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); //заполняем случайными
        //цифрами из диапазона SatrArr до EndArr

    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
            }
            Console.Write($"{array[array.Length - 1]}");
            Console.WriteLine("]");

}

int length = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = Array(length, min, max);
PrintArray(array);
