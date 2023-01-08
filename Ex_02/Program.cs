// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintNumbers(int N, int M)
{
    if(N <= M)
    {
        PrintNumbers(N, M -1);
        Console.Write($"{M} ");
    }
    if (N > M)
    {
        Console.WriteLine("некорректный ввод");
    }
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//запрашиваем у пользователя число N
int N = EnterNumber("Введите число N:");
int M = EnterNumber("Введите число M: ");
//рекурсия, которая выводит все числа в промежутке от 1 до N
PrintNumbers(N, M);