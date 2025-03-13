// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1!");
Console.WriteLine("Modyfikacja 2!");
Console.WriteLine("Modyfikacja 3!");

static int Average(int[] numbers)
{
    int result = 0;
    foreach (int number in numbers)
    {
        result += number;
    }
    return result / numbers.Length;
}

static int Max(int[] numbers)
{
    int max = numbers[0];
    foreach (int number in numbers)
    {
        if (number > max)
            max = number;
    }
    
    return max;
}

int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
Console.WriteLine(Average(numbers));
Console.WriteLine(Max(numbers));
