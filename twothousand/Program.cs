int[] numbers = new int[2000];


for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;
    Console.WriteLine($" Posição {i} // Número: {numbers[i]}");
}