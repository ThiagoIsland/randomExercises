int[] numbers = new int[200];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;
}

foreach(int number in numbers)
{
    if(number % 2 != 0)
    {
        Console.WriteLine($"O número {number} é impar");
    }
}   