// Faça um programa para um filme que leia a idade de uma pessoa e classifique-a em uma das seguintes categorias:
// •	Criança (menor que 12),
// •	Adolescente (entre 12 e 18),
// •	Adulto (entre 18 e 60),
// •	Idoso (maior que 60).

Console.WriteLine("Coloque sua idade para ver o filme do GTA VI: ");
int idade = int.Parse(Console.ReadLine());

if (idade < 12) 
{
    Console.WriteLine("Uma criança não pode ver este filme, é proibido para menores de 18 anos");  
} else if (idade <= 18){
    Console.WriteLine("Um adolescente não pode ver este filme, é proibido para menores de 18 anos");
} else if (idade <= 60){
    Console.WriteLine("Um adulto pode ver este filme");
} else {
    Console.WriteLine("Um Idoso pode ver este filme e tem entrada gratuita");
}






