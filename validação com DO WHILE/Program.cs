using System;

namespace validação_com_DO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com DO WHILE");
            String nome;
        do
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
        }while (nome.Length <=1); //do while verifica a condição depois

        String senha;
        do
        {
            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();
        }while (senha.Length <=6);
        
        
            
        

        }
    }
}
