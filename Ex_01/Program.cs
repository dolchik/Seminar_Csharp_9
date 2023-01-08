// Задача 63: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void PrintNumbers(int number, int count)
{
    if(count <= number)
    {
        Console.Write(count + ",");
        count++;
        PrintNumbers(number, count);
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
int count =1;
//рекурсия, которая выводит все числа в промежутке от 1 до N
PrintNumbers(N, count);
