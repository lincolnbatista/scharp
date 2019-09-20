using System;

namespace Vaidade_com_DO_WHILE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com  DO WHITE");
            String email;
            do{
                System.Console.WriteLine("Digite seu E-mail");
                email = Console.ReadLine();
            }while(!email.Contains("@") || !email.Contains("."));

            string senha;
            do{
                System.Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();
            } while (senha.Length <= 6);

        }
    }
}
