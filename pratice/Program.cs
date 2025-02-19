//  	Um script que impriome os números de 1 a 100, 
//     mas substitue os múltiplos de 2 por "Naruto", os múltiplos de 4 por "Luffy
//     e os múltiplos de 2 e 4 por "Naruto e Luffy".

for (int i = 1; i <= 100; i++){
    if(i % 2 == 0 && i % 4 == 0){
        Console.WriteLine("Naruto e Luffy");
    } else if (i % 2 == 0){
        Console.WriteLine("Naruto");
    } else if (i % 4 == 0){
        Console.WriteLine("Luffy");
    } else {
        Console.WriteLine(i);
    }
}






