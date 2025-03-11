// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1!");
Console.WriteLine("Modyfikacja 2!");
Console.WriteLine("Modyfikacja 3!");

static int Average(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum / numbers.Length;
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