// Descobrir forma do objeto geometrico
using System.Collections;

int forma;
double baseMaior, baseMenor, altura, raio, area, lado, diagonalMaior, diagonalMenor;   

do{
Console.WriteLine("Digite a forma do objeto geometrico: ");
Console.WriteLine("1 - Quadrado\n" +
                  "2 - Retângulo\n" +
                  "3 - Triângulo\n" +
                  "4 - Triângulo Equilátero\n" +
                  "5 - Círculo\n" +
                  "6 - Losango\n" +
                  "7 - Trapézio\n" +
                  "8 - Paralelogramo");
forma = int.Parse(Console.ReadLine());

switch(forma)
{
    case 1 : // Quadrado
        Console.WriteLine("Dgite o lado do quadrado: ");
        lado = double.Parse(Console.ReadLine());
        area = lado * lado;
        Console.WriteLine($"A área do quadrado é {area}");
        break;
    case 2 : // Retângulo   
        Console.WriteLine("Digite a base maior do retângulo: ");
        baseMaior = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a base menor do retângulo: ");
        baseMenor = double.Parse(Console.ReadLine());
        area = baseMaior * baseMenor;
        Console.WriteLine($"A área do retângulo é {area}");
        break;  
    case 3 : // Triângulo  
        Console.WriteLine("Digite a base do triângulo: ");
        baseMaior = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do triângulo: ");
        altura = double.Parse(Console.ReadLine());
        area = (baseMaior * altura) / 2;
        Console.WriteLine($"A área do triângulo é {area}");
        break;
    case 4 : // Triângulo Equilátero
        Console.WriteLine("Digite o lado do triângylo equilátero: ");
        lado = double.Parse(Console.ReadLine());
        area = (lado * lado * Math.Sqrt(3)) / 4;
        Console.WriteLine($"A área do triângulo equilátero é {area}");
        break;
    case 5 : // Círculo
        Console.WriteLine("Digite o raio do círculo: ");
        raio = double.Parse(Console.ReadLine());
        area = Math.PI * Math.Pow(raio, 2);
        Console.WriteLine($"A área do círculo é {area}");
        break;
    case 6 : // Losango
        Console.WriteLine("Digite a Diagonal maior do Losango");
        diagonalMaior = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a Diagonal menor do Losango");
        diagonalMenor = double.Parse(Console.ReadLine());
        area = (diagonalMaior * diagonalMenor) / 2;
        Console.WriteLine($"A área do Losango é {area}");
        break;
    case 7 : // Trapézio
        Console.WriteLine("Digite a base maior do trapézio: ");
        baseMaior = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a base menor do trapézio: ");
        baseMenor = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do trapézio: ");
        altura = double.Parse(Console.ReadLine());
        area = ((baseMaior + baseMenor) * altura) / 2;
        Console.WriteLine($"A área do trapézio é {area}");
        break;
    case 8 : // Paralelogramo 
        Console.WriteLine("Digite a base do paralelogramo: ");
        baseMaior = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do paralelogramo: ");
        altura = double.Parse(Console.ReadLine());
        area = baseMaior * altura;
        Console.WriteLine($"A área do paralelogramo é {area}");
        break;
    default:
        Console.WriteLine("Forma inválida, tente de novo");
        break;
}
} while (forma < 1 || forma > 8);
