// Faça um programa que leia 5 números do usuário e armazene em um vetor.
// Em seguida, imprima o maior número, o menor e a média dos valores.

int[] numeros = {100, 200, 300, 400, 500};

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Número na posição {i}: {numeros[i]}");
}


int maior = numeros.Max();
int menor = numeros.Min();
Console.WriteLine($"Maior número: {maior}");
Console.WriteLine($"Menor número: {menor}");

int media = maior + menor / 2;
Console.WriteLine($"Média dos valores: {media}");




