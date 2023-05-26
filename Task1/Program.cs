// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int ExNumbers(int A, int B)
{
    int res = A;
    int count = 1;
    
    while (count < B)
    {
        res = res * A;
        count++;
    }
    return res;
}

int first_number = ReadInt("Insert first number: ");
int second_number = ReadInt("Insert second number: ");
int res = ExNumbers(first_number, second_number);
System.Console.WriteLine(res);