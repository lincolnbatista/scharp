using System;

namespace arrays_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetivo efetuar o cadastro do usuário com os seguintes
            //Dados nome, telefone e e-mail
            Console.WriteLine("Arrays ex 2");
            
            string[] nomes = new string[5];
            string[] telefones = new string[5];
            string[] emails = new string[5];

            int contador = 0;
            while(contador < 5){
                Console.WriteLine("DIgite o seu nome");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu telefone");
                telefones[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu email");
                emails[contador] = Console.ReadLine();

                contador++;
            }//fim do white

            int contadorB = 0;
            while(contadorB <= 2){
                Console.WriteLine($"O cliente número {contadorB+1} - Nome: {nomes [contadorB]}, Tel: {telefones [contadorB]}, E-mail: {emails[contadorB]}");
                contadorB++;
            }


        }
    }
}
