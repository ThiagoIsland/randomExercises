// // 	Crie uma matriz 3x3 onde o usuário insira os valores. Em seguida, mostre:
// // 	•	A soma de todos os elementos.
// // 	•	Os elementos da diagonal principal (posição [0,0], [1,1] e [2,2]).

Console.WriteLine("Digite os valores da matriz 3x3:");
int[,] matriz = new int[3, 3];  
int soma = 0;

for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());

                soma += matriz[i, j];
            }
    }

Console.WriteLine($"\nA Soma de todos os elementos: {soma}");

Console.WriteLine("Elementos da diagonal principal:");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Elemento [{i},{i}] = {matriz[i, i]}");
    }

// 	Crie uma matriz 5x5 onde o usuário insira os valores. Em seguida, mostre:

// 	•	A soma de todos os elementos.
// 	•   A media de todos os elementos.
// 	•	Os elementos da diagonal principal (posição [0,0], [1,1], [2,2], [3,3] e [4,4]).

Console.WriteLine("Digite os valores da matriz 5x5:");
int[,] matriz = new int[5, 5];  
int soma = 0;
int media = 0;

for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());

                soma += matriz[i, j];
                media = soma / 25;
            }
    }

Console.WriteLine($"\nA Soma de todos os elementos: {soma}");
Console.WriteLine($"\nA Media de todos os elementos: {media}");

Console.WriteLine("Elementos da diagonal principal:");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Elemento [{i},{i}] = {matriz[i, i]}");
    }