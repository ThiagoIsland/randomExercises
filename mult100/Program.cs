int[] numbers = new int[100];


for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;

}

foreach(int number in numbers)
{
    Console.WriteLine(number);
    if(number % 10 == 0)
    {
        Console.WriteLine("Múltiplo de 10");
    }
}