	//3.	Tabuada: Faça um programa que solicite um número 
    //inteiro e exiba a tabuada desse número de 1 a 10.

int numero;
int resultado;

Console.WriteLine("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{   
    resultado = numero * i;
    Console.WriteLine(numero + " x " + i + " = " + resultado);  

}

