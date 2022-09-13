
Console.WriteLine("Введите массив из 8 чисел");
int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = int.Parse(Console.ReadLine()!);
}

double arithmeticMean(int[] array1)
{
    double Arithmet = 0;
    double sum = 0;
    for(int i = 0; i < 8; i++)
    {
        sum = sum + array1[i];
    }
    Arithmet = sum / 8;
    return Arithmet;
}

Console.WriteLine(arithmeticMean(array));


