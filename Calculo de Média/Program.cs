using System;

namespace primeiroapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a 1ª"); //Digite a primeira linha
            int numero1 = int.Parse(Console.ReadLine()); // informando o numero no sistema 

             Console.WriteLine("Digite a 2ª");
            int numero2 = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite a 3ª");
            int numero3 = int.Parse(Console.ReadLine());

            float soma = (numero1+numero2+numero3);// informando a soma das atribuições 
            float media = soma/3; // informando a média 
            float mult = numero1*3;

            Console.WriteLine($"A média é de: {media}"); 
            Console.WriteLine($"O resultado que foi solici pela Carol é {mult}");
                 


        }
    }
}
