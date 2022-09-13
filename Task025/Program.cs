Console.WriteLine("Введите число!");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите, в какую степень возвести!");
int degree = int.Parse(Console.ReadLine()!);

int exponentiation(int number1, int degree1)
{
    int product = 1;
    for(int i = 0; i < degree1; i++)
    {
        product = product * number1;

    }
    return product;

}

Console.WriteLine(exponentiation(number, degree));