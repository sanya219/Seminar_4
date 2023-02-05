// Задача 1
/*
int DigitCount(int number)
{
    int count = 0;
    while(number != 0)
    {
        count++;
        number /= 10;
    }
    return count;
}

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits is: " + DigitCount(num));
*/
// Задача 2
int Factorial(int number)
{
    int result = 1;
    /* for(int i = 1; i <= number; i++)
        result *= i; */

    while(number > 1)
        result *= number--;

    return result;
}

Console.Write("Enter number N: ");
//int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Factorial(Convert.ToInt32(Console.ReadLine())));