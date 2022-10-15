Console.Clear();


Ex64();
// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Ex64()
{
    Console.WriteLine("Введите натуральное число M:");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите натуральное число N:");
    int numberN = Convert.ToInt32(Console.ReadLine());

    void FindNatural(int numNatural, int coint = 1)
    {
        if (coint > numNatural) return;

        if (coint % 3 == 0) Console.Write(coint + "  ");

        FindNatural(numNatural, ++coint);
    }
    FindNatural(numberN, numberM);
}


