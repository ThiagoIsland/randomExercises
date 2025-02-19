int[] numbers = new int[100];

for(int i = 99; 0 < numbers.Length; i--)
{
    numbers[i] = i + 1;
    Console.WriteLine($"Posicão: {i} // Número {numbers[i]}");
}