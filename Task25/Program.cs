// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Prompt(string msg)
{
    Console.WriteLine(msg);
    string readInput = Console.ReadLine(); //Вводим значение
    int result = int.Parse(readInput); //приводим к числу
    return result; //возвращаем результат
}

int Result(int A, int B)
{
    int a1 = 1;
    for (int i=0; i < B; i++)
    {
        a1 *= A; 
    }
    return a1;
}
bool Exp(int B)
{
    if (B < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше 0");
        return false;
    }
    return true;
}

int A = Prompt("Введите основание: ");
int B = Prompt("Введите показатель степени: ");
 if (Exp(B))
 {
    Console.WriteLine($"Число {A} в степени {B} равно {Result(A, B)}");
 }


