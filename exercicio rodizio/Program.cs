using System;

namespace exercicio_rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercicio Rodizio");

            Console.WriteLine("Digite o numero placa1");
            int placa = int.Parse(Console.ReadLine());


            if(placa==0||placa==1)
            {
                System.Console.WriteLine("segunda-feira");
            }

            else if(placa==2||placa==3){
                System.Console.WriteLine("Terça-feira");
            }
            else if(placa==4||placa==5){
                System.Console.WriteLine("Quarta-feira");
            }
            else if(placa==6||placa==7){
                System.Console.WriteLine("Quinta-feira");
            }
            else{
                System.Console.WriteLine("Digite o ultimo numero");
            }



        }
    }
}
