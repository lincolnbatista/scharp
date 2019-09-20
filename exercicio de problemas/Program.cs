using System;

namespace exercicio_de_problemas
{
    class Program
    {
        static void Main(string[] args)
        {

       Console.WriteLine("Digite a primeiro valor");
           
            
            Console.WriteLine(" APP do menu");
            Console.WriteLine("(1) - Soma de 2 números");
            Console.WriteLine("(2) - Subtração do primeiro pelo segundo");
            Console.WriteLine("(3) - Subtração do segunndo pelo primeiro");
            Console.WriteLine("(4) - Multiplicação dos dois números");
            Console.WriteLine("(5) - Divisão do primeiro pelo segundo");
            Console.WriteLine("(6) - Divisão do segundo pelo primeiro");

            Console.WriteLine("--------------------------------------");
            string num = Console.ReadLine();
                switch(num){
                    case "1":
                    System.Console.WriteLine("digite o primeiro numero");
                    int num1 =int.Parse(Console.ReadLine());
                    System.Console.WriteLine("digite o segundo numero");
                    int num2 =int.Parse(Console.ReadLine());
                    int soma = num1 + num2 ;
                    System.Console.WriteLine($"resultado é:{soma}");
                    break;
                    
                    case "2":
                    System.Console.WriteLine("Digite o primeiro numero");
                    int sub1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo numero");
                    int sub2 = int.Parse(Console.ReadLine());
                    int soma1 = sub1 - sub2;
                    System.Console.WriteLine($"resultado é {soma1}");
                    break;

                    case "3":
                    System.Console.WriteLine("Digite o primeiro numero");
                    int subtração1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo numero");
                    int subtração2 = int.Parse(Console.ReadLine());
                    int soma2 = subtração2 - subtração1;
                    System.Console.WriteLine($"resultado é {soma2}");
                    break;

                    case "4":
                    System.Console.WriteLine("Digite o primeiro numero");
                    int multi1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo numero");
                    int multi2 = int.Parse(Console.ReadLine());
                    int soma3 = multi1 * multi2;
                    System.Console.WriteLine($"resultado é {soma3}");
                    break;

                    case "5":
                    System.Console.WriteLine("Digite o primeiro numero");
                    int div1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo numero");
                    int div2 = int.Parse(Console.ReadLine());
                    int soma4 = div1 / div2;
                    System.Console.WriteLine($"resultado é {soma4}");
                    break;

                    case "6":
                    System.Console.WriteLine("Digite o primeiro numero");
                    int divisão1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo numero");
                    int divisão2 = int.Parse(Console.ReadLine());
                    int soma5 = divisão2 / divisão1;
                    System.Console.WriteLine($"resultado é {soma5}");
                    break;







                    }

    
            
        }
    }
}
