﻿using System;

namespace Do_white_com_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do white com Array");

            string[] nomes = new string[3];
            int contador = 0;

            while(contador<3)
        {
            System.Console.WriteLine($"Digite o {contador+1}º nome");
            nomes[contador] = Console.ReadLine();
            contador++;
        }
        contador = 0;
        while(contador<3){
            System.Console.WriteLine($"O nome na posição {contador} é {nomes[contador]}");
            contador++;
        }


            
        }
    }
}
