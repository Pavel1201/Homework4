Console.WriteLine("Введите число!");
int number = int.Parse(Console.ReadLine()!);

int sumofDigits(int number1)
{
    int sum = 0;
    int digit = 0;

    while(number1!=0)
{
    digit = number1 % 10;
    sum = sum + digit;
    number1 = number1 / 10;
}
return sum;
}

Console.WriteLine(sumofDigits(number));