	//2.	Cálculo de Média de Notas: Desenvolva um programa que leia quatro notas de um aluno, 
    //calcule a média e exiba se o aluno foi aprovado (média maior ou igual a 7) ou reprovado.

    double nota1, nota2, nota3, nota4, media;

    Console.WriteLine("Digite a primeira nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota: ");
    nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a terceira nota: ");  
    nota3 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quarta nota: ");
    nota4 = double.Parse(Console.ReadLine());

    media = (nota1 + nota2 + nota3 + nota4) / 4; 

    if (media >= 7){
        Console.WriteLine("Aprovado! Média: " + media);
    } else {
        Console.WriteLine("Reprovado! Média: " + media);    
    }