Console.Clear();


// Ex64();
// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Ex64()
{
    Console.WriteLine("Введите натуральное число M:");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите натуральное число N:");
    int numberN = Convert.ToInt32(Console.ReadLine());

    void FindNaturalMultipleOfThree(int number, int coint = 1)
    {
        if (coint > number) return;

        if (coint % 3 == 0) Console.Write(coint + "  ");

        FindNaturalMultipleOfThree(number, ++coint);
    }
    FindNaturalMultipleOfThree(numberN, numberM);
}



// Ex66();
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Ex66()
{
    Console.WriteLine("Введите натуральное число M:");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите натуральное число N:");
    int numberN = Convert.ToInt32(Console.ReadLine());

    int FindSumNaturalNumber(int number, int coint = 1, int sum = 0)
    {
        if (coint > number) return sum;

        sum += coint;

        return FindSumNaturalNumber(number, ++coint, sum);
    }
    int sum = FindSumNaturalNumber(numberN, numberM);

    Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна: {sum}");
}





