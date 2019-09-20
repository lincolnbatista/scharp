using System;

namespace arrays_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays Ex3");
            Console.WriteLine("feira do tsuka");

            string[] compras = new string[6];

            int contador = 0;
            while(contador < 6){

                System.Console.WriteLine("digite o produto");
                compras [contador] = Console.ReadLine();

             contador++;
            }

            int contadorA = 0;
            while(contadorA < 6){
                System.Console.WriteLine($"{compras[contadorA]}");
                
                contadorA++;
            }




        }
    }
}
