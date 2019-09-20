using System;

namespace exercicio_da_Carol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App da Carol");
            Console.WriteLine("Carol foi no bar");

            Console.WriteLine("Caipirinha 1");
            int caipirinha1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Caipirinha2");
            int Caipirinha2 = int.Parse(Console.ReadLine());
            Console.WriteLine("caipirinha1 3");
            int Caipirinha3 = int.Parse(Console.ReadLine());

         float soma = (caipirinha1+Caipirinha2+Caipirinha3);
    

         Console.WriteLine($"Resultado total é {soma}");
         
        }
    }
}
