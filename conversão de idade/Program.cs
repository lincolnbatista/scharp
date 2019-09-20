using System;

namespace conversão_de_idade
{
    class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("conversão de idade");
            Console.WriteLine("------------------");

            Console.WriteLine("Digite a sua idade");
            int idade = int.Parse(Console.ReadLine());
            int idadeDias = idade *365;
            int idadeMeses = idade *12;
            int idadeHoras = idadeDias * 24;
            int idadeMinutos = idadeHoras * 60;

            Console.WriteLine($"Idade em dias: {idadeDias}\n idade em meses: {idadeMeses}\n idade em horas: {idadeHoras}\n idade em minutos: {idadeMinutos}");
        }
    }
}
