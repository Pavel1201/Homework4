int[] inputArray()

{
    Console.WriteLine("Введите числа через ,");
    string numbers = Console.ReadLine()!;
    string[] numbersSplited = numbers.Split(',');
    int[] array = new int[numbersSplited.Length];

    for(int i = 0; i < numbersSplited.Length; i++)
    {
        array[i] = int.Parse(numbersSplited[i]);
    }
    return array;
}

void outputArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i!=array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");

        }

    }
    Console.Write("]");

}

int[] ourArray = inputArray();
outputArray(ourArray);

