	//1.	Verificar Número Par ou Ímpar: 
    //Crie um programa que solicite ao usuário 
    //a entrada de um número inteiro e informe se ele é par ou ímpar.
int numero;
int divisao; 
int encerrar;


do {
    Console.WriteLine("Digite um número: ");   
    numero = int.Parse(Console.ReadLine()); 

    divisao = numero % 2;

        if (divisao == 0)
        {
            Console.WriteLine("É par");
            Console.WriteLine("Deseja encerrar? 1 - Sim / 0 - Não");
            encerrar = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Não é par");
            Console.WriteLine("Deseja encerrar? 1 - Sim / 0 - Não");
            encerrar = int.Parse(Console.ReadLine());
        }

} while (encerrar == 0);

Console.WriteLine("Programa encerrado");
