using System;

namespace calculos_media_e_faltas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App Cálculo de média e faltas");
            Console.WriteLine("bem vindo a escola senai de informatica");
            //entrada de dados 
            Console.WriteLine("Digite a primeira nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a ssegunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            //processamento

            double media = (nota1+nota2)/2;

            if(media>50 && faltas<=30){
                //Resultados verdadeiro
                Console.WriteLine("Parabéns você foi aprovado");
            }else{
                //resultado falso
                Console.WriteLine("Parabéns você Reprovou");
            }


        }
    }
}
