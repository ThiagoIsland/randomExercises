
string frase; 

Console.WriteLine("Digite uma frase: ");
frase = Console.ReadLine();

char[] array = frase.ToCharArray();
Array.Reverse(array);
string invertida = new string(array);

Console.WriteLine("Frase invertida: " + invertida);
