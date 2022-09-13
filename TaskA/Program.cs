
Console.WriteLine("Среднее арифметическое 8 случайных чисел: ");
int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(1,100);
    
}

double arithmeticMean(int[] array)
{
    double Arithmet = 0;
    double sum = 0;
    for(int i = 0; i < 8; i++)
    {
        sum = sum + array[i];
    }
    Arithmet = sum / 8;
    return Arithmet;
}

Console.WriteLine(arithmeticMean(array));

int maximum (int[] array)
{
    int max = array[0];
    for (int i = 0; i < 8; i++)
    {
        if(array[i]  > max)
        {
            max = array[i];


        }
        


    }
    return max;

}

int maximum1 = maximum(array);
Console.WriteLine(maximum1);

void even(int[] array)
{   int count = 0;
    for(int i = 0; i < 8; i++)
    {
        if(array[i] % 2 != 0)
        {
            Console.WriteLine("Нет");
            break;
        }
        else
        {
            count++;

        }

    }
    if(count == 8)
    {
        Console.WriteLine("Все числа четные");

    }



}

even(array);

void increasing (int[] array)
{   int count = 0;
    for(int i = 1; i < 8; i++)
    {
        if(array[i] < array[i-1])
        {
            Console.WriteLine("Нет");
            break;

        }
        else
        {
            count++;

        }
                             
    }
    if( count == 7)
    {
        Console.WriteLine("Массив по возрастанию.");

    }


}

increasing(array);